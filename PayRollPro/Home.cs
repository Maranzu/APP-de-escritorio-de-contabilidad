using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PayRollPro
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Btnmaximizar.Visible = false;
            Btnrestaurar.Visible = true;
        }

        private void Btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Btnmaximizar.Visible = true;
            Btnrestaurar.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btningreso_Click(object sender, EventArgs e)
        {
            abrir<Usuario>();
        }
        private void abrir <MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = Contenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                Contenedor.Controls.Add(formulario);
                Contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            Lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btnrolpagos_Click(object sender, EventArgs e)
        {
            abrir<Registro>();
        }

        private void Btnregistro_Click(object sender, EventArgs e)
        {
            abrir<Reporte>();
        }

        private void btnCompraVenta_Click(object sender, EventArgs e)
        {
            abrir<compra>();
        }
    }
}
