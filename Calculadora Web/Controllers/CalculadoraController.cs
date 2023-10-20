using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora_Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet]
        public ActionResult Test(){
            return Ok("Teste realizado com sucesso. OK !");
        }

        [HttpGet("Somar")]
        public ActionResult<Calculadora> Somar (double valor1, double valor2){
        var calc = new Calculadora(valor1, valor2);
        calc.somar();
        return Ok(calc);
        }

        [HttpGet("Subtrair")]
        public ActionResult<Calculadora> Subtrair (double valor1, double valor2){
        var calc = new Calculadora(valor1, valor2);
        calc.subtrair();
        return Ok(calc);

        }

        [HttpGet("Multiplicar")]
        public ActionResult<Calculadora> Multiplicar (double valor1, double valor2){
        var calc = new Calculadora(valor1, valor2);
        calc.multiplicar();
        return Ok(calc);

        }
    }
}