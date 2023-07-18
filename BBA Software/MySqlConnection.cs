using System;
using System.Data;

namespace BBA_Software
{
    internal class MySqlConnection
    {
        private string v;

        public MySqlConnection(string v)
        {
            this.v = v;
        }

        public ConnectionState State { get; internal set; }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}