using Fixture.WebPack.Types.DTO;
using FixtureWeb.DAL.Models;
namespace FixtureWeb.DAL.Converters.Dto
{
    public static class SportDtoExtension
    {
        public static MetadataSport ConvertToDb(this SportDto sportDto)
        {
            return new MetadataSport
            {
                Id = sportDto.Id,
                Name = sportDto.Name
            };
        }
    }
}
