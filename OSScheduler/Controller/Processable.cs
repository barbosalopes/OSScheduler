using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSScheduler.Controller
{
    interface Processable
    {
        void Execute(int QuantumTime);

        int GetPriority();

        void SetPriority(int Priority);

        int GetExecutionTime();
    }
}
