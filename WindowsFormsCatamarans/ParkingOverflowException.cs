using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCatamarans
{
    public class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() : base("В гавани нет свободных мест")
        { }
    }
}