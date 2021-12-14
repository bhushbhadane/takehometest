using System.Collections.Generic;
using System.Linq;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.DAL.Models;

namespace FixtureWeb.DAL.Converters.Dto
{
    public static class MetadataDtoExtension
    {
        public static Metadata ConvertToDb(this MetadataDto metadataDto)
        {
            if (metadataDto == null)
            {
                return null;
            }

            return new Metadata()
            {
                MetadataSport = new List<MetadataSport>() { metadataDto.Sport.ConvertToDb() },
                MetadataLocation = new List<MetadataLocation>() { metadataDto.Location.ConvertToDb() },
                MetadataTiming = new List<MetadataTiming>() { metadataDto.Timing.ConvertToDb() },
                MetadataCompetitors = metadataDto.Competitors.ConvertToDb().ToList()
            };
        }

        public static IEnumerable<Metadata> ConvertToDb(this IEnumerable<MetadataDto> metadataDtos)
        {
            foreach (var item in metadataDtos)
            {
                yield return item.ConvertToDb();
            }
        }
    }
}
