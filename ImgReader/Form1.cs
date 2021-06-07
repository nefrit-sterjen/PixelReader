using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
/*
 * Программа считывает пиксели, записывает их в базу данных.
 * Так же программа может восстановить изображение по записанным пикселям
 */

namespace ImgReader
{
    public partial class ImgReader : Form
    {
        public ImgReader()
        {
            InitializeComponent();
        }

        private void buttonWritePath_Click(object sender, EventArgs e)
        {
            var opd = new OpenFileDialog();
            opd.ShowDialog();
            writeBoxPath.Text = opd.FileName;
        }

        private void buttonReadPath_Click(object sender, EventArgs e)
        {
            var opd = new OpenFileDialog();
            opd.ShowDialog();
            readBoxPath.Text = opd.FileName;
            
        }

        private void buttonAddImg_Click(object sender, EventArgs e)
        {
            var opd = new OpenFileDialog();
            opd.ShowDialog();
            Bitmap img = new Bitmap(opd.FileName);
                pictureBox.Image = img;
            
        }

        private void buttonWritePix_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox.Image);

            int x, y;

            StreamWriter writer = new StreamWriter(writeBoxPath.Text);

            for (x = 0; x < image.Width; x++)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color pix = image.GetPixel(x, y);

                    writer.WriteLine(pix.A + " " + pix.R + " " + pix.G + " " + pix.B);
                }
                writer.WriteLine("-----------------------------------");
            }

            writer.Close();
            MessageBox.Show("Пиксели записаны!");
        }

        private void buttonReadPix_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(readBoxPath.Text);
            int y = 0;
            int x = 0;
            List<byte[]> argb = new List<byte[]>();

            while (!reader.EndOfStream)
            {
                string str = reader.ReadLine();

                if (str.Length != 0)
                {
                    if (str.Contains('-'))
                    {
                        y++;
                    }
                    else
                    {
                        String[] vars = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        byte[] b = new byte[4];

                        b[0] = Convert.ToByte(vars[0]);
                        b[1] = Convert.ToByte(vars[1]);
                        b[2] = Convert.ToByte(vars[2]);
                        b[3] = Convert.ToByte(vars[3]);
                        argb.Add(b);
                    }
                    x++;

                }
            }
            x = x / y - 1;
           
            reader.Close();

            Bitmap img = new Bitmap(y, x);
            int count = 0;

            for (x = 0; x < img.Width; x++)
            {
                for (y = 0; y < img.Height; y++)
                {
                    byte[] b = argb.ElementAt(count);
                    img.SetPixel(x, y, Color.FromArgb(b[0], b[1], b[2], b[3]));
                    count++;
                }
            }

            pictureBox.Image = img;
            


        }
    }
}
