using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OlaMundoApi.Controllers
{
    [ApiController]
    [ResourceConsumption("[controller]")]
    public class OlaMundoController : ControllerBase
    {
        public string Get()
        {
            return "Olá Mundo";
        }
    }
}