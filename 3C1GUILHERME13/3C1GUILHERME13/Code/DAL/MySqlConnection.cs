using System;

namespace _3C1GUILHERME13.Code.DAL
{
    internal class MySqlConnection
    {
        private string conn;

        public MySqlConnection(string conn)
        {
            this.conn = conn;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}