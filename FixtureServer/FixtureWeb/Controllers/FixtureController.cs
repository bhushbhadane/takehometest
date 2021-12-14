using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FixtureWeb.Shared.Interfaces;
using Fixture.WebPack.Types.DTO;

namespace FixtureWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FixtureController : ControllerBase
    {
        private readonly IFixtureRepository fixtureRepository;

        public FixtureController(IFixtureRepository fixtureRepository)
        {
            this.fixtureRepository = fixtureRepository;
        }

        [Route("api/[controller]/GetAllFixture")]
        [HttpGet]
        public async Task<IActionResult> GetAllFixtures()
        {
            try
            {
                return this.Ok(await this.fixtureRepository.GetAllAsync());
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [Route("api/[controller]/CreateFixture")]
        [ActionName("CreateFixture")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] FixtureDto fixtureDto)
        {
            try
            {
                var newFixtureDto = await this.fixtureRepository.CreateAsync(fixtureDto);
                return CreatedAtAction("CreateFixture", new { id = newFixtureDto.Id }, newFixtureDto);
            }
            catch(Exception ex)
            {
                return StatusCode(500);
            }
        }

        [Route("api/[controller]/UpdateResult")]
        [HttpPost]
        public async Task<IActionResult> UpdateResult([FromBody] ResultDto resultDto)
        {
            if (resultDto != null && resultDto.Id > 0)
            {
                try
                {
                    await this.fixtureRepository.UpdateResultAsync(resultDto);
                    return this.Ok();
                }
                catch
                {
                    return StatusCode(500);
                }
            }
            else return this.BadRequest();
        }

        [Route("api/[controller]/UpdateFixture")]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] FixtureDto fixtureDto)
        {
            if (fixtureDto != null && fixtureDto.Id > 0)
            {
                try
                {
                    await this.fixtureRepository.UpdateAsync(fixtureDto);
                    return this.Ok();
                }
                catch
                {
                    return this.StatusCode(500);
                }
            }
            else return this.BadRequest();
        }
    }
}
