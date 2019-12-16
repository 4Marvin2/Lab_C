using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<string> words = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "D:\\Lab_C\\lab04";
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                string path = openFileDialog.FileName;
                StreamReader sr = new StreamReader(path);

                string text = sr.ReadToEnd();
                
                char[] pattern = { ' ', ',', '.', ';', ':', '(', ')', '\n' };
                string[] words_str = text.Split(pattern);

                for (int j = 0; j < words_str.Length; j++)
                {
                    if ((String.Compare(words_str[j], "\0") != 0) && (String.Compare(words_str[j], "\n") != 0) && (String.Compare(words_str[j], "\r") != 0))
                    {
                        if (!words.Contains(words_str[j]))
                        {
                            words.Add(words_str[j]);
                        }
                    }

                }
                stopWatch.Stop();

                this.textBox1.Text = stopWatch.Elapsed.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string right_word = textBox2.Text;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            this.listBox1.Items.Clear();
            foreach (string word in words)
            {
                if (word.Contains(right_word))
                {
                    listBox1.BeginUpdate();
                    listBox1.Items.Add(word);
                    listBox1.EndUpdate();
                }
            }
            stopWatch.Stop();

            this.textBox3.Text = stopWatch.Elapsed.ToString();
        }

        
    }
}
