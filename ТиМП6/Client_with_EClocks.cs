using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТиМП6
{
    public class Client_with_EClocks
    {
        public string Watch_Time(Electronic_Clocks Clocks, int Number_H, int Number_M)
        {
            return Clocks.Change_Electronic_Time(Number_H, Number_M);
        }
    }
}
