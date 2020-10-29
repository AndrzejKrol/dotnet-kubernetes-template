using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace DotNetKubernetesTemplate.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnvironmentVariablesController : ControllerBase
    {
        [HttpGet]
        public IDictionary Get() => Environment.GetEnvironmentVariables();
    }
}
