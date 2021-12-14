using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.Shared.Interfaces;
using FixtureWeb.DAL.Converters.Dto;
using FixtureWeb.DAL.Converters.Model;
using FixtureWeb.DAL.Models;
using System;

namespace FixtureWeb.DAL.Repositories
{
    public class FixtureRepository : IFixtureRepository
    {
        private readonly FixtureDBContext fixtureDBContext;

        public FixtureRepository(FixtureDBContext fixtureDBContext)
        {
            this.fixtureDBContext = fixtureDBContext;
        }

        public async Task<FixtureDto> CreateAsync(FixtureDto fixtureDto)
        {
            try
            {
                var fixture = fixtureDto.ConvertToDb();
                this.fixtureDBContext.Fixtures.Add(fixture);
                await this.fixtureDBContext.SaveChangesAsync();

                return fixtureDto;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<FixtureDto>> GetAllAsync()
        {
            var fixtures = await this.fixtureDBContext.Fixtures
                .Include(_ => _.Markets)
                .Include(_ => _.Metadata).ThenInclude(_ => _.MetadataSport)
                .Include(_ => _.Metadata).ThenInclude(_ => _.MetadataLocation)
                .Include(_ => _.Metadata).ThenInclude(_ => _.MetadataTiming)
                .Include(_ => _.Metadata).ThenInclude(_ => _.MetadataCompetitors)
                 .Include(_ => _.Metadata).ThenInclude(_ => _.MetadataCompetitors).ThenInclude(_ => _.MetadataCompetitorsChildren)
                .ToListAsync();

            return fixtures.ConvertToDto();
        }

        public async Task UpdateAsync(FixtureDto fixtureDto)
        {
            try
            {
                var fixture = this.fixtureDBContext.Fixtures
                    .Include(_ => _.Markets)
                    .FirstOrDefault(_ => _.Id == fixtureDto.Id);

                //Added code to update Markets only.
                if (fixtureDto.Markets != null)
                {
                    foreach (var item in fixtureDto.Markets)
                    {
                        var market = fixture.Markets.FirstOrDefault(_ => _.Id == item.Id);
                        if (market != null)
                        {
                            market.Title = item.Title;
                            market.Price = item.Price.ToString();
                            await this.fixtureDBContext.SaveChangesAsync();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task UpdateResultAsync(ResultDto resultDto)
        {
            try
            {
                var result = new Result()
                {
                    Fixture = this.fixtureDBContext.Fixtures
                    .Include(_ => _.Markets)
                    .FirstOrDefault(_ => _.Id == resultDto.Id),
                };

                foreach (var item in resultDto.Winners)
                {
                    result.Market = result.Fixture.Markets.FirstOrDefault(_ => _.Id == item.Id);

                    if (result.Market != null)
                    {
                        this.fixtureDBContext.Results.Add(result);
                        await this.fixtureDBContext.SaveChangesAsync();
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
