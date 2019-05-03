using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSScheduler.DataStructure
{
    class CircularQueue
    {
        private QueueableProcess current { set; get; }
        public QueueableProcess Current { get { return current; } }
        private QueueableProcess Aux { set; get; }
        private int Quantum { set; get; }

        public CircularQueue(int Quantum)
        {
            Aux = current = null;
            this.Quantum = Quantum;
        }

        public void Insert(QueueableProcess toInsert)
        {
            if (current == null)
            {
                current = toInsert;
                current.NextProcess = current;
                return;
            }

            Aux = current;
            while (toInsert.CompareTo(Aux) < 0 && toInsert.CompareTo(Aux.NextProcess) >= 0)
                Aux = Aux.NextProcess;
            toInsert.NextProcess = Aux.NextProcess;
            Aux.NextProcess = toInsert;
        }

        public QueueableProcess Remove()
        {
            if (current == null)
                return null;

            Aux = current;
            QueueableProcess toReturn;

            while (!Aux.NextProcess.Equals(current))
                Aux = Aux.NextProcess;
            if (Aux.Equals(current))
            {
                toReturn = current;
                toReturn.NextProcess = null;
                Aux = current = null;
            }
            else
            {
                Aux.NextProcess = current.NextProcess;
                current.NextProcess = null;
                toReturn = current;
            }

            return toReturn;
        }
            
        protected QueueableProcess ExecuteCurrentProcess()
        {
            QueueableProcess toReturn = current;
            if(current != null) current.Execute(Quantum);
            return toReturn;
        }

        protected void StepOver()
        {
            current = current.NextProcess;
        }

        public bool IsEmpty()
        {
            return current == null;
        }

        public void Execute()
        {
            if (IsEmpty()) return;

            QueueableProcess Executed = ExecuteCurrentProcess();
            if (Executed.Finished()) Remove();
            if(!IsEmpty()) StepOver();
        }
        
        public QueueableProcess[] ToArray()
        {
            Aux = Current;
            List<QueueableProcess> toReturn = new List<QueueableProcess>();

            while(Aux != null)
            {
                toReturn.Add(Aux);
                Aux = Aux.NextProcess;
            }

            return toReturn.ToArray();
        }
    }
}
