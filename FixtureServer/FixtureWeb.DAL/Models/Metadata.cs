using System.Collections.Generic;

namespace FixtureWeb.DAL.Models
{
    public class Metadata
    {
        public Metadata()
        {
            MetadataCompetitors = new HashSet<MetadataCompetitors>();
            MetadataLocation = new HashSet<MetadataLocation>();
            MetadataSport = new HashSet<MetadataSport>();
            MetadataTiming = new HashSet<MetadataTiming>();
        }

        public int MetadataID { get; set; }

        public virtual Fixture Fixture { get; set; }

        public virtual ICollection<MetadataCompetitors> MetadataCompetitors { get; set; }

        public virtual ICollection<MetadataLocation> MetadataLocation { get; set; }

        public virtual ICollection<MetadataSport> MetadataSport { get; set; }

        public virtual ICollection<MetadataTiming> MetadataTiming { get; set; }
    }
}
