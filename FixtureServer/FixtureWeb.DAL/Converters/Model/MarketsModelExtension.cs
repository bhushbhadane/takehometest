using System.Collections.Generic;
using Fixture.WebPack.Types.DTO;
using FixtureWeb.DAL.Models;

namespace FixtureWeb.DAL.Converters.Model
{
    public static class MarketsModelExtension
    {
        public static MarketDto ConvertToDto(this Markets market)
        {
            return new MarketDto
            {
                Id = market.Id,
                Price = float.Parse(market.Price),
                Title = market.Title,
            };
        }

        public static IEnumerable<MarketDto> ConvertToDto(this IEnumerable<Markets> markets)
        {
            foreach (var item in markets)
            {
                yield return item.ConvertToDto();
            }
        }
    }
}
