using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoA3Gestao.Model
{
    public class Usuario
        {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string NumeroEndereco { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string NumeroTelefone { get; set; }
        public string Cpf { get; set; }
        public bool ValidarTelefone()
            {
                // Exemplo simples de validação de telefone (Brasil)
                var regex = new Regex(@"^\(?\d{2}\)?[\s-]?\d{4,5}-?\d{4}$");
                return regex.IsMatch(NumeroTelefone);
            }

            public bool ValidarCpf()
            {
                // Exemplo de validação de CPF
                var regex = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
                return regex.IsMatch(Cpf);
            }

            public bool ValidarEmail()
            {
                // Exemplo de validação de e-mail
                var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                return regex.IsMatch(Email);
            }

            public bool ValidarCep()
            {
                // Exemplo de validação de CEP (Brasil)
                var regex = new Regex(@"^\d{5}-\d{3}$");
                return regex.IsMatch(Cep);
            }
        }
    }
