using Fixture.WebPack.Types.DTO;
using FixtureWeb.DAL.Models;

namespace FixtureWeb.DAL.Converters.Dto
{
    public static class TimingDtoExtension
    {
        public static MetadataTiming ConvertToDb(this TimingDto timingDto)
        {
            return new MetadataTiming
            {
                ScheduledBegin = timingDto.Scheduled_Begin,
                ExpectedDuration = timingDto.Expected_Duration
            };
        }
    }
}
