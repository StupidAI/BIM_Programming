using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15_1
{
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        public ArithProgression (int startValue, int delta)
        {
            setStart(startValue);
            Delta = delta;
            CurrentValue = startValue;
        }
        public int StartValue { get; set; }
        public int CurrentValue { get; set; }
        public int Delta { get; set; }
        public int getNext()
        {
            return CurrentValue += Delta;
        }

        public void reset()
        {
            CurrentValue = StartValue;
        }

        public void setStart(int x)
        {
            StartValue = x;
        }
    }
    class GeomProgression : ISeries
    {
        public GeomProgression(int startValue, int delta)
        {
            setStart(startValue);
            Delta = delta;
            CurrentValue = startValue;
        }
        public int StartValue { get; set; }
        public int CurrentValue { get; set; }
        public int Delta { get; set; }
        public int getNext()
        {
            return CurrentValue *= Delta;
        }

        public void reset()
        {
            CurrentValue = StartValue;
        }

        public void setStart(int x)
        {
            StartValue = x;
        }
    }
}
