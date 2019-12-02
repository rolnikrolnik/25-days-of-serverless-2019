using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;

namespace ServerlessAdvent
{
    public static class Dreidel
    {
        [FunctionName("Dreidel")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req)
        {
           var dreidels = new [] { "נ (Nun)", "ג (Gimmel)", "ה (Hay)", "ש (Shin)" };
           var spin = new Random().Next(dreidels.Length);

            return new OkObjectResult(dreidels[spin]);
        }
    }
}
