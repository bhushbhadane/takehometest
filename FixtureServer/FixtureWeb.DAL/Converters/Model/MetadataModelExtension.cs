using System.Collections.Generic;
using System.Linq;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.DAL.Models;

namespace FixtureWeb.DAL.Converters.Model
{
    public static class MetadataModelExtension
    {
        public static MetadataDto ConvertToDto(this Metadata metadata)
        {
            return new MetadataDto()
            {
                Sport = metadata.MetadataSport.ConvertToDto(),
                Location = metadata.MetadataLocation.ConvertToDto(),
                Timing = metadata.MetadataTiming.ConvertToDto(),
                Competitors = metadata.MetadataCompetitors.ConvertToDto().ToList()
            };
        }

        public static MetadataDto ConvertToDto(this IEnumerable<Metadata> metadata)
        {
            return metadata.First().ConvertToDto();
        }
    }
}
