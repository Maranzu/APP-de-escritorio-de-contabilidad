using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PayRollPro
{
    public partial class compra : Form
    {
        public compra()
        {
            InitializeComponent();
        }

        private void compraVenta_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private List<Datos> tabla = new List<Datos>();
        public class Datos
        {
            public string datoscompra { get; set; }
            public string fecha { get; set; }
            public int valor { get; set; }
            public string nrofactura { get; set; }
            public string empresacompra { get; set; }
            public string empresaventa { get; set; }
            public string tipocompra { get; set; }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DtFecha.Text) ||
            string.IsNullOrEmpty(txtCompra.Text) ||
            Udvalor.Value == 0 ||
            string.IsNullOrEmpty(txtFactura.Text) ||
            comboboxEmpresaCompradora.SelectedItem == null ||
            comboboxEmpresaVendedora.SelectedItem == null ||
            comboboxTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, ingrese todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Ingreso de datos en la tabla
                Datos info = new Datos();
                info.fecha = DtFecha.Text;
                info.datoscompra = txtCompra.Text;
                info.valor = (int)Udvalor.Value;
                info.nrofactura = txtFactura.Text;
                info.empresacompra = comboboxEmpresaCompradora.SelectedItem.ToString();
                info.empresaventa = comboboxEmpresaVendedora.SelectedItem.ToString();
                info.tipocompra = comboboxTipo.SelectedItem.ToString();

                tabla.Add(info);
                dgvCompra.DataSource = null;
                dgvCompra.DataSource = tabla;
                //Funciones
                tabledebe();
                tableHaber();
                calculos();
                //Cambio de nombres
                dgvCompra.Columns["fecha"].HeaderText = "FECHA";
                dgvCompra.Columns["datoscompra"].HeaderText = "DETALLE DE COMPRA";
                dgvCompra.Columns["valor"].HeaderText = "VALOR";
                dgvCompra.Columns["nrofactura"].HeaderText = "NRO DE FACTURA";
                dgvCompra.Columns["empresacompra"].HeaderText = "EMPRESA COMPRADORA";
                dgvCompra.Columns["empresaventa"].HeaderText = "EMPRESA VENDEDORA";
                dgvCompra.Columns["tipocompra"].HeaderText = "TIPO DE COMPRA";
            }
        }
        private void dgvCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;

            if (fila >= 0 && fila < tabla.Count)
            {
                Datos info = tabla[fila];
                DtFecha.Text = info.fecha;
                txtCompra.Text = info.datoscompra;
                Udvalor.Value = info.valor;
                txtFactura.Text = info.nrofactura;
                comboboxEmpresaCompradora.SelectedItem = info.empresacompra;
                comboboxEmpresaVendedora.SelectedItem = info.empresaventa;
                comboboxTipo.SelectedItem = info.tipocompra;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //EDITAR
            if (string.IsNullOrEmpty(DtFecha.Text) ||
            string.IsNullOrEmpty(txtCompra.Text) ||
            Udvalor.Value == 0 ||
            string.IsNullOrEmpty(txtFactura.Text) ||
            comboboxEmpresaCompradora.SelectedItem == null ||
            comboboxEmpresaVendedora.SelectedItem == null ||
            comboboxTipo.SelectedItem == null)
            {
                MessageBox.Show("No hay datos en la fila o todavía no se ha creado una", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int fila = dgvCompra.CurrentCell.RowIndex;

                // Actualizar los datos en la tabla
                if (fila >= 0 && fila < tabla.Count)
                {
                    Datos info = tabla[fila];
                    info.fecha = DtFecha.Text;
                    info.datoscompra = txtCompra.Text;
                    info.valor = (int)Udvalor.Value;
                    info.nrofactura = txtFactura.Text;
                    info.empresacompra = comboboxEmpresaCompradora.SelectedItem.ToString();
                    info.empresaventa = comboboxEmpresaVendedora.SelectedItem.ToString();
                    info.tipocompra = comboboxTipo.SelectedItem.ToString();
                    // Actualizar la tabla
                    calculos();
                    dgvCompra.DataSource = null;
                    dgvCompra.DataSource = tabla;
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //ELIMINAR
            if (string.IsNullOrEmpty(DtFecha.Text) ||
            string.IsNullOrEmpty(txtCompra.Text) ||
            Udvalor.Value == 0 ||
            string.IsNullOrEmpty(txtFactura.Text) ||
            comboboxEmpresaCompradora.SelectedItem == null ||
            comboboxEmpresaVendedora.SelectedItem == null ||
            comboboxTipo.SelectedItem == null)
            {
                MessageBox.Show("No hay datos en la fila o todavía no se ha creado una", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int fila = dgvCompra.CurrentCell.RowIndex;
                if (fila >= 0 && fila < tabla.Count)
                {
                    Datos info = tabla[fila];
                    tabla.Remove(info);
                    dgvCompra.DataSource = null;
                    dgvCompra.DataSource = tabla;
                    tabledebe();
                    tableHaber();
                }
            }
        }
        private void calculos()
        {
            //Subtotal
            decimal valorSubtotal = Udvalor.Value;
            txtSubtotal.Text = valorSubtotal.ToString("C");
            //Total del iva
            decimal valor = Udvalor.Value;
            decimal resultadoIva = valor / 1.12m;
            txtIva.Text = resultadoIva.ToString("C");
            //Resultado total
            decimal resultadototal = valor + resultadoIva;
            txtTotal.Text = resultadototal.ToString("C");
            //Retención iva e irf
            if (comboboxTipo.SelectedItem.ToString() == "BIENES" &&
                comboboxEmpresaCompradora.SelectedItem.ToString() == "CONTRIBUYENTE ESPECIAL" &&
                    comboboxEmpresaVendedora.SelectedItem.ToString() == "CONTRIBUYENTE ESPECIAL")
            {

                //se usa el 0.1m como 10%, esto se debe  al tipo de dato decimal
                decimal retencionIva = resultadoIva * 0.1m;
                //se usa el 0.0175m como 1.75%, esto se debe  al tipo de dato decimal
                decimal retencionIrf = valorSubtotal * 0.0175m;
                // se suma el total de la compra con el resultado del iva y se resta con las retenciones.
                decimal tipopago = valorSubtotal + resultadoIva - retencionIrf - retencionIva;
                //Resultado debe / se suma el total de la compra con la retención del iva
                decimal resultadodebe = valorSubtotal + retencionIva;
                foreach (DataGridViewRow filaseleccionada in dgvCompra.Rows)
                {
                    //fila.Cells["debetable"].Value = resultadodebe.ToString("C");
                    DataGridViewCell cell = filaseleccionada.Cells["debeTable"];
                    cell.Value = resultadodebe.ToString("C");
                }
                //Resultado haber / se suma el tipo de pago con las retenciones
                decimal resultadohaber = tipopago + retencionIrf + retencionIva;
            }
        }
        private void tabledebe()
        {
            //Verificar si la columna existe
            bool existeColumna = false;
            foreach (DataGridViewColumn columna in dgvCompra.Columns)
            {
                if (columna.Name == "debetable")
                {
                    existeColumna = true;
                    break;
                }
            }
            if (!existeColumna)
            {
                //Agregar la columna
                DataGridViewTextBoxColumn debeTable = new DataGridViewTextBoxColumn();
                debeTable.HeaderText = "DEBE";
                debeTable.Name = "debetable";
                debeTable.ReadOnly = true;
                dgvCompra.Columns.Add(debeTable);
            }
            //La columna siempre se mantendrá al final de las columnas
            dgvCompra.Columns["debetable"].DisplayIndex = dgvCompra.Columns.Count - 1;
        }
        private void tableHaber()
        {
            //Verificar si la columna existe
            bool existeColumna = false;
            foreach (DataGridViewColumn columna in dgvCompra.Columns)
            {
                if (columna.Name == "habertable")
                {
                    existeColumna = true;
                    break;
                }
            }
            if (!existeColumna)
            {
                //Agregar la columna
                DataGridViewTextBoxColumn habertable = new DataGridViewTextBoxColumn();
                habertable.HeaderText = "HABER";
                habertable.Name = "habertable";
                habertable.ReadOnly = true;
                dgvCompra.Columns.Add(habertable);
            }
            //La columna siempre se mantendrá al final de las columnas
            dgvCompra.Columns["habertable"].DisplayIndex = dgvCompra.Columns.Count - 1;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
