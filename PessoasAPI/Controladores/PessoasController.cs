using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using PessoasAPI.Modelos;
using PessoasAPI.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PessoasAPI.Controladores
{
       [Microsoft.AspNetCore.Components.Route("api/pessoas")]
       [ApiController]
       public class PessoasController : ControllerBase
       {
            private readonly PessoasService _pessoasService;

            public PessoasController(PessoasService pessoaService)
            {
                _pessoasService = pessoaService;
            }

            [HttpGet]
            public ActionResult<List<Pessoa>> Get() =>
                _pessoasService.Get();

            [HttpGet("{id:length(24)}", Name = "GetBook")]
            public ActionResult<Pessoa> Get(string id)
            {
                var pessoa = _pessoasService.Get(id);

                if (pessoa == null)
                {
                    return NotFound();
                }

                return pessoa;
            }

            [HttpPost]
            public ActionResult<Pessoa> Create(Pessoa pessoa)
            {
                 _pessoasService.Create(pessoa);

                return CreatedAtRoute("GetPessoa", new { id = pessoa.id.ToString() }, pessoa);
            }

            [HttpPut("{id:length(24)}")]
            public IActionResult Update(string id, Pessoa _pessoa)
            {
                var pessoa = _pessoasService.Get(id);

                if (pessoa == null)
                {
                    return NotFound();
                }

                 _pessoasService.Update(id, _pessoa);

                return NoContent();
            }

            [HttpDelete("{id:length(24)}")]
            public IActionResult Delete(string id)
            {
                var pessoa = _pessoasService.Get(id);

                if (pessoa == null)
                {
                    return NotFound();
                }

                _pessoasService.Remove(id);

                return NoContent();
            }
       }
}


