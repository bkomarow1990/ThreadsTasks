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

namespace Task1
{
    public partial class Form1 : Form
    {
        private int numbersCount_ = 0;
        private int lettersCount_ = 0;
        private int symbolsCount_ = 0;
        private int delay = 100;
        Thread[] threads;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            threads = new Thread[]{ new Thread(GenerateNumbers), new Thread(GenerateLetters), new Thread(GenerateSymbols) };
            numberPriority.DataSource = Enum.GetValues(typeof(ThreadPriority));
            lettersPriority.DataSource = Enum.GetValues(typeof(ThreadPriority));
            symbolsPriority.DataSource = Enum.GetValues(typeof(ThreadPriority));
            countGroupBox.Enabled = false;

        }
        //private void UpdateCounts() {
        //    numbersCount.Text = numbersCount_.ToString();
        //    lettersCount.Text = lettersCount_.ToString();
        //    symbolsCount.Text = symbolsCount_.ToString();
        //}

        private void GenerateNumbers(object state)
        {
            while (true)
            {
                this.numbersCount_++;
                lock (this)
                {
                    this.BeginInvoke(new Action(() => {
                        this.numbersTxtBox.Text+=(random.Next(0, 10));
                        numbersCount.Text = numbersCount_.ToString();
                    }));
                }
                Thread.Sleep(delay);
            }
        }
        private void GenerateLetters(object state)
        {
            while (true)
            {
                this.lettersCount_++;
                lock (this)
                {
                    this.BeginInvoke(new Action(() => {
                        this.lettersTxtBox.Text += (Convert.ToChar(random.Next(65,91)));
                        lettersCount.Text = lettersCount_.ToString();
                    }));
                }
                Thread.Sleep(delay);
            }
        }
        private void GenerateSymbols(object state)
        {
            while (true)
            {
                this.symbolsCount_++;
                lock (this)
                {
                    this.BeginInvoke(new Action(() => {
                        this.symbolsTxtBox.Text += Convert.ToChar(random.Next(33, 47));
                        symbolsCount.Text = symbolsCount_.ToString();
                    }));
                }
                Thread.Sleep(delay);
            }
        }
        private void generateBtn_Click(object sender, EventArgs e)
        {
            try { 
            foreach (var item in threads)
            {
               item.IsBackground = true;
               item.Start();
            }
            threads[0].Priority = (ThreadPriority)numberPriority.SelectedItem;
            threads[1].Priority = (ThreadPriority)lettersPriority.SelectedItem;
            threads[2].Priority = (ThreadPriority)symbolsPriority.SelectedItem;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lettersPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            threads[1].Priority = (ThreadPriority)lettersPriority.SelectedItem;
        }

        private void numberPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            threads[0].Priority = (ThreadPriority)numberPriority.SelectedItem;
        }

        private void symbolsPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            threads[2].Priority = (ThreadPriority)symbolsPriority.SelectedItem;
        }
    }
}
