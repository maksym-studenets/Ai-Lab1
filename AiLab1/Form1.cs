using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiLab1
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private Image image;
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open File";
                openFileDialog.Filter = "";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.Image = image;
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void convertToGrayScaleButton_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Image);
            graphics = pictureBox1.CreateGraphics();

            int blackColorMargin = Int32.Parse(blackPixelText.Text);
            int greyColorValue = 0;
            SolidBrush brush = new SolidBrush(Color.White);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    greyColorValue = (bitmap.GetPixel(i, j).R + bitmap.GetPixel(i, j).G + bitmap.GetPixel(i, j).B) / 3;
                    if (greyColorValue < blackColorMargin)
                    {
                        bitmap.SetPixel(i, j, Color.Black);
                        brush.Color = Color.Black;
                    }
                    else
                    {
                        bitmap.SetPixel(i, j, Color.White);
                        brush.Color = Color.White;
                    }
                    graphics.FillRectangle(brush, i, j, 1, 1);
                }
            }
        }
    }
}
