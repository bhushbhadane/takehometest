namespace FixtureWeb.DAL.Models
{
    public class MetadataCompetitorsChildren
    {
        public int MetadataCompetitorsChildrenID { get; set; }

        public int? MetadataCompetitorsID { get; set; }

        public int CompetitorId { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public virtual MetadataCompetitors MetadataCompetitors { get; set; }
    }
}
