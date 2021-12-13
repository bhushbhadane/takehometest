using System.Collections.Generic;

namespace Fixture.WebPack.Types.DTO
{
    public class CompetitorDto
    {
        public int Competitor_Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public IList<CompetitorChildrenDto> Children { get; set; }
    }
}
