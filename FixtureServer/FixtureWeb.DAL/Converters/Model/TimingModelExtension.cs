using System.Collections.Generic;
using System.Linq;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.DAL.Models;

namespace FixtureWeb.DAL.Converters.Model
{
    public static class TimingModelExtension
    {
        public static TimingDto ConvertToDto(this MetadataTiming metadataTiming)
        {
            return new TimingDto
            {
                Scheduled_Begin = metadataTiming.ScheduledBegin.ToUniversalTime(),
                Expected_Duration = metadataTiming.ExpectedDuration
            };
        }

        public static TimingDto ConvertToDto(this IEnumerable<MetadataTiming> metadataTiming)
        {
            return metadataTiming.First().ConvertToDto();
        }
    }
}
