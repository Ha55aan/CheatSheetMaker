using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChEncoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Bitmap code;
        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                code = generateBitmap(tbxMessage.Text);
                pictureBox1.Image = code;
                Console.WriteLine("done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }

        }


        Bitmap generateBitmap(string text)
        {
            char[] msg = text.ToCharArray();
            int imageHeight = Convert.ToInt32(nudImageHeight.Value);
            int imageWidth = Convert.ToInt32(nudImageWidth.Value);
            int charSize = Convert.ToInt32(nudCharSize.Value);

            Bitmap bmp = new Bitmap(imageHeight, imageWidth);

            int x = 0;
            int y = 0;
            var gfx = Graphics.FromImage(bmp);
            foreach (char c in msg)
            {
                if (x >= imageWidth-charSize)
                {
                    x = 0;
                    y = y + charSize +2;
                }
                if (y >= imageWidth)
                {
                    break;
                }
                try
                {
                    Console.Write(c.ToString());
                    if (c == ' ')
                    {
                        x += charSize;
                    }
                    if (c == '\n')
                    {
                        x = 0;
                        y += charSize+ 2;
                    }
                    if (c == '.')
                    {
                        Bitmap _bmp = new Bitmap(Image.FromFile("images\\period.png"), charSize, charSize);
                        gfx.DrawImage(_bmp, x, y);

                        gfx.Dispose();
                        _bmp.Dispose();

                        x += charSize + 1;
                    }
                    if (char.IsLetter(c))
                    {
                        Bitmap _bmp = new Bitmap(Image.FromFile("images\\"+char.ToLower(c) + ".png"), charSize, charSize);
                        gfx.DrawImage(_bmp, x, y);

                        gfx.Dispose();
                        _bmp.Dispose();

                        x += charSize+1;
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return bmp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.DefaultExt = "png";
                sfd.AddExtension = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        code.Save(sfd.FileName);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR");
                    }
                }
            }
        }
    }
}
