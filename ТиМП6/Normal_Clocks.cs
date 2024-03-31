using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТиМП6
{
    public class Normal_Clocks
    {

        public virtual string Change_Normal_Time(double Angle_H, int Angle_M, bool AM_PM)
        {
            string AMPM;
            int Hour_ = (int)((Math.Floor((Angle_H/30) ))) % 12;
            if (AM_PM)
                AMPM = " Вторая половина дня";
            else
                AMPM = " Первая половина дня";
            int Minute_ = (int)(Angle_M /6) % 60;
            return "Время: " + Hour_.ToString() + ":" + Minute_.ToString("00") + AMPM + "\n";
        }
    }
}
