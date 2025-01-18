using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace My.Function
{
    public  class HttpExampleTrigger
    {
        private readonly ILogger<HttpExampleTrigger> log;

        public HttpExampleTrigger(ILogger<HttpExampleTrigger> logs)
        {
            log = logs;
        }

        [FunctionName("HttpExampleTrigger")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req
          )
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            return  await Task.FromResult(new OkObjectResult("Welcome to Azure Functions!!"));
        }
    }
}
