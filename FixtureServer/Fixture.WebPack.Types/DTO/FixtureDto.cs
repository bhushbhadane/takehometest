using System.Collections.Generic;

namespace Fixture.WebPack.Types.DTO
{
    public class FixtureDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<MarketDto> Markets { get; set; }

        public MetadataDto Metadata { get; set; }
    }
}
