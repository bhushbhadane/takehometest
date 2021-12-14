using System.Collections.Generic;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.DAL.Models;

namespace FixtureWeb.DAL.Converters.Model
{
    public static class CompetitorModelExtension
    {
        public static CompetitorDto ConvertToDto(this MetadataCompetitors metadataCompetitors)
        {
            return new CompetitorDto
            {
                Competitor_Id = metadataCompetitors.CompetitorId,
                Type = metadataCompetitors.Type,
                Name = metadataCompetitors.Name,
                Children = GetChildren(metadataCompetitors.MetadataCompetitorsChildren)
            };
        }

        public static IEnumerable<CompetitorDto> ConvertToDto(this IEnumerable<MetadataCompetitors> metadataCompetitors)
        {
            foreach (var item in metadataCompetitors)
            {
                yield return item.ConvertToDto();
            }
        }

        public static IList<CompetitorChildrenDto> GetChildren(ICollection<MetadataCompetitorsChildren> metadataCompetitors)
        {
            var returnList = new List<CompetitorChildrenDto>();

            foreach (var item in metadataCompetitors)
            {
                returnList.Add(
                    new CompetitorChildrenDto
                    {
                        Competitor_Id = item.CompetitorId,
                        Type = item.Type,
                        Name = item.Name
                    });
            }
            return returnList;
        }
    }
}
