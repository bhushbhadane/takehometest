using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureWeb.DAL.Models
{
    public class MetadataCompetitors
    {
        public MetadataCompetitors()
        {
            MetadataCompetitorsChildren = new HashSet<MetadataCompetitorsChildren>();
        }

        public int MetadataCompetitorsID { get; set; }

        public int? MetadataID { get; set; }

        public int CompetitorId { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public virtual Metadata Metadata { get; set; }

        public virtual ICollection<MetadataCompetitorsChildren> MetadataCompetitorsChildren { get; set; }
    }
}
