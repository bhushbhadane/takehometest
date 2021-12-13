using System.Collections.Generic;
using System.Threading.Tasks;
using Fixture.WebPack.Types.DTO;

namespace FixtureWeb.Shared.Interfaces
{
    public interface IFixtureRepository
    {
        Task<IEnumerable<FixtureDto>> GetAllAsync();

        Task<FixtureDto> CreateAsync(FixtureDto fixtureDto);

        Task UpdateAsync(FixtureDto fixtureDto);

        Task UpdateResultAsync(ResultDto resultDto);
    }
}
