using Clientes.Dao;
using Clientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Clientes.Controllers
{
    public class ClienteController : ApiController
    {
        ClienteDao clienteDao = new ClienteDao();

        public IEnumerable<Cliente> Get()
        {
            return clienteDao.FindAll();
        }

        [HttpGet]
        public Cliente GetCliente(int id)
        {
            return clienteDao.Find(id);
        }

        public void Post(string RazaoSocial, string CpfCnpj, string Telefone, string Email)
        {
            if (ModelState.IsValid)
            {
                clienteDao.Insert(new Cliente(RazaoSocial, CpfCnpj, Telefone, Email));
            }
        }

        public void Put(int id, string RazaoSocial, string CpfCnpj, string Telefone, string Email)
        {
            if (ModelState.IsValid)
            {
                clienteDao.Update(new Cliente( id, RazaoSocial, CpfCnpj, Telefone, Email));
            }
        }
    }
}
