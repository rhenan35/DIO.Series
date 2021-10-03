using System;
using System.Collections.Generic;
using DIO.Series.Interface;

namespace DIO.Series
{
  public class SerieRepositorio : IRepositorio<Serie>
  {
    private List<Serie> listaSerie = new List<Serie>();
    public void Atualiza(int id, Serie entidade)
    {
			listaSerie[id] = entidade;
    //   throw new NotImplementedException();
    }

    public void Exclui(int id)
    {
			listaSerie[id].Excluir();
    //   throw new NotImplementedException();
    }

    public void Insere(Serie entidade)
    {
			listaSerie.Add(entidade);
    //   throw new NotImplementedException();
    }

    public List<Serie> Lista()
    {
			return listaSerie;
    //   throw new NotImplementedException();
    }

    public int ProximoId()
    {
			return listaSerie.Count;
    //   throw new NotImplementedException();
    }

    public Serie RetornaPorId(int id)
    {
			return listaSerie[id];
    //   throw new NotImplementedException();
    }
  }
}