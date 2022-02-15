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
        public Form1()
        {
            InitializeComponent();
        }
        private void copyBtn_Click(object sender, EventArgs e)
        {
            //await Task.Run(() => {
            if (!File.Exists(pathTxtBox.Text))
            {
                MessageBox.Show("File doesn`t exists");
                return;
            }
            int pos = 0;
            long size = 0;
            int count = 0;
            int partSize = 0;
            int[] positions = null;
            BinaryReader b = null;
            FileStream fs = new FileStream(pathTxtBox.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            size = fs.Length;
            count = (int)threadsNUP.Value;
            partSize = (int)(size / count);
            positions = new int[count+1];
            positions[0] = 0;
            positions[count] = 0;
            for (int i = 1; i < count; i++)
            {
                positions[i] = pos + partSize;
            }
             b = new BinaryReader(fs);
            
            //Task[] tasks = new Task[count];
            string path = pathTxtBox.Text;
           // for (int i = 0; i < count; i++)
            //{
                //tasks[i] = Task.Factory.StartNew(() =>
                //{
                //ThreadPool.QueueUserWorkItem((obj) => {
                
            Parallel.For(0, count, (i) => {
                    b.BaseStream.Seek(positions[i], SeekOrigin.Begin);
                    byte[] data = b.ReadBytes(partSize);
                    using (var stream = File.Open(path + i + ".part", FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                    {
                        using (var writer = new BinaryWriter(stream))
                        {
                            writer.Write(data);
                        }
                    }
                });
                 
               // });
                    
               // });

            //}
            //Thread.Sleep(3000);
            //Task.WaitAll(tasks);
            using (var stream = new FileStream(Path.GetFileNameWithoutExtension(pathTxtBox.Text) + "copy" + Path.GetExtension(pathTxtBox.Text), FileMode.Create))
            {
                for (int j = 0; j < count; j++)
                {

                    byte[] bytes = File.ReadAllBytes(pathTxtBox.Text + j + ".part");
                    stream.Write(bytes, 0, bytes.Length);
                }
            }

            //});

            for (int i = 0; i < count; i++)
            {
                if (File.Exists(pathTxtBox.Text + i + ".part"))
                {
                    File.Delete(pathTxtBox.Text + i + ".part");
                }
            }
            //File.WriteAllBytes(pathTxtBox.Text, )
            //List<Thread> threads = new List<Thread>();

            //int count = (int)threadsNUP.Value;
            //long fileSz = 0;
            //int partSz = 0;
            //using (FileStream fs = new FileStream(pathTxtBox.Text, FileMode.Open, FileAccess.Read, FileShare.Read))
            //{
            //    fileSz = fs.Length;
            //    partSz = (int)(fileSz / count);
            //}
            //List<Task> tasks = new List<Task>();
            //List<byte[]> data = new List<byte[]>();
            //string path = pathTxtBox.Text;
            //int position = 0;
            //for (int i = 0; i < count; i++)
            //{
            //    tasks.Add(Task.Factory.StartNew(() =>
            //    {
            //        using (FileStream s = File.OpenRead(path))
            //        using (BinaryReader r = new BinaryReader(s))
            //        {
            //            r.BaseStream.Seek(position, SeekOrigin.Begin);
            //            position += partSz;
            //            byte[] by;
            //            if (i == count - 1)
            //            {
            //                by = r.ReadBytes((int)(fileSz - position));
            //            }
            //            else
            //            {
            //                by = r.ReadBytes(partSz);

            //            }
            //            data.Add(by);
            //        }
            //    }));

            //}
            //position = 0;
            //Task.WaitAll(tasks.ToArray());
            //List<byte> bytes = new List<byte>();
            //foreach (var item in data)
            //{
            //    bytes.AddRange(item);
            //}
            //File.WriteAllBytes(Path.GetFileNameWithoutExtension(pathTxtBox.Text) + "copy" + Path.GetExtension(pathTxtBox.Text), data.ToArray());
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
