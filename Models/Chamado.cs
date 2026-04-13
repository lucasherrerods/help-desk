using System.ComponentModel.DataAnnotations;

namespace help_desk.Models;

public class Chamado
{
  [Key]
  public int Id { get; set; }
  public string Titulo { get; set; } = string.Empty;
  public string Descricao { get; set; } = string.Empty;
  public StatusChamado Status { get; set; } = StatusChamado.Aberto;
  public DateTime DataAbertura { get; set; } = DateTime.Now;
  public DateTime? DataResolucao { get; set; }

  public Chamado() { }

  public Chamado(string titulo, string descricao)
  {
    Titulo = titulo;
    Descricao = descricao;
    Status = StatusChamado.Aberto;
    DataAbertura = DateTime.Now;
  }

  public enum StatusChamado
  {
    Aberto = 0,
    EmAtendimento = 1,
    Resolvido = 2
  }
}