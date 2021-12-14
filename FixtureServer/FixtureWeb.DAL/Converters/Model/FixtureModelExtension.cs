using System.Collections.Generic;
using System.Linq;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.DAL.Converters.Model;

namespace FixtureWeb.DAL.Converters.Model
{
    public static class FixtureModelExtension
    {
        public static FixtureDto ConvertToDto(this Models.Fixture fixture)
        {
            return new FixtureDto
            {
                Id = fixture.Id,
                Name = fixture.Name,
                Markets = fixture.Markets.ConvertToDto().ToList(),
                Metadata = fixture.Metadata.ConvertToDto()
            };
        }

        public static IEnumerable<FixtureDto> ConvertToDto(this IEnumerable<Models.Fixture> fixtures)
        {
            foreach (var item in fixtures)
            {
                yield return item.ConvertToDto();
            }
        }
    }
}
