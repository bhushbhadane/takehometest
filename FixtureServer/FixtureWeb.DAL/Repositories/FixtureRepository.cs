using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Entity.Core;
using System.Data.Entity;
using System.Linq;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.Shared.Interfaces;
using FixtureWeb.DAL.Converters.Dto;
using FixtureWeb.DAL.Models;

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
            catch (EntityException)
            {
                throw;
            }
        }

        public Task<IEnumerable<FixtureDto>> GetAllAsync()
        {
            throw new NotImplementedException();
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
                        market.Title = item.Title;
                        market.Price = item.Price.ToString();
                        await this.fixtureDBContext.SaveChangesAsync();
                    }
                }
            }
            catch (EntityException)
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
                    this.fixtureDBContext.Results.Add(result);
                    await this.fixtureDBContext.SaveChangesAsync();
                }
            }
            catch (EntityException)
            {
                throw;
            }
        }
    }
}
