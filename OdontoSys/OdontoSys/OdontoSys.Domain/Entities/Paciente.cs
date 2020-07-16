using System;
using System.Collections.Generic;
using System.Text;

namespace OdontoSys.Domain.Entities
{
    public class Paciente : Base
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }
    }
}
