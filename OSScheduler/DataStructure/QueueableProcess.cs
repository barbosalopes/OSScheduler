using OSScheduler.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSScheduler.DataStructure
{
    class QueueableProcess : Process
    {
        public QueueableProcess(int ExecutionTime, int Priority) : 
            base(ExecutionTime, Priority) { }

        public QueueableProcess NextProcess { set; get; }
    }
}
