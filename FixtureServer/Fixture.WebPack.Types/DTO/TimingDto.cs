using System;

namespace Fixture.WebPack.Types.DTO
{
    public class TimingDto
    {
        public DateTimeOffset Scheduled_Begin { get; set; }

        public string Expected_Duration { get; set; }
    }
}
