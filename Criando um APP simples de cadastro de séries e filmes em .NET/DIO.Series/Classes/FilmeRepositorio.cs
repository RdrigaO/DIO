using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        public List<Filme> listaFilmes = new List<Filme>();
        public void Atualiza(int id, Filme objeto)
        {
            listaFilmes[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaFilmes[id].Excluir();
        }
        public void Alugar(int id){
            listaFilmes[id].Alugar();
        }

        public void Insere(Filme objeto)
        {
            listaFilmes.Add(objeto);
        }

        public List<Filme> Lista()
        {
            return listaFilmes;
        }

        public int ProximoId()
        {
            return listaFilmes.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return listaFilmes[id];
        }
    }
}