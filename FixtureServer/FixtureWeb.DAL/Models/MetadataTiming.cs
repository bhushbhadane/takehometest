using System;

namespace FixtureWeb.DAL.Models
{
    public class MetadataTiming
    {
        public int MetadataTimingID { get; set; }

        public int? MetadataID { get; set; }

        public DateTimeOffset ScheduledBegin { get; set; }

        public string ExpectedDuration { get; set; }

        public virtual Metadata Metadata { get; set; }
    }
}
