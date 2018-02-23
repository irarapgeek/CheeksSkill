using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlexaSkill.Controllers
{
    [Route("api/alexa")]
    public class AlexaController : Controller
    {
        [HttpPost]
        public dynamic Genie(dynamic request)
        {
            return new
            {
                version = "1.0",
                sessionAttribbutes = new {},
                response = new 
                {
                    outputSpeech = new 
                    {
                        type = "PlanText",
                        text = "Hello World"
                    },
                    card = new 
                    {
                        text = "Simple",
                        title = "Genie",
                        content = "Hello\nCruel World!"
                    },
                    shouldEndSession = true
                },
            };
        }
    }
}
