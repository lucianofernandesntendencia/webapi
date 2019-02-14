using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class FuncionarioController : ApiController
    {
        // Lista de funcionários criada para testes com a API
        public Funcionario[] funcionarios = new Funcionario[]
        {
            new Funcionario { Id = 1, Nome = "Marcelo Dornelas", Cargo = "Power Ranger Green" },
            new Funcionario { Id = 2, Nome = "Luciano Fernandes", Cargo = "Power Ranger Red" },
            new Funcionario { Id = 3, Nome = "Vinícius Gonzalez", Cargo = "Power Ranger Blue" },
            new Funcionario { Id = 4, Nome = "Lucas Gomes", Cargo = "Power Ranger Yellow" },
            new Funcionario { Id = 5, Nome = "Lucas Botaro", Cargo = "Power Ranger Pink" },
            new Funcionario { Id = 6, Nome = "Igor Abdallah", Cargo = "Power Ranger Black" }
        };

        // GET: api/Funcionario
        public IEnumerable<Funcionario> Get()
        {
            return funcionarios;
        }

        // GET: api/Funcionario/5
        public IHttpActionResult Get(int id)
        {
            var funcionario = funcionarios.FirstOrDefault(item => item.Id == id);

            if (funcionario == null)
            {
                return NotFound();
            }

            return Ok(funcionario);
        }

    }
}