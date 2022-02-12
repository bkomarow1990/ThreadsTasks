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

namespace Task2
{
    public partial class Form1 : Form
    {
        int partSz = 0;
        long fileSz = 0;
        bool mod;
        int offset = 0;
        int position = 0;
        List<byte[]> data = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void readTask() {
            
        }
        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(pathTxtBox.Text))
            {
                MessageBox.Show("File doesn`t exists");
                return;
            }
            List<Thread> threads = new List<Thread>();
            //using (FileStream _from_stream = new FileStream(pathTxtBox.Text, FileMode.Open))
            //{

            //    for (int i = 0; i < (int)threadsNUP.Value; i++)
            //        using (FileStream _to_stream = new FileStream(string.Format("file_{0,3}.dat", i), FileMode.OpenOrCreate))
            //        {
            //            long _byte_counter = _file_length;
            //            while (_from_stream.CanRead && _byte_counter > 0)
            //            {
            //                _byte_counter--;
            //                _to_stream.WriteByte((byte)_from_stream.ReadByte());
            //            }
            //        }
            //}

            int count = (int)threadsNUP.Value;
            using (FileStream fs = new FileStream(pathTxtBox.Text, FileMode.Open, FileAccess.Read))
            {
                fileSz = fs.Length;
                partSz = (int)(fileSz / count); // Размер одной части
                mod = fs.Length % count == 0; // Все части одного размера
              
            }
            List<Task> tasks = new List<Task>();
            data = new List<byte[]>();
            string path = pathTxtBox.Text;
            for (int i = 0; i < count; i++)
            {
                tasks.Add(Task.Factory.StartNew(() => {
                    using (FileStream s = File.OpenRead(path))
                    using (BinaryReader r = new BinaryReader(s))
                    {
                        r.BaseStream.Seek(position, SeekOrigin.Begin);
                        
                            position += partSz;
                        
                        byte[] by = r.ReadBytes(partSz);
                        data.Add(by);
                    }


                }));
                
            }
            Task.WaitAll(tasks.ToArray());
            List<byte> bytes = new List<byte>();
            foreach (var item in data)
            {
                bytes.AddRange(item);
            }
            File.WriteAllBytes(Path.GetFileNameWithoutExtension(pathTxtBox.Text)+"copy"+Path.GetExtension(pathTxtBox.Text), bytes.ToArray());

            //data = File.ReadAllBytes(pathTxtBox.Text);
            //List<Task> tasks = new List<Task>();
            //int length = data.Length;
            //for (int i = 0; i < count; i++)
            //{
            //    tasks[i] = Task.Factory.StartNew(() => { 
            //        File.WriteAllBytes($"{pathTxtBox.Text}.{i}", data);
            //    });

            //}
            //await Task.WhenAll(tasks);

        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pathTxtBox.Text = fileDialog.FileName;
            }
        }
    }
}
