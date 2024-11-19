using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GörüntüİslemeHafta10
{
    public partial class Form1 : Form
    {
        Bitmap resim = new Bitmap(300, 300);
        Bitmap erosion_picture = new Bitmap(300, 300);
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_GetPiksel_Click(object sender, EventArgs e)
        {
            int x, y;
            int red, green, blue;
            this.Refresh();
            if (resim != null)
            {
                x = Convert.ToInt32(tb_X.Text);
                y = Convert.ToInt32(tb_Y.Text);
                Color renk = resim.GetPixel(x, y);
                red = renk.R;
                green = renk.G;
                blue = renk.B;
                tb_Renk.Text = Convert.ToString(red) + " - " + Convert.ToString(green) + " - " + Convert.ToString(blue);//Pixelin RGB Değerlerini Textboxa Yazdırıyoruz.
                panel1.BackColor = renk;
            }
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_RsmYukle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_Resim.Image = new Bitmap(openFileDialog1.FileName);
                Graphics.FromImage(resim).DrawImage(pb_Resim.Image, 0, 0, pb_Resim.Width, pb_Resim.Height);
            }
        }

        private void pb_Resim_MouseMove(object sender, MouseEventArgs e)
        {
            int red, green, blue;
            this.Refresh();
            if (resim != null)
            {
                Color renk = resim.GetPixel(e.X, e.Y);
                red = renk.R;
                green = renk.G;
                blue = renk.B;
                tb_Renk.Text = Convert.ToString(red) + " - " + Convert.ToString(green) + " - " + Convert.ToString(blue);//Pixelin RGB Değerlerini Textboxa Yazdırıyoruz.
                panel1.BackColor = renk;
                tb_X.Text = Convert.ToString(e.X);
                tb_Y.Text = Convert.ToString(e.Y);
            }
        }

        private void btn_RenkBul_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int red, green, blue;
            int r, g, b;
            Color clr;
            r = Convert.ToInt32(tb_Red.Text);
            g = Convert.ToInt32(tb_Green.Text);
            b = Convert.ToInt32(tb_Blue.Text);
            for (int i = 0; i < pb_Resim.Width; i++)
            {
                for (int j = 0; j < pb_Resim.Height; j++)
                {
                    clr = resim.GetPixel(i, j);
                    red = clr.R;
                    green = clr.G;
                    blue = clr.B;
                    if (red == r && green == g && blue == b)//Aranan RGB Değerleri ile Pixelin Değerlerini Kıyaslıyoruz.
                    {
                        listBox1.Items.Add("X = " + i + " - Y= " + j);
                    }
                }

            }
            this.Refresh();

        }

        private void btn_RenkIsaretle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int red, green, blue;
            int r, g, b;
            Color clr;
            if (tb_Red.Text != "" && tb_Green.Text != "" && tb_Blue.Text != "")
            {
                r = Convert.ToInt32(tb_Red.Text);
                g = Convert.ToInt32(tb_Green.Text);
                b = Convert.ToInt32(tb_Blue.Text);


                for (int i = 0; i < pb_Resim.Width; i++)
                {
                    for (int j = 0; j < pb_Resim.Height; j++)
                    {
                        clr = resim.GetPixel(i, j);
                        red = clr.R;
                        green = clr.G;
                        blue = clr.B;
                        if (red == r && green == g && blue == b)//Aranan RGB Değerleri ile Pixelin Değerlerini Kıyaslıyoruz.
                        {
                            listBox1.Items.Add("X = " + i + " - Y= " + j);
                            resim.SetPixel(i, j, Color.FromArgb(255, 0, 0)); //Bulunan Pixelin Rengini Kırmızı Yapıyoruz.
                            pb_Resim.Image = resim;//Yeni Oluşan Resimi PictureBoxta gösteriyoruz.
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Dogru Değer Giriniz", "Hata");
            }
            this.Refresh();

        }

        private void btn_GrayScale_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int GrayScale = 0;
            Color clr;
            for (int i = 0; i < pb_Resim.Width; i++)
            {
                for (int j = 0; j < pb_Resim.Height; j++)
                {
                    clr = resim.GetPixel(i, j);
                    GrayScale = (clr.R + clr.G + clr.B) / 3;
                    resim.SetPixel(i, j, Color.FromArgb(GrayScale, GrayScale, GrayScale)); //Bulunan Pixelin GrayScale Yapıyoruz.
                    listBox1.Items.Add("X= " + i + "Y= " + j + "-->GrayScale = " + GrayScale);
                }

            }
            pb_Resim.Image = resim;//Yeni Oluşan Resimi PictureBoxta gösteriyoruz.
            lbl_ResimDurum.Text = "GrayScale";
        }


        private void btn_Bitmap_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int GrayScale = 0;
            Color clr;
            for (int i = 0; i < pb_Resim.Width; i++)
            {
                for (int j = 0; j < pb_Resim.Height; j++)
                {
                    clr = resim.GetPixel(i, j);
                    GrayScale = (clr.R + clr.G + clr.B) / 3;
                    if (GrayScale <= 127)
                    {
                        resim.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                        listBox1.Items.Add("X= " + i + "Y= " + j + " Red=0 , Green=0, Blue=0 ");
                    }
                    else if (GrayScale > 127)
                    {
                        resim.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                        listBox1.Items.Add("X= " + i + "Y= " + j + " Red=255 , Green=255, Blue=255 ");
                    }
                }
            }
            pb_Resim.Image = resim;//Yeni Oluşan Resimi PictureBoxta gösteriyoruz.
            lbl_ResimDurum.Text = "Bitmap";
        }


        private void pb_Resim_MouseClick(object sender, MouseEventArgs e)
        {
            if (resim != null)
            {
                Color renk = resim.GetPixel(e.X, e.Y);
                tb_Red.Text = Convert.ToString(renk.R);
                tb_Green.Text = Convert.ToString(renk.G);
                tb_Blue.Text = Convert.ToString(renk.B);
            }
            this.Refresh();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            pb_Resim.Image = null;
            listBox1.Items.Clear();
            tb_Blue.Clear();
            tb_Green.Clear();
            tb_Red.Clear();
            tb_Renk.Clear();
            tb_X.Clear();
            tb_Y.Clear();
        }

        private void btn_Erosion_Click(object sender, EventArgs e)
        {
            int x1 = 255, x2 = 255, x3 = 255;
            Color clr;
            int b1, b2, b3;
            Graphics.FromImage(resim).DrawImage(pb_Resim.Image, 0, 0, pb_Resim.Width, pb_Resim.Height);
            for (int y = 1; y < pb_Resim.Width - 1; y++)
            {
                for (int x = 1; x < pb_Resim.Height - 1; x++)
                {
                    clr = resim.GetPixel(x, y);
                    b1 = clr.R;
                    clr = resim.GetPixel(x - 1, y);
                    b2 = clr.R;
                    clr = resim.GetPixel(x + 1, y);
                    b3 = clr.R;
                    if (b1 == x1 && b2 == x2 && b3 == x3) //seçilen pixellerin hepsi beyazsa orta pixeli beyaz yapar
                    {
                        erosion_picture.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else//seçilen pixellerden herhangi biri beyazdan farklıysa orta pixeli siyah yapar
                    {
                        erosion_picture.SetPixel(x, y, Color.FromArgb(0, 0, 0)); ;
                    }
                }
            }
            pb_Resim.Image = erosion_picture;
            this.Refresh();
        }
        private void btn_Dilation_Click(object sender, EventArgs e)
        {
            int x1 = 0, x2 = 0, x3 = 0;
            Color clr;
            int b1, b2, b3;
            Graphics.FromImage(resim).DrawImage(pb_Resim.Image, 0, 0, pb_Resim.Width, pb_Resim.Height);
            for (int y = 1; y < pb_Resim.Width - 1; y++)
            {
                for (int x = 1; x < pb_Resim.Height - 1; x++)
                {
                    clr = resim.GetPixel(x, y);
                    b1 = clr.R;
                    clr = resim.GetPixel(x - 1, y);
                    b2 = clr.R;
                    clr = resim.GetPixel(x + 1, y);
                    b3 = clr.R;
                    if (b1 == x1 && b2 == x2 && b3 == x3)//seçilen pixellerin hepsi siyahsa orta pixeli siyah yapar
                    {
                        erosion_picture.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else//seçilen pixellerden herhangi biri siyahtan farklıysa orta pixeli beyaz yapar
                    {
                        erosion_picture.SetPixel(x, y, Color.FromArgb(255, 255, 255)); ;
                    }
                }
            }
            pb_Resim.Image = erosion_picture;
            this.Refresh();
        }

        private void btn_TersSimetri_Click(object sender, EventArgs e)
        {
            if (pb_Resim.Image != null)//Picturebox boş değilse bu kodlar çalışır
            {
                Color clrSol, clrSag;// resimin solu ve sağındaki pixel değerlerini tutacak olan değişkenler
                Graphics.FromImage(resim).DrawImage(pb_Resim.Image, 0, 0, pb_Resim.Width, pb_Resim.Height);
                for (int y = 0; y < pb_Resim.Width; y++)
                {
                    for (int x = 0; x < pb_Resim.Height / 2; x++)//görüntünün x eksenine göre ortasına kadar çalışacak
                    {
                        clrSol = resim.GetPixel(x, y);
                        clrSag = resim.GetPixel((pb_Resim.Height - 1 - x), y);
                        resim.SetPixel(x, y, clrSag);
                        resim.SetPixel((pb_Resim.Height - 1 - x), y, clrSol);
                    }
                }
                pb_Resim.Image = resim;//Yeni Oluşan Resimi PictureBoxta gösteriyoruz.
            }
            else
            {
                MessageBox.Show("Resim Yükleyiniz", "Hata");
            }

        }
    }
}
