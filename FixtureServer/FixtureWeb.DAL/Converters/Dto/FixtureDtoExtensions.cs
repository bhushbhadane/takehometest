using System.Collections.Generic;
using System.Linq;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.DAL.Models;

namespace FixtureWeb.DAL.Converters.Dto
{
    public static class FixtureDtoExtensions
    {
        public static Models.Fixture ConvertToDb(this FixtureDto fixtureDto)
        {
            return new Models.Fixture
            {
                Id = fixtureDto.Id,
                Name = fixtureDto.Name,
                Markets = fixtureDto.Markets.ConvertToDb().ToList(),
                Metadata = new List<Metadata>() { fixtureDto.Metadata.ConvertToDb() }
            };
        }
    }
}
