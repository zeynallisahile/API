using API_project1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private List<Actor> _actors;
        public ActorController()
        {

            _actors = new List<Actor>
            {
                new Actor
                {
                    Id = 1,
                    FullName ="Tom Hardy",
                    Image =""
                },

                new Actor
                {
                    Id = 2,
                    FullName = "Jason Statham",
                    Image = ""
                },

                new Actor
                {
                    Id = 3,
                    FullName = "Sylvester Stallone",
                    Image = ""
                }

            };

        }
            public IActionResult All()
            {
                return Ok(_actors);
            }
       
    }
}
