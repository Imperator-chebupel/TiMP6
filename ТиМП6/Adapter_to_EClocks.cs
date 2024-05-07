using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТиМП6
{
    public class Adapter_to_EClocks : Electronic_Clocks
    {
        private Normal_Clocks NC;

        public Adapter_to_EClocks(Normal_Clocks NC_) 
        {
            this.NC = NC_;
        }

        public override string Change_Electronic_Time(int H_number, int M_number)
        {
            bool AM_PM = false;
            if (H_number>12)
                AM_PM = true;
            int Angle_M = (M_number % 60) * 6;
            int Angle_H = (H_number % 12) * 30; //+ (Angle_M/360);
            return NC.Change_Normal_Time(Angle_H, Angle_M, AM_PM);
        }
    }
}
