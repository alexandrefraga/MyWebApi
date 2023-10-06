using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataAtual")]
        public IActionResult ObterData()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString(),
            };

            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var msg = $"Olá {nome}";
            return Ok(new { msg });
        }

        // [HttpGet("Consultar?{nome}&{sobrenome}")]
        // public IActionResult Consultar(string nome, string sobrenome)
        // {
        //     return Ok(new { msg = $"Consulta realizada para: {nome} {sobrenome}" });
        // }
    }
}