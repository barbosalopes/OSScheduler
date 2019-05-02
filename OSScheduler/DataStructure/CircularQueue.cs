using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSScheduler.DataStructure
{
    class CircularQueue
    {
        private QueueableProcess Current { set; get; }
        private QueueableProcess Aux { set; get; }

        public CircularQueue()
        {
            Aux = Current = null;
        }

        public void Insert(QueueableProcess toInsert)
        {
            if (Current == null)
            {
                Current = toInsert;
                Current.NextProcess = Current;
                return;
            }

            Aux = Current;
            while (toInsert.CompareTo(Aux) < 0 && toInsert.CompareTo(Aux.NextProcess) >= 0)
                Aux = Aux.NextProcess;
            toInsert.NextProcess = Aux.NextProcess;
            Aux.NextProcess = toInsert;
        }

        public QueueableProcess Remove()
        {
            if (Current == null)
                return null;

            Aux = Current;
            QueueableProcess toReturn;

            while (!Aux.NextProcess.Equals(Current))
                Aux = Aux.NextProcess;
            if (Aux.Equals(Current))
            {
                toReturn = Current;
                toReturn.NextProcess = null;
                Aux = Current = null;
            }
            else
            {
                Aux.NextProcess = Current.NextProcess;
                Current.NextProcess = null;
                toReturn = Current;
            }

            return toReturn;
        }
            
        public QueueableProcess Execute(int Quantum)
        {
            QueueableProcess toReturn = Current;
            Current.Execute(Quantum);
            Current = Current.NextProcess;
            return toReturn;
        }
    }
}
