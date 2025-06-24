using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_GestaoLivraria.Models;
using System.Runtime.CompilerServices;

namespace API_GestaoLivraria.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LivrariaController : ControllerBase
{
    private static List<Livraria> Livros = new List<Livraria>();
    private static int ProximoId = 1;


    [HttpPost]
    [ProducesResponseType(typeof(Livraria), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult CreateLivro([FromBody] Livraria novoLivro)
    {
        try
        {
            novoLivro.Id = ProximoId++;
            Livros.Add(novoLivro);
            return CreatedAtAction(nameof(GetById), new { id = novoLivro.Id }, novoLivro);
        }
        catch (Exception erro)
        {
            return BadRequest(erro.Message);
        }
    }

    [HttpGet]
    [ProducesResponseType(typeof(Livraria), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetAll()
    {
        try
        {          
            return Ok(Livros);
        }
        catch (Exception erro)
        {
            return BadRequest($"Erro ao obter livros: {erro.Message}");
        }
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Livraria), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute] int id)
    {
        try
        {
            var livroEscolhido = Livros.FirstOrDefault(livro => livro.Id == id);

            if (livroEscolhido == null)
            {
                return NotFound($"Livro com ID {id} não encontrado.");
            }

            return Ok(livroEscolhido);
        }
        catch (Exception erro)
        {
            return BadRequest($"Erro ao obter livros: {erro.Message}");
        }
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(string), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Update(int id, [FromBody] Livraria livroAtualizado)
    {
        try
        {
            var livroExistente = Livros.FirstOrDefault(livro => livro.Id == id);
            if (livroExistente == null)
            {
                return NotFound($"Livro com ID {id} não encontrado.");
            }

            livroExistente.Titulo = livroAtualizado.Titulo;
            livroExistente.Autor = livroAtualizado.Autor;
            livroExistente.Genero = livroAtualizado.Genero;
            livroExistente.Preco = livroAtualizado.Preco;
            livroExistente.QuantidadeEstoque = livroAtualizado.QuantidadeEstoque;

            return NoContent();
        }
        catch (Exception erro)
        {
            return BadRequest($"Erro ao obter livros: {erro.Message}");
        }
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(string), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        try
        {
            var livro = Livros.FirstOrDefault(l => l.Id == id);

            if (livro == null)
            {
                return NotFound($"Livro com ID {id} não encontrado.");
            }

            Livros.Remove(livro);

            return NoContent();
        }
        catch (Exception erro)
        {
            return BadRequest($"Erro ao obter livros: {erro.Message}");
        }
    }
}
