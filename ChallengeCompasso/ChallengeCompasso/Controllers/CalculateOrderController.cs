using ChallengeCompasso.Models;
using ChallengeCompasso.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeCompasso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateOrderController : ControllerBase
    {
        [HttpGet]
        public CalculateOrderModel Get(string tamanhoPizza, string salgadaDoce, string borda, string bebida, string tipoEntrega)
        {
            var result = new CalculateOrder().Calculate(tamanhoPizza, salgadaDoce, borda, bebida, tipoEntrega);

            return result;
        }
    }
}
