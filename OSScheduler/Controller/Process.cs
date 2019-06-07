using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OSScheduler.Controller
{
    class Process : Processable, IComparable
    {
        public Process(int ExecutionTime, int Priority)
        {
            this.ExecutionTime = ExecutionTime;
            this.Priority = Priority;
        }

        private int Priority;
        private int ExecutionTime;

        public int GetPriority()
        {
            return Priority;
        }

        public void SetPriority(int Priority)
        {
            if (Priority < 1 || Priority > 10)
                throw new Exception("The priority " + Priority + " is not valid.");
            else
                this.Priority = Priority;
        }

        public int GetExecutionTime()
        {
            return ExecutionTime;
        }

        public void Execute(int QuantumTime)
        {
            if (QuantumTime > ExecutionTime)
                QuantumTime = ExecutionTime;

            Thread.Sleep(QuantumTime * 1000);
            ExecutionTime -= QuantumTime;
        }

        public bool Finished()
        {
            return ExecutionTime == 0;
        }

        public int CompareTo(object obj)
        {
            Process toCompare = (Process)obj;
            return toCompare.GetPriority() - GetPriority();
        }

        public override string ToString()
        {
            return "Priority: " + Priority + " | Execution Time:" + ExecutionTime + "\n";
        }
    }
}
