using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clientes.Models
{
    public class Cliente
    {
        public Cliente(){}
        public Cliente(int Id, string RazaoSocial, string CpfCnpj, string Telefone, string Email)
        {
            this.Id = Id;
            this.CpfCnpj = CpfCnpj;
            this.RazaoSocial = RazaoSocial;
            this.Telefone = Telefone;
            this.Email = Email;
        }
        public Cliente(string RazaoSocial, string CpfCnpj, string Telefone, string Email)
        {
            this.CpfCnpj = CpfCnpj;
            this.RazaoSocial = RazaoSocial;
            this.Telefone = Telefone;
            this.Email = Email;
        }

        public int Id { get; set; }

        public string RazaoSocial { get; set; }

        public string CpfCnpj { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        
    }
}