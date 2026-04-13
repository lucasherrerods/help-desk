namespace help_desk.Models;

public class Chamado
{
  public int Id { get; set; }
  public string Titulo { get; set; }
  public string Descricao { get; set; }
  public int Status { get; set; }
  public DateTime DataAbertura { get; set; }
  public DateTime DataResolucao { get; set; }
}