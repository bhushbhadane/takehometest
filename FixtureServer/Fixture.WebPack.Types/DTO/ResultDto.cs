using System.Collections.Generic;

namespace Fixture.WebPack.Types.DTO
{
    public class ResultDto
    {
        public int Id { get; set; }

        public IList<WinnerDto> Winners { get; set; }
    }
}
