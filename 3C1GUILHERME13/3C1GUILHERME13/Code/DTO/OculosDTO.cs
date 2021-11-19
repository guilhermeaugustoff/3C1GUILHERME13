using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1GUILHERME13.Code.DTO
{
    class OculosDTO
    {
        private int _id;
        private string _nome;
        private string _cor;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cor { get => _cor; set => _cor = value; }
    }
}
