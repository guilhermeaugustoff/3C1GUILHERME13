using System;

namespace _3C1GUILHERME13.Code.DAL
{
    internal class MySqlCommand
    {
        private string sql;
        private MySqlConnection conexao;

        public MySqlCommand(string sql, MySqlConnection conexao)
        {
            this.sql = sql;
            this.conexao = conexao;
        }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}