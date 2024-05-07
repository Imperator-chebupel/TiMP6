using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТиМП6
{
    public class Normal_Clocks
    {
        private int Hour;
        private int Minute;

        public Normal_Clocks()
        {
            Hour= 0;
            Minute= 0;
        }

        public virtual string Change_Normal_Time(double Angle_H, int Angle_M, bool AM_PM)
        {
            string AMPM = "";
            this.Minute += (int)(Angle_M / 6) % 60;
            this.Hour += Minute / 60;
            this.Minute = Minute % 60;

            this.Hour += (int)((Math.Floor((Angle_H/30) ))) % 12;
            if (Hour >= 12)
            {
                AM_PM = true;
            }
            if (Hour >= 24)
            {
                this.Hour -= 24;
                AM_PM= false;
            }
            if (AM_PM)
                AMPM = " Вторая половина дня";
            else
                AMPM = " Первая половина дня";

            return "Время: " + (Hour%12).ToString() + ":" + Minute.ToString("00") + AMPM + "\n" + "Поворот часовой стрелки на " + Angle_H + " градусов, минутной на " + Angle_M + "\n";
        }
    }
}