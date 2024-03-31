using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТиМП6
{
    internal class Adapter_to_NClocks : Normal_Clocks
    {
        private Electronic_Clocks EC;

        public Adapter_to_NClocks(Electronic_Clocks EC_)
        {
            this.EC = EC_;
        }
        public override string Change_Normal_Time(double Angle_H, int Angle_M, bool AM_PM)
        {
            int Number_H = (int)((Math.Floor((Angle_H / 30)))) % 12;
            if (AM_PM)
                Number_H += 12;
            int Number_M = (int)(Angle_M / 6) % 60;
            return EC.Change_Electronic_Time(Number_H, Number_M);
        }
    }
}
