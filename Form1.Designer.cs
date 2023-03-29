namespace Tulestate
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_abrirIMG = new System.Windows.Forms.Button();
            this.b_guradar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Acerca_de = new System.Windows.Forms.Button();
            this.b_relleno = new System.Windows.Forms.Button();
            this.b_borde = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Cotorno_relleno = new System.Windows.Forms.Button();
            this.Rectangulo_1 = new System.Windows.Forms.Button();
            this.elipse_2 = new System.Windows.Forms.Button();
            this.rectangulo_2 = new System.Windows.Forms.Button();
            this.Elipse_1 = new System.Windows.Forms.Button();
            this.b_linea = new System.Windows.Forms.Button();
            this.Cuadrado_contorno_relleno = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(94, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 338);
            this.tabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.b_abrirIMG);
            this.panel1.Controls.Add(this.b_guradar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(94, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 75);
            this.panel1.TabIndex = 1;
            // 
            // b_abrirIMG
            // 
            this.b_abrirIMG.BackgroundImage = global::Tulestate.Properties.Resources.abrir_archivo;
            this.b_abrirIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_abrirIMG.Location = new System.Drawing.Point(70, 3);
            this.b_abrirIMG.Name = "b_abrirIMG";
            this.b_abrirIMG.Size = new System.Drawing.Size(75, 67);
            this.b_abrirIMG.TabIndex = 2;
            this.b_abrirIMG.UseVisualStyleBackColor = true;
            this.b_abrirIMG.Click += new System.EventHandler(this.b_abrirIMG_Click);
            // 
            // b_guradar
            // 
            this.b_guradar.BackgroundImage = global::Tulestate.Properties.Resources.guradar1;
            this.b_guradar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_guradar.Location = new System.Drawing.Point(151, 3);
            this.b_guradar.Name = "b_guradar";
            this.b_guradar.Size = new System.Drawing.Size(64, 67);
            this.b_guradar.TabIndex = 1;
            this.b_guradar.UseVisualStyleBackColor = true;
            this.b_guradar.Click += new System.EventHandler(this.b_guradar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Tulestate.Properties.Resources.nuevo_archivo2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 67);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.Acerca_de);
            this.panel2.Controls.Add(this.b_relleno);
            this.panel2.Controls.Add(this.b_borde);
            this.panel2.Location = new System.Drawing.Point(331, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 75);
            this.panel2.TabIndex = 2;
            // 
            // Acerca_de
            // 
            this.Acerca_de.BackgroundImage = global::Tulestate.Properties.Resources.Help_icon;
            this.Acerca_de.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Acerca_de.Location = new System.Drawing.Point(257, 10);
            this.Acerca_de.Name = "Acerca_de";
            this.Acerca_de.Size = new System.Drawing.Size(59, 53);
            this.Acerca_de.TabIndex = 8;
            this.Acerca_de.UseVisualStyleBackColor = true;
            this.Acerca_de.Click += new System.EventHandler(this.Acerca_de_Click);
            // 
            // b_relleno
            // 
            this.b_relleno.BackgroundImage = global::Tulestate.Properties.Resources.Actions_fill_color_icon;
            this.b_relleno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_relleno.Location = new System.Drawing.Point(85, 3);
            this.b_relleno.Name = "b_relleno";
            this.b_relleno.Size = new System.Drawing.Size(78, 67);
            this.b_relleno.TabIndex = 1;
            this.b_relleno.UseVisualStyleBackColor = true;
            this.b_relleno.Click += new System.EventHandler(this.b_relleno_Click);
            // 
            // b_borde
            // 
            this.b_borde.BackgroundImage = global::Tulestate.Properties.Resources.Paint_Net_icon;
            this.b_borde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_borde.Location = new System.Drawing.Point(14, 3);
            this.b_borde.Name = "b_borde";
            this.b_borde.Size = new System.Drawing.Size(65, 67);
            this.b_borde.TabIndex = 0;
            this.b_borde.UseVisualStyleBackColor = true;
            this.b_borde.Click += new System.EventHandler(this.b_borde_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.Cuadrado_contorno_relleno);
            this.panel3.Controls.Add(this.Cotorno_relleno);
            this.panel3.Controls.Add(this.Rectangulo_1);
            this.panel3.Controls.Add(this.elipse_2);
            this.panel3.Controls.Add(this.rectangulo_2);
            this.panel3.Controls.Add(this.Elipse_1);
            this.panel3.Controls.Add(this.b_linea);
            this.panel3.Location = new System.Drawing.Point(7, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 436);
            this.panel3.TabIndex = 3;
            // 
            // Cotorno_relleno
            // 
            this.Cotorno_relleno.BackgroundImage = global::Tulestate.Properties.Resources.Button_Blank_Yellow_icon;
            this.Cotorno_relleno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cotorno_relleno.Location = new System.Drawing.Point(5, 313);
            this.Cotorno_relleno.Name = "Cotorno_relleno";
            this.Cotorno_relleno.Size = new System.Drawing.Size(57, 52);
            this.Cotorno_relleno.TabIndex = 9;
            this.Cotorno_relleno.UseVisualStyleBackColor = true;
            this.Cotorno_relleno.Click += new System.EventHandler(this.Cotorno_relleno_Click);
            // 
            // Rectangulo_1
            // 
            this.Rectangulo_1.BackgroundImage = global::Tulestate.Properties.Resources.playstation_square_black_and_white_icon;
            this.Rectangulo_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rectangulo_1.Location = new System.Drawing.Point(5, 81);
            this.Rectangulo_1.Name = "Rectangulo_1";
            this.Rectangulo_1.Size = new System.Drawing.Size(57, 52);
            this.Rectangulo_1.TabIndex = 8;
            this.Rectangulo_1.UseVisualStyleBackColor = true;
            this.Rectangulo_1.Click += new System.EventHandler(this.Rectangulo_1_Click);
            // 
            // elipse_2
            // 
            this.elipse_2.BackgroundImage = global::Tulestate.Properties.Resources.Circle_icon;
            this.elipse_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elipse_2.Location = new System.Drawing.Point(5, 255);
            this.elipse_2.Name = "elipse_2";
            this.elipse_2.Size = new System.Drawing.Size(57, 52);
            this.elipse_2.TabIndex = 7;
            this.elipse_2.UseVisualStyleBackColor = true;
            this.elipse_2.Click += new System.EventHandler(this.elipse_2_Click);
            // 
            // rectangulo_2
            // 
            this.rectangulo_2.BackgroundImage = global::Tulestate.Properties.Resources.square_icon;
            this.rectangulo_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangulo_2.Location = new System.Drawing.Point(3, 197);
            this.rectangulo_2.Name = "rectangulo_2";
            this.rectangulo_2.Size = new System.Drawing.Size(57, 51);
            this.rectangulo_2.TabIndex = 6;
            this.rectangulo_2.UseVisualStyleBackColor = true;
            this.rectangulo_2.Click += new System.EventHandler(this.rectangulo_2_Click);
            // 
            // Elipse_1
            // 
            this.Elipse_1.BackgroundImage = global::Tulestate.Properties.Resources.playstation_circle_icon;
            this.Elipse_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Elipse_1.Location = new System.Drawing.Point(5, 138);
            this.Elipse_1.Name = "Elipse_1";
            this.Elipse_1.Size = new System.Drawing.Size(57, 53);
            this.Elipse_1.TabIndex = 5;
            this.Elipse_1.UseVisualStyleBackColor = true;
            this.Elipse_1.Click += new System.EventHandler(this.Elipse_1_Click);
            // 
            // b_linea
            // 
            this.b_linea.BackgroundImage = global::Tulestate.Properties.Resources.Line_icon;
            this.b_linea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_linea.Location = new System.Drawing.Point(5, 19);
            this.b_linea.Name = "b_linea";
            this.b_linea.Size = new System.Drawing.Size(57, 56);
            this.b_linea.TabIndex = 4;
            this.b_linea.UseVisualStyleBackColor = true;
            this.b_linea.Click += new System.EventHandler(this.b_linea_Click);
            // 
            // Cuadrado_contorno_relleno
            // 
            this.Cuadrado_contorno_relleno.BackgroundImage = global::Tulestate.Properties.Resources.square_icon;
            this.Cuadrado_contorno_relleno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cuadrado_contorno_relleno.Location = new System.Drawing.Point(5, 371);
            this.Cuadrado_contorno_relleno.Name = "Cuadrado_contorno_relleno";
            this.Cuadrado_contorno_relleno.Size = new System.Drawing.Size(57, 51);
            this.Cuadrado_contorno_relleno.TabIndex = 10;
            this.Cuadrado_contorno_relleno.UseVisualStyleBackColor = true;
            this.Cuadrado_contorno_relleno.Click += new System.EventHandler(this.Cuadrado_contorno_relleno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 455);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Editor de Imagen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_guradar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_abrirIMG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button b_relleno;
        private System.Windows.Forms.Button b_borde;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Rectangulo_1;
        private System.Windows.Forms.Button elipse_2;
        private System.Windows.Forms.Button rectangulo_2;
        private System.Windows.Forms.Button Elipse_1;
        private System.Windows.Forms.Button b_linea;
        private System.Windows.Forms.Button Cotorno_relleno;
        private System.Windows.Forms.Button Acerca_de;
        private System.Windows.Forms.Button Cuadrado_contorno_relleno;
    }
}

