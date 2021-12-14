using System.Collections.Generic;
using System.Threading.Tasks;
using Fixture.WebPack.Types.DTO;

namespace FixtureWeb.Shared.Interfaces
{
    public interface IFixtureRepository
    {
        /// <summary>
        /// Get all fixture data.
        /// </summary>
        /// <returns>collection of fixture data</returns>
        Task<IEnumerable<FixtureDto>> GetAllAsync();

        /// <summary>
        /// Create a fixture.
        /// </summary>
        /// <param name="fixtureDto">fixture data</param>
        /// <returns>created fixture data</returns>
        Task<FixtureDto> CreateAsync(FixtureDto fixtureDto);

        /// <summary>
        /// Update a fixture data
        /// </summary>
        /// <param name="fixtureDto">fixture data</param>
        /// <returns></returns>
        Task UpdateAsync(FixtureDto fixtureDto);

        /// <summary>
        /// Update fixture result/winner details
        /// </summary>
        /// <param name="resultDto">fixture data</param>
        /// <returns></returns>
        Task UpdateResultAsync(ResultDto resultDto);
    }
}
