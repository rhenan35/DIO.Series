using System;

namespace DIO.Series
{
  public class Serie : EntidadeBase{
    private Genero Genero {get; set;}

    private string Titulo {get; set;}

    private string Descricao {get; set;}

    private int Ano {get; set;}

    private bool excluido {get; set;}

    public Serie(int id, Genero genero, string titulo, string descricao, int ano){
      this.Id = id;
      this.Genero = genero;
      this.Titulo = titulo;
      this.Descricao = descricao;
      this.Ano = ano;
      this.excluido = false;
    }

    public override string ToString()
    {
      string retorno = "";
      retorno += "Genero: " + this.Genero + Environment.NewLine;
      retorno += "Titulo: " + this.Titulo + Environment.NewLine;
      retorno += "Descricao: " + this.Descricao + Environment.NewLine;
      retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
      return retorno;
    }

    public string RetornaTitulo(){
      return this.Titulo;
    }

    public int RetornaId(){
      return this.Id;
    }

    public bool RetornaExcluido(){
      return this.excluido;
    }

    public void Excluir(){
      this.excluido = true;
    }
  }
}