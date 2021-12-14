using Fixture.WebPack.Types.DTO;
using FixtureWeb.DAL.Models;

namespace FixtureWeb.DAL.Converters.Dto
{
    public static class LocationDtoExtension
    {
        public static MetadataLocation ConvertToDb(this LocationDto locationDto)
        {
            return new MetadataLocation
            {
                Id = locationDto.Id,
                Type = locationDto.Type,
                Name = locationDto.Name
            };
        }
    }
}

