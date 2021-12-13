namespace FixtureWeb.DAL.Models
{
    public class MetadataLocation
    {
        public int? MetadataID { get; set; }

        public int Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public virtual Metadata Metadata { get; set; }
    }
}
