using Microsoft.AspNetCore.Mvc;
using help_desk.Data;
using help_desk.Models;

namespace help_desk.Controllers;

[ApiController]
[Route("[controller]")] // Isso faz a rota se chamar "/chamados" automaticamente baseada no nome da classe
public class ChamadosController : ControllerBase
{
    private readonly AppDbContext _context;

    public ChamadosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult CriarChamado(Chamado novoChamado)
    {
        _context.Chamados.Add(novoChamado);

        _context.SaveChanges();

        return Ok("Chamado criado com sucesso!");
    }

    [HttpGet]
    public IActionResult GetChamados()
    {
        List<Chamado> Chamados = _context.Chamados.ToList();
        return Ok(Chamados);
    }

    [HttpGet("{id}")]
    public IActionResult GetChamadoById(int id)
    {
        var chamado = _context.Chamados.Find(id);

        if (chamado == null)
        {
            return NotFound();
        }

        return Ok(chamado);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateChamado(int id, Chamado chamadoNovo)
    {
        var chamado = _context.Chamados.Find(id);

        if (chamado == null)
        {
            return NotFound();
        }

        chamado.Titulo = chamadoNovo.Titulo;
        chamado.Descricao = chamadoNovo.Descricao;
        chamado.Status = chamadoNovo.Status;

        if (chamado.Status == Chamado.StatusChamado.Resolvido)
        {
            chamado.DataResolucao = DateTime.Now;
        }

        _context.SaveChanges();

        return Ok(chamado);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteChamado(int id)
    {
        var chamado = _context.Chamados.Find(id);

        if (chamado == null)
        {
            return NotFound();
        }

        _context.Chamados.Remove(chamado);
        _context.SaveChanges();

        return NoContent();
    }
}
