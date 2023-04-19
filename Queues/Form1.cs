using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Queues
{
    public partial class Queue : Form
    {
        public Queue()
        {
            InitializeComponent();
        }

        //Задание 3
        Queue<int> queue = new Queue<int>();
        private void calculate_Click(object sender, EventArgs e)
        {
            outputQueue.Text = "";
            if (calculate.Text == "Ввод")
            {
                uint n;
                if (UInt32.TryParse(nNumber.Text, out n) && n!=0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        queue.Enqueue(i);
                    }
                    calculate.Text = "Извлечь из очереди";
                    nNumber.Text = "";
                }
                else
                {
                    outputQueue.Text = "Неверный ввод";
                }
            }
            else
            {
                if (queue.Count != 1) queue.Dequeue();

                else
                {
                    calculate.Text = "Ввод";
                    queue.Dequeue();
                }
            }
            foreach (int i in queue)
                outputQueue.Text += i.ToString() + "   ";
        }

        //Задание 4
        Queue<string> underAge = new Queue<string>();
        Queue<string> overAge =  new Queue<string>();
        private void showInfo_Click(object sender, EventArgs e)
        {
            string path = "data.txt";
            int age;
            if (File.Exists(path) && Int32.TryParse(workerAge.Text, out age) && age != 0 && age < 125)
            {
                string info = File.ReadAllText(path);

                string[] workers = info.Split('\n');


                string[][] workerInfo = (workers.Select(x => x.Split(' '))).ToArray();

                foreach (string[] worker in workerInfo)
                {
                    if (Int32.Parse(worker[3]) < age)
                        underAge.Enqueue(string.Join(" ", worker));
                    else overAge.Enqueue(string.Join(" ", worker));
                }
                PrintInfo();
            }
            else if (!File.Exists(path))
                workerInfo.Text = "Файл не найден";
            else workerInfo.Text = "Неверный формат ввода";

        }
        private void PrintInfo()
        {

            workerInfo.Text = $"Возраст ниже {workerAge.Text}" + '\n';
            foreach (var i in underAge.ToArray())
            {
                workerInfo.Text += underAge.Dequeue() + '\n';
            }

            workerInfo.Text += '\n' + $"Возраст выше {workerAge.Text}" + '\n';
            foreach (var i in overAge.ToArray())
            {
                workerInfo.Text += overAge.Dequeue() + '\n';
            }
        }

        //Задание 5
        private void showSortInfo_Click(object sender, EventArgs e)
        {
            sortedListOfWorkers.Text = "";
            string path = "data.txt";
            if (File.Exists(path))
            {
                string[] workers = File.ReadAllText(path).Split('\n')
                                                         .OrderBy(x => x.Split(' ')[3])
                                                         .ToArray();

                foreach (string worker in workers)
                {
                    sortedListOfWorkers.Text += worker + '\n';
                }
            }
        }
    }
}
