using System.Collections.Generic;

namespace Fixture.WebPack.Types.DTO
{
    public class MetadataDto
    {
        public SportDto Sport { get; set; }

        public LocationDto Location { get; set; }

        public TimingDto Timing { get; set; }

        public IList<CompetitorDto> Competitors { get; set; }
    }
}
