namespace PayRollPro
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Titulo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Btnrestaurar = new System.Windows.Forms.PictureBox();
            this.Btnminimizar = new System.Windows.Forms.PictureBox();
            this.Btnmaximizar = new System.Windows.Forms.PictureBox();
            this.Btncerrar = new System.Windows.Forms.PictureBox();
            this.Menupanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCompraVenta = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btnregistro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btnrolpagos = new System.Windows.Forms.Button();
            this.Btningreso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lblhora = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btncerrar)).BeginInit();
            this.Menupanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Titulo.Controls.Add(this.button1);
            this.Titulo.Controls.Add(this.Btnrestaurar);
            this.Titulo.Controls.Add(this.Btnminimizar);
            this.Titulo.Controls.Add(this.Btnmaximizar);
            this.Titulo.Controls.Add(this.Btncerrar);
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(1200, 30);
            this.Titulo.TabIndex = 0;
            this.Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titulo_MouseDown);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pay Roll Pro";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Btnrestaurar
            // 
            this.Btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnrestaurar.Enabled = false;
            this.Btnrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("Btnrestaurar.Image")));
            this.Btnrestaurar.Location = new System.Drawing.Point(1141, 2);
            this.Btnrestaurar.Name = "Btnrestaurar";
            this.Btnrestaurar.Size = new System.Drawing.Size(25, 25);
            this.Btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btnrestaurar.TabIndex = 3;
            this.Btnrestaurar.TabStop = false;
            this.Btnrestaurar.Visible = false;
            this.Btnrestaurar.Click += new System.EventHandler(this.Btnrestaurar_Click);
            // 
            // Btnminimizar
            // 
            this.Btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btnminimizar.Image")));
            this.Btnminimizar.Location = new System.Drawing.Point(1110, 2);
            this.Btnminimizar.Name = "Btnminimizar";
            this.Btnminimizar.Size = new System.Drawing.Size(25, 25);
            this.Btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btnminimizar.TabIndex = 2;
            this.Btnminimizar.TabStop = false;
            this.Btnminimizar.Click += new System.EventHandler(this.Btnminimizar_Click);
            // 
            // Btnmaximizar
            // 
            this.Btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnmaximizar.Enabled = false;
            this.Btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("Btnmaximizar.Image")));
            this.Btnmaximizar.Location = new System.Drawing.Point(1141, 2);
            this.Btnmaximizar.Name = "Btnmaximizar";
            this.Btnmaximizar.Size = new System.Drawing.Size(25, 25);
            this.Btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btnmaximizar.TabIndex = 1;
            this.Btnmaximizar.TabStop = false;
            this.Btnmaximizar.Click += new System.EventHandler(this.Btnmaximizar_Click);
            // 
            // Btncerrar
            // 
            this.Btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btncerrar.Image")));
            this.Btncerrar.Location = new System.Drawing.Point(1172, 2);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(25, 25);
            this.Btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btncerrar.TabIndex = 0;
            this.Btncerrar.TabStop = false;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // Menupanel
            // 
            this.Menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Menupanel.Controls.Add(this.panel5);
            this.Menupanel.Controls.Add(this.btnCompraVenta);
            this.Menupanel.Controls.Add(this.panel4);
            this.Menupanel.Controls.Add(this.Btnregistro);
            this.Menupanel.Controls.Add(this.panel3);
            this.Menupanel.Controls.Add(this.button2);
            this.Menupanel.Controls.Add(this.panel2);
            this.Menupanel.Controls.Add(this.panel1);
            this.Menupanel.Controls.Add(this.Btnrolpagos);
            this.Menupanel.Controls.Add(this.Btningreso);
            this.Menupanel.Controls.Add(this.pictureBox1);
            this.Menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menupanel.Location = new System.Drawing.Point(0, 30);
            this.Menupanel.Name = "Menupanel";
            this.Menupanel.Size = new System.Drawing.Size(210, 520);
            this.Menupanel.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(3, 232);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 35);
            this.panel5.TabIndex = 6;
            // 
            // btnCompraVenta
            // 
            this.btnCompraVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCompraVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompraVenta.FlatAppearance.BorderSize = 0;
            this.btnCompraVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCompraVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraVenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompraVenta.ForeColor = System.Drawing.Color.White;
            this.btnCompraVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnCompraVenta.Image")));
            this.btnCompraVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompraVenta.Location = new System.Drawing.Point(10, 232);
            this.btnCompraVenta.Name = "btnCompraVenta";
            this.btnCompraVenta.Size = new System.Drawing.Size(194, 35);
            this.btnCompraVenta.TabIndex = 6;
            this.btnCompraVenta.Text = "Compra / Venta";
            this.btnCompraVenta.UseVisualStyleBackColor = false;
            this.btnCompraVenta.Click += new System.EventHandler(this.btnCompraVenta_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(3, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 35);
            this.panel4.TabIndex = 5;
            // 
            // Btnregistro
            // 
            this.Btnregistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btnregistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnregistro.FlatAppearance.BorderSize = 0;
            this.Btnregistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btnregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnregistro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnregistro.ForeColor = System.Drawing.Color.White;
            this.Btnregistro.Image = ((System.Drawing.Image)(resources.GetObject("Btnregistro.Image")));
            this.Btnregistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnregistro.Location = new System.Drawing.Point(10, 191);
            this.Btnregistro.Name = "Btnregistro";
            this.Btnregistro.Size = new System.Drawing.Size(194, 35);
            this.Btnregistro.TabIndex = 4;
            this.Btnregistro.Text = "Ingresos / Egresos";
            this.Btnregistro.UseVisualStyleBackColor = false;
            this.Btnregistro.Click += new System.EventHandler(this.Btnregistro_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(1, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 35);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(10, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cerrar aplicación";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(3, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 35);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(3, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 35);
            this.panel1.TabIndex = 0;
            // 
            // Btnrolpagos
            // 
            this.Btnrolpagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btnrolpagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnrolpagos.FlatAppearance.BorderSize = 0;
            this.Btnrolpagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btnrolpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnrolpagos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnrolpagos.ForeColor = System.Drawing.Color.White;
            this.Btnrolpagos.Image = ((System.Drawing.Image)(resources.GetObject("Btnrolpagos.Image")));
            this.Btnrolpagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnrolpagos.Location = new System.Drawing.Point(12, 150);
            this.Btnrolpagos.Name = "Btnrolpagos";
            this.Btnrolpagos.Size = new System.Drawing.Size(194, 35);
            this.Btnrolpagos.TabIndex = 2;
            this.Btnrolpagos.Text = "Rol de pagos";
            this.Btnrolpagos.UseVisualStyleBackColor = false;
            this.Btnrolpagos.Click += new System.EventHandler(this.Btnrolpagos_Click);
            // 
            // Btningreso
            // 
            this.Btningreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btningreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btningreso.FlatAppearance.BorderSize = 0;
            this.Btningreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btningreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btningreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btningreso.ForeColor = System.Drawing.Color.White;
            this.Btningreso.Image = ((System.Drawing.Image)(resources.GetObject("Btningreso.Image")));
            this.Btningreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btningreso.Location = new System.Drawing.Point(12, 109);
            this.Btningreso.Name = "Btningreso";
            this.Btningreso.Size = new System.Drawing.Size(194, 35);
            this.Btningreso.TabIndex = 0;
            this.Btningreso.Text = "Ingreso";
            this.Btningreso.UseVisualStyleBackColor = false;
            this.Btningreso.Click += new System.EventHandler(this.Btningreso_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Contenedor.Controls.Add(this.pictureBox2);
            this.Contenedor.Controls.Add(this.label1);
            this.Contenedor.Controls.Add(this.Lblhora);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(210, 30);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(990, 520);
            this.Contenedor.TabIndex = 2;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(990, 454);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido usuario";
            // 
            // Lblhora
            // 
            this.Lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lblhora.AutoSize = true;
            this.Lblhora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Lblhora.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblhora.ForeColor = System.Drawing.Color.White;
            this.Lblhora.Location = new System.Drawing.Point(750, 6);
            this.Lblhora.Name = "Lblhora";
            this.Lblhora.Size = new System.Drawing.Size(152, 64);
            this.Lblhora.TabIndex = 0;
            this.Lblhora.Text = "Hora";
            // 
            // tiempo
            // 
            this.tiempo.Enabled = true;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.Menupanel);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Pay Roll Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btncerrar)).EndInit();
            this.Menupanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Contenedor.ResumeLayout(false);
            this.Contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Titulo;
        private System.Windows.Forms.Panel Menupanel;
        private System.Windows.Forms.PictureBox Btnminimizar;
        private System.Windows.Forms.PictureBox Btnmaximizar;
        private System.Windows.Forms.PictureBox Btncerrar;
        private System.Windows.Forms.PictureBox Btnrestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btningreso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btnrolpagos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label Lblhora;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btnregistro;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCompraVenta;
    }
}

