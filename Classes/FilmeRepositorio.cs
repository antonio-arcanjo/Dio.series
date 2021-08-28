using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;
using DIO.Series.Interfaces2;

namespace DIO.Series
{
	public class FilmeRepositorio : IRepositorio2<Filme>
	{
		private List<Filme> listaFilme = new List<Filme>();
		public void Atualiza2(int id, Filme objeto2)
		{
			listaFilme[id] = objeto2;
		}

		public void Exclui2(int id)
		{
			listaFilme[id].Excluir();
		}

		public void Insere2(Filme objeto2)
		{
			listaFilme.Add(objeto2);
		}

		public List<Filme> Lista2()
		{
			return listaFilme;
		}

		public int ProximoId2()
		{
			return listaFilme.Count;
		}

		public Filme RetornaPorId2(int id)
		{
			return listaFilme[id];
		}



	}
	

}