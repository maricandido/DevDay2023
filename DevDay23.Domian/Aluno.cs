using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay23.Domain
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string RA { get; set; }
        public int Idade { get; set; }
    }
}
