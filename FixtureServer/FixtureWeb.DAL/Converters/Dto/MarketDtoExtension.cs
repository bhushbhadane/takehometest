using System.Collections.Generic;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.DAL.Models;

namespace FixtureWeb.DAL.Converters.Dto
{
    public static class MarketDtoExtension
    {
        public static Markets ConvertToDb(this MarketDto marketDto)
        {
            if (marketDto == null)
            {
                return null;
            }

            return new Markets
            {
                Id = marketDto.Id,
                Price = marketDto.Price.ToString(),
                Title = marketDto.Title,
            };
        }

        public static IEnumerable<Markets> ConvertToDb(this IEnumerable<MarketDto> marketDtos)
        {
            foreach (var item in marketDtos)
            {
                yield return item.ConvertToDb();
            }
        }
    }
}
