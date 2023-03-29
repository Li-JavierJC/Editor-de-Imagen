using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Tulestate
{
    public partial class Form1 : Form
    {
        int op, px1, py1, px2, py2;
        //int form_an, form_al;
        Graphics [] array_g = new Graphics[20];
        PictureBox [] array_Pbox = new PictureBox [20];
        TabPage [] array_tab = new TabPage [20];
        Color v_color = new Color();
        Pen pluma = new Pen (Color.Black,3);
        SolidBrush relleno =new SolidBrush(Color.Black);
    
        public Form1()
        {
            InitializeComponent();
        }

        private void crear_pestaña()
        {
            TabPage tab = new TabPage();
            tab.Name = string.Format("tab" + Convert.ToString(tabControl1.TabPages.Count + 1));
            tab.Text = string.Format("Sin titulo" + Convert.ToString(tabControl1.TabPages.Count + 1));

            PictureBox pic_box = new PictureBox();
            pic_box.Name = String.Format("Caja_Dibujo" + Convert.ToString(tabControl1.TabPages.Count + 1));
            pic_box.Location = new Point(0, 0);
            pic_box.Size = new Size(552, 301);
            Image MyImage = new Bitmap(552, 301);
            pic_box.Image = MyImage;
            Dibuja_rectangulo(552, 301, tabControl1.TabPages.Count, pic_box);

            //acciciona el mause
            pic_box.MouseDown +=sub_Mousedown;
            pic_box.MouseMove +=sub_MouseMove;
            pic_box.MouseUp +=sub_MouseUp;

            array_Pbox[tabControl1.TabPages.Count] = pic_box;
            array_tab[tabControl1.TabPages.Count] = tab;


            tab.Controls.Add(pic_box);
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
            
        }

        // recuperacion de la cordenadas del mouse
        private void sub_Mousedown(object sender, System.Windows.Forms.MouseEventArgs e) 
        {
            px1 = e.X;
            py1 = e.Y;
        }
        private void sub_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            px2 = e.X;
            py2 = e.Y;
        }

        private void sub_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Rectangle rectangulo = new Rectangle(px1, py1, System.Math.Abs(px2 - px1), System.Math.Abs(py2 - py1));
            switch (op) 
            {
                case 1:
                    array_g[tabControl1.SelectedIndex] = Graphics.FromImage(array_Pbox[tabControl1.SelectedIndex].Image);
                    array_g[tabControl1.SelectedIndex].DrawLine(pluma, px1, py1, px2, py2);
                    array_g[tabControl1.SelectedIndex].Dispose();
                    array_Pbox[tabControl1.SelectedIndex].Invalidate();
                    break;

                case 2: 
                    array_g[tabControl1.SelectedIndex] = Graphics.FromImage(array_Pbox[tabControl1.SelectedIndex].Image);
                    array_g[tabControl1.SelectedIndex].DrawRectangle(pluma, rectangulo);
                    array_g[tabControl1.SelectedIndex].Dispose();
                    array_Pbox[tabControl1.SelectedIndex].Invalidate();
                    break;
    
                case 3: 
                        array_g[tabControl1.SelectedIndex] = Graphics.FromImage(array_Pbox[tabControl1.SelectedIndex].Image);
                    array_g[tabControl1.SelectedIndex].DrawEllipse(pluma, rectangulo);
                    array_g[tabControl1.SelectedIndex].Dispose();
                    array_Pbox[tabControl1.SelectedIndex].Invalidate();
                    break;

                case 4:
                      array_g[tabControl1.SelectedIndex] = Graphics.FromImage(array_Pbox[tabControl1.SelectedIndex].Image);
                      array_g[tabControl1.SelectedIndex].FillRectangle(relleno, rectangulo);
                    array_g[tabControl1.SelectedIndex].Dispose();
                    array_Pbox[tabControl1.SelectedIndex].Invalidate();
                    break;

                case 5: array_g[tabControl1.SelectedIndex] = Graphics.FromImage(array_Pbox[tabControl1.SelectedIndex].Image);
                    array_g[tabControl1.SelectedIndex].FillEllipse(relleno, rectangulo);
                    array_g[tabControl1.SelectedIndex].Dispose();
                    array_Pbox[tabControl1.SelectedIndex].Invalidate();
                    break;

                case 6: 

                    array_g[tabControl1.SelectedIndex] = Graphics.FromImage(array_Pbox[tabControl1.SelectedIndex].Image);
                    array_g[tabControl1.SelectedIndex].DrawEllipse(pluma, rectangulo);
                    array_g[tabControl1.SelectedIndex].FillEllipse(relleno, rectangulo);
                    array_g[tabControl1.SelectedIndex].Dispose();
                    array_Pbox[tabControl1.SelectedIndex].Invalidate();
                    break;

                case 7: array_g[tabControl1.SelectedIndex] = Graphics.FromImage(array_Pbox[tabControl1.SelectedIndex].Image);
                    array_g[tabControl1.SelectedIndex].FillRectangle(relleno, rectangulo);
                    array_g[tabControl1.SelectedIndex].DrawRectangle(pluma, rectangulo);
                    array_g[tabControl1.SelectedIndex].Dispose();
                    array_Pbox[tabControl1.SelectedIndex].Invalidate();
                    break;
                
            }
        }

        private void Dibuja_rectangulo(int an, int al, int i, PictureBox pic)
        { 
            Rectangle rectangulo = new Rectangle(0, 0, an, al);
            array_g[i]= Graphics.FromImage(pic.Image);
            array_g[i].FillRectangle(new SolidBrush(Color.White), rectangulo);
            array_g[i].Dispose();
            pic.Invalidate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crear_pestaña();
            tabControl1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
        }

        private void b_linea_Click(object sender, EventArgs e)
        {
            op = 1; //linea
        }

        private void Rectangulo_1_Click(object sender, EventArgs e)
        {
            op = 2;//rectungulo 1
        }

        private void Elipse_1_Click(object sender, EventArgs e)
        {
            op = 3;//elipse 1
        }

        private void rectangulo_2_Click(object sender, EventArgs e)
        {
            op = 4;//rectangulo 2
        }

        private void elipse_2_Click(object sender, EventArgs e)
        {
            op = 5;//elipse 2
        }
        private void Cotorno_relleno_Click(object sender, EventArgs e)
        {
            op = 6;//contorno y relleno del elipse
        }

        private void Cuadrado_contorno_relleno_Click(object sender, EventArgs e)
        {
            op = 7;//contorno y relleno del cuadrado
        }

        private void b_borde_Click(object sender, EventArgs e)
        {
            ColorDialog colorD = new ColorDialog();
            if (colorD.ShowDialog() == DialogResult.OK) 
            {
                v_color = colorD.Color;
                pluma.Color = v_color;
            }
        }

        private void b_relleno_Click(object sender, EventArgs e)
        {
            ColorDialog colorD = new ColorDialog();
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                v_color = colorD.Color;
                relleno.Color = v_color;
            }
        }

        private void b_abrirIMG_Click(object sender, EventArgs e)
        {
            string nombre_archivo;
            OpenFileDialog OD = new OpenFileDialog();
            OD.Filter = "Imagen JPG|*.jpg|Imagen BMP|*.bmp";
            OD.Title = "Abrir Imagen";
            if (OD.ShowDialog() == DialogResult.OK)
            {
                crear_pestaña();
                string ruta_archivo = OD.FileName;
                array_Pbox[tabControl1.SelectedIndex].ImageLocation = ruta_archivo;
                nombre_archivo = ruta_archivo.Substring(ruta_archivo.LastIndexOf("//") + 1);
                array_tab[tabControl1.SelectedIndex].Text = nombre_archivo;
                array_Pbox[tabControl1.SelectedIndex].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                array_tab[tabControl1.SelectedIndex].AutoScroll = true;
                array_Pbox[tabControl1.SelectedIndex].Image = new Bitmap(array_Pbox[tabControl1.SelectedIndex].Width, array_Pbox[tabControl1.SelectedIndex].Height);
               
                tabControl1.Visible = true;
            }
        }

        private void b_guradar_Click(object sender, EventArgs e)
        {
            string nombre_archivo;
            SaveFileDialog SD = new SaveFileDialog();
            SD.Title = "Guarad Imagen";
            SD.Filter = "Imagen JPG|*.jpg|Imagen BMP|*.bmp";
            if (SD.ShowDialog() == DialogResult.OK)
            {
                string ruta_archivo = SD.FileName;
                nombre_archivo = ruta_archivo.Substring(ruta_archivo.LastIndexOf("\\") + 1);
                array_tab[tabControl1.SelectedIndex].Text = nombre_archivo;
                MessageBox.Show("Imagen Guardada", "Editor de Dibjo");
                array_Pbox[tabControl1.SelectedIndex].Invalidate();
                array_Pbox[tabControl1.SelectedIndex].Image.Save(ruta_archivo, System.Drawing.Imaging.ImageFormat.Jpeg);
            
            }
        }

        private void Acerca_de_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            this.Show();
        }

    }
}
