using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using App1.Models;

namespace App1.Data
{
    public class Banco
    {
        readonly SQLiteAsyncConnection conexao;
        public Banco(string arquivo)
        {
            conexao = new SQLiteAsyncConnection(arquivo);
            conexao.CreateTableAsync<Computador>().Wait();
        }
    }
}
