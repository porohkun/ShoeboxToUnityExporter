using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShoeBoxToUnityExporter
{
    public partial class MainForm : Form
    {
        Graphics G;
        Image SecondBuf;
        int xSize = 1024;
        int ySize = 1024;

        FontExporter _fontExporter;

        public MainForm()
        {
            InitializeComponent();
            //InitializeGraphics();
        }

        private void InitializeGraphics(int width = 0, int height = 0)
        {
            if (xSize == 0 || height == 0)
            {
                xSize = fontPicture.Width;
                ySize = fontPicture.Height;
            }
            else
            {
                xSize = width;
                ySize = height;
            }
            SecondBuf = new Bitmap(xSize, ySize);
            G = Graphics.FromImage(SecondBuf);
        }

        private void fontPicture_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(SecondBuf, (fontPicture.Width - SecondBuf.Width) / 2, (fontPicture.Height - SecondBuf.Height) / 2);
        }

        private void dropFontLabel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void dropFontLabel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                string ext = System.IO.Path.GetExtension(file);
                switch (ext.ToLower())
                {
                    case ".png":
                    case ".jpg":
                    case ".jpeg":
                    case ".gif":
                    case ".tif":
                        ShowImage(file);
                        dropFontLabel.Visible = false;
                        break;
                    case ".txt":
                        _fontExporter = new FontExporter(file);
                        _fontExporter.Export();
                        break;
                }
            }
        }

        private void ShowImage(string file)
        {
            Bitmap image = (Bitmap)Bitmap.FromFile(file);
            InitializeGraphics(image.Width, image.Height);
            G.DrawImage(image, 0, 0);
        }
    }
}
