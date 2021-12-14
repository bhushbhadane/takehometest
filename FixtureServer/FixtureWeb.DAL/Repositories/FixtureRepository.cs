using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.Shared.Interfaces;

namespace FixtureWeb.DAL.Repositories
{
    public class FixtureRepository : IFixtureRepository
    {
        public Task<FixtureDto> CreateAsync(FixtureDto fixtureDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FixtureDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(FixtureDto fixtureDto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateResultAsync(ResultDto resultDto)
        {
            throw new NotImplementedException();
        }
    }
}
