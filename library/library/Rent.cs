using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class Rent
    {
        public int IdRent { get; set; }
        public int IdCopy { get; set;}

        public Rent(int idRent, int idCopy)
        {
            IdRent = idRent;
            IdCopy = idCopy;
        }
    }
}
