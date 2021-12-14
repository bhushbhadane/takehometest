using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Entity.Core;
using System.Data.Entity;
using System.Linq;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.Shared.Interfaces;
using FixtureWeb.DAL.Converters.Dto;

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

        public Task UpdateResultAsync(ResultDto resultDto)
        {
            throw new NotImplementedException();
        }
    }
}
