using System.Collections.Generic;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.DAL.Models;

namespace FixtureWeb.DAL.Converters.Dto
{
    public static class CompetitorDtoExtension
    {
        public static MetadataCompetitors ConvertToDb(this CompetitorDto competitorDto)
        {
            return new MetadataCompetitors
            {
                CompetitorId = competitorDto.Competitor_Id,
                Type = competitorDto.Type,
                Name = competitorDto.Name,
                MetadataCompetitorsChildren = GetChildren(competitorDto.Children)
            };
        }

        public static IEnumerable<MetadataCompetitors> ConvertToDb(this IEnumerable<CompetitorDto> competitorDtos)
        {
            foreach (var item in competitorDtos)
            {
                yield return item.ConvertToDb();
            }
        }

        public static IList<MetadataCompetitorsChildren> GetChildren(IList<CompetitorChildrenDto> competitorDtos)
        {
            var returnList = new List<MetadataCompetitorsChildren>();

            foreach (var item in competitorDtos)
            {
                returnList.Add(
                    new MetadataCompetitorsChildren
                    {
                        CompetitorId = item.Competitor_Id,
                        Type = item.Type,
                        Name = item.Name
                    });
            }
            return returnList;
        }
    }
}
