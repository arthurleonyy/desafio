using Clientes.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using Dapper;

namespace Clientes.Dao
{
    public class ClienteDao : IDisposable
    {
        //public string connectionString = ConfigurationManager.ConnectionStrings["conexao"].ToString();
        private string connectionString = @"Database=clientes; Data Source=localhost;User Id=root;Password=";

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> FindAll()
        {
            using (IDbConnection conn = new MySqlConnection(connectionString))
            {
                var query = "SELECT * FROM cliente";

                return conn.Query<Cliente>(query).AsEnumerable();
            }
        }

        public Cliente Find(int id)
        {
            using (IDbConnection conn = new MySqlConnection(connectionString))
            {
                var query = "SELECT * FROM cliente WHERE Id = @Id";

                return conn.Query<Cliente>(query, new { Id = id }).FirstOrDefault();
            }
        }

        public void Insert(Cliente model)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var query = "INSERT INTO cliente(RazaoSocial, CpfCnpj, Telefone, Email) " +
                                   "VALUES (@RazaoSocial, @CpfCnpj, @Telefone, @Email)";
                connection.Execute(query , model);
            }
        }

        public void Update(Cliente model)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var query = "UPDATE cliente SET" +
                            "RazaoSocial = @RazaoSocial" +
                            "CpfCnpj = @CpfCnpj" +
                            "Telefone = @Telefone" +
                            "Email = @Email" +
                            "WHERE Id = @Id";

                connection.Execute(query, model);
            }
        }
    }
}