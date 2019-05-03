using OSScheduler.DataStructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSScheduler
{
    public partial class Form1 : Form
    {
        private static CircularQueue circularQueue;
        private static QueueableProcess toInsert;

        public Form1()
        {
            InitializeComponent();
            circularQueue = new CircularQueue(2);
            Thread T = new Thread(new ThreadStart(Run));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toInsert = new QueueableProcess((int)execution_time.Value, (int)priority.Value);
        }

        private static void Run()
        {
            while (true)
            {
                if (toInsert != null)
                {
                    circularQueue.Insert(toInsert);
                    toInsert = null;
                }
                circularQueue.Execute();
            }
        }

        private void UpdateOutput()
        {
            QueueableProcess[] arr = circularQueue.ToArray();

            StringBuilder str = new StringBuilder(
                "Waiting " + circularQueue.Current.GetExecutionTime() + " for current process.");
            foreach(QueueableProcess q in arr)
            {
                str.Append(q);
            }
        }
    }
}
