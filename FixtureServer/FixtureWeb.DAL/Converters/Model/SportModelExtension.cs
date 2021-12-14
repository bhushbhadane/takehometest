using System.Collections.Generic;
using System.Linq;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.DAL.Models;

namespace FixtureWeb.DAL.Converters.Model
{
    public static class SportModelExtension
    {
        public static SportDto ConvertToDto(this MetadataSport metadataSport)
        {
            return new SportDto
            {
                Id = metadataSport.Id,
                Name = metadataSport.Name
            };
        }

        public static SportDto ConvertToDto(this IEnumerable<MetadataSport> metadataSports)
        {
            return metadataSports.First().ConvertToDto();
        }
    }
}
