﻿namespace Atividade1.Models
{
    public class Convidado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string EMail { get; set; }
        public string Telefone { get; set; }
        public bool comparecimento { get; set; }
        public string comparecimentoString { get => comparecimento ? "Sim" : "Não"; }
    }
}
