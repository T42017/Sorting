using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SelectionSortDemo
{
    public partial class Form1 : Form
    {
        private readonly List<int> listToBeSorted = new List<int>();
        private readonly Random numberGenerator = new Random();
        private string output = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            output = string.Empty;

            for (var i = 0; i < listToBeSorted.Count; i++)
            {
                var indexOfLowest = i;
                var lowest = listToBeSorted[i];
                for (var j = i; j < listToBeSorted.Count; j++)
                    if (listToBeSorted[j] < lowest)
                    {
                        lowest = listToBeSorted[j];
                        indexOfLowest = j;
                    }
                Swap(listToBeSorted, i, indexOfLowest);
            }
            foreach (var i in listToBeSorted)
                if (i < 10)
                    output += i + "    ";

                else
                    output += i + "  ";

            textBox1.Text = output;

        }

        public void Swap(List<int> list, int a, int b)
        {
            var tmp = list[a];
            list[a] = list[b];
            list[b] = tmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            output = string.Empty;

            for (var i = 0; i < numberOfDesiredItems.Value; i++)
            {
                var value = numberGenerator.Next(0, 100);

                listToBeSorted.Add(value);
                if (value < 10)
                    output += value + "    ";

                else
                    output += value + "  ";


                textBox1.Text = output;
            }
        }
    }
}