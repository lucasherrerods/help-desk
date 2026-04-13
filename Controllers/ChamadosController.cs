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
}
