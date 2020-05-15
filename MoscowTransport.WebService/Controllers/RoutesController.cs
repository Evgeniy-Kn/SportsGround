using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsGround.DomainObjects;

namespace SportsGround.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoutesController : ControllerBase
    {
        private readonly ILogger<RoutesController> _logger;

        public RoutesController(ILogger<RoutesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<NameFacility> GetRoute()
        {
            return new List<NameFacility>() 
            { 
                new NameFacility() 
                { 
                    Id = 1,
                    TypeofSportsGround = "748",
                    Name = "Ст. Ховрино - Ст. МЦД Бескудниково",
                    Type = TransportType.Bus,
                    Organization = new TransportOrganization()
                    {
                        Id = 1,
                        Name = "ГУП \"Мосгортранс\"",
                        TimeZone = "Europe/Moscow",
                        WebSite = "http://mosgortrans.ru"
                    }
                } 
            };
        }
    }
}
