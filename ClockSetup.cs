using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockSetupLib
{
    public class ClockSetup : IClockSetup
    {

        public YearState YearState { get; set; }
        public MonthState MonthState { get; set; }
        public DayState DayState { get; set; }

        public void PushKnob()
        {
            throw new NotImplementedException();
        }

        public void RotateRight()
        {
            throw new NotImplementedException();
        }

        public void RotateLeft()
        {
            throw new NotImplementedException();
        }

        public object GetSelectedDate()
        {
            throw new NotImplementedException();
        }
    }
}
