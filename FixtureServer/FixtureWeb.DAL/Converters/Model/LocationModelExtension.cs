using System.Collections.Generic;
using System.Linq;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.DAL.Models;

namespace FixtureWeb.DAL.Converters.Model
{
    public static class LocationModelExtension
    {
        public static LocationDto ConvertToDto(this MetadataLocation metadataLocation)
        {
            return new LocationDto
            {
                Id = metadataLocation.Id,
                Type = metadataLocation.Type,
                Name = metadataLocation.Name
            };
        }

        public static LocationDto ConvertToDto(this IEnumerable<MetadataLocation> metadataLocation)
        {
            return metadataLocation.First().ConvertToDto();
        }
    }
}
