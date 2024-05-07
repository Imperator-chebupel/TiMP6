using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТиМП6
{
    public class Client_with_NClocks
    {
        public string Watch_Time(Normal_Clocks Clocks, int Angle_H, int Angle_M, bool AMPM)
        {
            return Clocks.Change_Normal_Time(Angle_H, Angle_M,AMPM);
        }
    }
}
