﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        [HttpGet]
        public decimal Sumar(decimal a, decimal b)
        {
            return a + b;
        }
     

        [HttpPost]
        public decimal Add(Numbers c, 
            [FromHeader(Name = "x-MyHeadersPograma2")]string Host)
        {
            Console.WriteLine(Host);
            return c.A - c.B;
        }

        [HttpPut]

        public decimal Multiplicar(decimal a, decimal b)
        {
            return a * b;
        }

        [HttpDelete]

        public decimal Nmas1(decimal a, decimal b)
        {
            return a * (a * b);
        }
    }
}
