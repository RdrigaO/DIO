using System;

namespace DIO.Series
{
    public class Filme : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Disponivel { get; set; }
        private bool Excluido { get; set; }
        public Filme(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Disponivel = true;
            this.Excluido = false;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano;
            retorno += "Disponivel: " + this.Disponivel;
            return retorno;
        }
        public int RetornaId()
        {
            return this.Id;
        }
        public string RetornaTitulo()
        {
            return this.Titulo;
        }
        public bool VerificarDisponibilidade()
        {
            return this.Disponivel;
        }
        public void Alugar()
        {
            this.Disponivel = false;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
        public bool RetornaExcluido(){
            return this.Excluido;
        }
    }
}