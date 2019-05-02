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


        public void Insert(QueueableProcess toInsert)
        {
            Aux = Current;
            while (toInsert.CompareTo(Aux) < 0 && toInsert.CompareTo(Aux.NextProcess) >= 0)
                Aux = Aux.NextProcess;
            toInsert.NextProcess = Aux.NextProcess;
            Aux.NextProcess = toInsert;
        }
    }
}
