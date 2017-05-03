using Microsoft.AspNetCore.Mvc;

namespace Bibliotheca.Server.Depository.FileSystem.Api.Controllers
{
    /// <summary>
    /// Health controller.
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/health")]
    public class HealthController : Controller
    {
        /// <summary>
        /// Get information about health.
        /// </summary>
        /// <remarks>
        /// Endpoint returns simple message when service is alive and reachable. It's used by service discovery to 
        /// preapare information about service health.
        /// </remarks>
        /// <returns>Information abouth health.</returns>
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(string))]
        public string Get()
        {
            return "I'm alive and reachable";
        }
    }
}