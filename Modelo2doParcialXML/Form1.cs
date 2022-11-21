using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
using System.Text.RegularExpressions;


namespace Modelo2doParcialXML
{
    public partial class Form1 : Form
    {
        public void CargarDGrid(bool b)
        {
            dgridPolizas.DataSource = null;
            if (b == true)
            {
                dgridPolizas.DataSource = obllAutomovil.Listar();
            }
            else 
            {
                dgridPolizas.DataSource = obllMaritima.Listar();
            }
        }

        public void Limpiar()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();

            txtIDpoliza.Clear();
            numupPrima.Value = 1;
            txtMarca.Clear();
            txtModelo.Clear();

            txtID.Enabled = true;
            txtIDpoliza.Enabled = true;
        }

        public bool VerificarTexto(string texto)
        {
            Regex reg = new Regex(@"^([A-Z]{1})([a-z]{1,})$");

            if (reg.IsMatch(texto.Trim()))
            { return true;}
            else
            {return false;}
        }

        public bool VerificarDni(string texto)
        {
            Regex reg = new Regex(@"^([0-9]){8}$");

            if (reg.IsMatch(texto.Trim()))
            { return true; }
            else
            { return false; }
        }

        public Form1()
        {
            InitializeComponent();
            oCliente = new BEcliente();
            oAutomovil = new BEPautomovil();
            oMaritima = new BEPmaritima();

            obllCliente = new BLLcliente();
            obllAutomovil = new BLLpAutomovil();
            obllMaritima = new BLLpMaritima();

            groupBox1.Visible = false;
        }

        BEcliente oCliente;
        BEPautomovil oAutomovil;
        BEPmaritima oMaritima;
        BLLcliente obllCliente;
        BLLpAutomovil obllAutomovil;
        BLLpMaritima obllMaritima;

        private void btnEliminarPoliza_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarTexto(txtNombre.Text)&&VerificarTexto(txtApellido.Text)&&VerificarDni(txtDni.Text))
            {
                oCliente.ID = Convert.ToInt32(txtID.Text);
                oCliente.Nombre = txtNombre.Text;
                oCliente.Apellido = txtApellido.Text;
                oCliente.Dni = Convert.ToInt32(txtDni.Text);
                
            }

            if (rbAutomovil.Checked == true)
            {
                if (VerificarTexto(txtModelo.Text) && VerificarTexto(txtMarca.Text))
                {
                    BEPautomovil auto = new BEPautomovil();

                    auto.ID =Convert.ToInt32(txtID.Text);
                    auto.Prima = Convert.ToDouble(numupPrima.Value);
                    auto.Tasa = obllAutomovil.CalcularPrima(Convert.ToDouble(numupPrima.Value));
                    auto.Estado = Enumerador.Activo.ToString();
                    auto.Modelo = txtModelo.Text;
                    auto.Marca = txtMarca.Text;
                    auto.Cliente = oCliente;

                    obllCliente.AgregarCliente(oCliente);
                    obllAutomovil.Agregar(auto);
                    Limpiar();
                }
            }
            else if (rbMaritima.Checked == true)
            {
                BEPmaritima mar = new BEPmaritima();

                mar.ID = Convert.ToInt32(txtID.Text);
                mar.Prima = Convert.ToDouble(numupPrima.Value);
                mar.Tasa = obllAutomovil.CalcularPrima(Convert.ToDouble(numupPrima.Value));
                mar.Estado = Enumerador.Activo.ToString();
                mar.Cliente = oCliente;

                obllCliente.AgregarCliente(oCliente);
                obllMaritima.Agregar(mar);
                Limpiar();
            }
        }

        private void rbAutomovil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutomovil.Checked == true)
            {
                groupBox1.Visible = true;

            }
            else
            {
                groupBox1.Visible = false;
            }
            
        }

        private void rbMostrarAutomovil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMostrarAutomovil.Checked == true)
            {
                CargarDGrid(true);
            }
        }

        private void rbMostrarMaritima_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMostrarMaritima.Checked == true)
            {
                CargarDGrid(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgridClientes.DataSource = null;
            dgridClientes.DataSource = obllCliente.Listar();
        }

        private void dgridPolizas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbMostrarAutomovil.Checked == true)
            {
                oAutomovil = (BEPautomovil)dgridPolizas.CurrentRow.DataBoundItem;
                rbAutomovil.Checked = true;
                txtIDpoliza.Text =Convert.ToString(oAutomovil.ID);
                txtIDpoliza.Enabled = false;
                numupPrima.Value = Convert.ToDecimal(oAutomovil.Prima);
                txtModelo.Text = oAutomovil.Modelo;
                txtMarca.Text = oAutomovil.Marca;

            }
            else if (rbMostrarMaritima.Checked == true)
            {
                oMaritima = (BEPmaritima)dgridPolizas.CurrentRow.DataBoundItem;
                rbMostrarMaritima.Checked = true;
                txtIDpoliza.Text = Convert.ToString(oMaritima.ID);
                txtIDpoliza.Enabled = false;
                numupPrima.Value = Convert.ToDecimal(oMaritima.Prima);
            }
        }

        private void btnModificarPoliza_Click(object sender, EventArgs e)
        {
            if (rbAutomovil.Checked == true)
            {
                if (VerificarTexto(txtModelo.Text) && VerificarTexto(txtMarca.Text))
                {

                    oAutomovil.Prima = Convert.ToDouble(numupPrima.Value);
                    oAutomovil.Tasa = obllAutomovil.CalcularPrima(Convert.ToDouble(numupPrima.Value));
                    oAutomovil.Estado = Enumerador.Activo.ToString();
                    oAutomovil.Modelo = txtModelo.Text;
                    oAutomovil.Marca = txtMarca.Text;
                    

                    obllAutomovil.Modificar(oAutomovil);
                    Limpiar();
                }
            }
            else if (rbMaritima.Checked == true)
            {

                oMaritima.ID = Convert.ToInt32(txtIDpoliza.Text);
                oMaritima.Prima = Convert.ToDouble(numupPrima.Value);
                oMaritima.Tasa = obllMaritima.CalcularPrima(Convert.ToDouble(numupPrima.Value));
                oMaritima.Estado = Enumerador.Activo.ToString();

                obllMaritima.Modificar(oMaritima);
                Limpiar();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            obllCliente.Eliminar(Convert.ToString(oCliente.ID));
            Limpiar();
        }

        private void dgridClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            oCliente = (BEcliente)dgridClientes.CurrentRow.DataBoundItem;
            txtID.Text = Convert.ToString(oCliente.ID);
            txtID.Enabled = false;
            txtNombre.Text = oCliente.Nombre;
            txtApellido.Text = oCliente.Apellido;
            txtDni.Text = Convert.ToString(oCliente.Dni);
        }
    }
}
