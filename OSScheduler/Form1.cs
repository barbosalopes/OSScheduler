using OSScheduler.DataStructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            Thread T2 = new Thread(new ThreadStart(Run));
            T.Start();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(UpdateOutput);
            timer.Interval = 100;
            timer.Start();

            loadFile();
        }

        private void loadFile()
        {
            try
            {
                string line;
                StreamReader stream = new StreamReader(@"C:\Users\mateu\Desktop\TI.txt");
                QueueableProcess queueableProcess = null;

                int cod, priority, cicleNumbers, executionTime;
                string name;

                while ((line = stream.ReadLine()) != null)
                {
                    string[] processParams = line.Split(';');
                    cod = int.Parse(processParams[0]);
                    name = processParams[1];
                    priority = int.Parse(processParams[2]);
                    cicleNumbers = int.Parse(processParams[3]);
                    executionTime = (int)quantum.Value * cicleNumbers;

                    queueableProcess = new QueueableProcess(cod, name, executionTime, priority);
                    circularQueue.Insert(queueableProcess);
                }

                UpdateOutput();
            }
            catch (Exception e)
            {
                Console.WriteLine("Por favor configure no codigo o endereço de input do arquivo.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toInsert = new QueueableProcess(name.Text, (int)execution_time.Value, (int)priority.Value);
            circularQueue.Insert(toInsert);

            execution_time.Value = 60;
            priority.Value = 5;
            UpdateOutput();
        }

        private static void Run()
        {
            while (true)
            {
                circularQueue.Execute();
            }
        }

        private void UpdateOutput(object sender, EventArgs e) 
        {
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            QueueableProcess[] arr = circularQueue.ToArray();

            StringBuilder str = new StringBuilder();

            if (circularQueue.Current == null)
                str.Append("There is no process running, try adding one!");

            foreach (QueueableProcess q in arr)
            {
                str.Append(q);
            }
            output.Text = str.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            circularQueue = new CircularQueue((int)quantum.Value);
        }

        private void quantum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            QueueableProcess toRemove = new QueueableProcess(name_to_delete.Text, 0, 0);
            circularQueue.Remove();
        }
    }
}
