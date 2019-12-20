using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCatamarans
{
    public class ParkingAlreadyHaveException : Exception
    {

        public ParkingAlreadyHaveException() : base("В гавани уже есть такая лодка :(") { }
    }
}