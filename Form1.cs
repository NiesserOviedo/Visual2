using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form1 : Form
    {

        List<producto> products = new List<producto>();
        int nprod = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ordensalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        //private bool isMenuOpened = false;

        /*public GestionProductos()
        {
            InitializeComponent();
            this.Focus(); // Establece el enfoque en el formulario
            this.KeyPreview = true; // Habilita el evento PreviewKeyDown en el formulario
        }*/


        private void menuArchivo_Click(object sender, EventArgs e)
        {
            this.Focus();

        }

        private void menuArchivo_DropDownOpened(object sender, EventArgs e)
        {
            this.menuArchivo.DropDown.PreviewKeyDown += new PreviewKeyDownEventHandler(menuArchivo_DropDown_PreviewKeyDown);
        }

        private void menuArchivo_DropDown_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.X)
            {
                CerrarAplicacion();
            }
        }

        /*
        private void menuArchivo_DropDownOpened(object sender, EventArgs e)
        {
            this.Focus();
            //isMenuOpened = true;

        }
        */
        private void menuArchivo_DropDownClosed(object sender, EventArgs e)
        {
            this.Focus();
            //isMenuOpened = false;
        }
        
        



        private void ordenSalir_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            CerrarAplicacion();
        }




        private void GestionProductos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.X) // Verifica si la combinación de teclas es "Ctrl + S"
            {
                CerrarAplicacion(); //Cierra la aplicación
            }


        }

        
        private void GestionProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.X) // Verifica si la combinación de teclas es "Ctrl + X"
            {
                //Application.Exit(); //Cierra la aplicación
                CerrarAplicacion();
            }


        }
        

        private void CerrarAplicacion()
        {
            Application.Exit();
        }

        private void menuOperaciones_Click(object sender, EventArgs e)
        {

        }

   


        private void GestionProductos_Load(object sender, EventArgs e)
        {

        }

        private void menuOperaciones_Click_1(object sender, EventArgs e)
        {

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres cerrar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ordenNuevo_Click(object sender, EventArgs e)
        {
            //borro las cajas de texto
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";

            txtNombre.Focus();

            //creo el numero de codigo siguente
            nprod++;
            txtCodigo.Text = nprod.ToString();

            //habilito las opciones de editar las cajas de texto
            txtNombre.ReadOnly = false;
            txtPrecio.ReadOnly = false;
            txtCantidad.ReadOnly = false;

            //habilito las opciones de guardar y cancelar
            ordenGuardar.Enabled = true;
            ordenCancelar.Enabled = true;
            guardar.Enabled = true;
            cancel.Enabled = true;

            //deshabilito la opcione de nuevo y las de desplazamiento por la lista
            ordenNuevo.Enabled = false;
            nuevo.Enabled = false;
            btnPrimero.Enabled = false;
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;
        }

        private void ordenGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtPrecio.Text != "" && txtCantidad.Text != "")
            {
                producto ptemp = new producto();//prod temporal
                bool cnf;
                //Obtener datos:
                ptemp.Codigo = int.Parse(txtCodigo.Text);
                ptemp.Nombre = txtNombre.Text;
                try
                {
                    cnf = true;
                    ptemp.Precio = double.Parse(txtPrecio.Text);
                    ptemp.Cantidad = int.Parse(txtCantidad.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Solo se permiten números en la opcion precios y cantidad!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cnf = false;
                }

                //Guardar datos en la lista y avisar de ello:
                if (cnf)
                {
                    products.Add(ptemp);
                    MessageBox.Show("Producto Guardado ^o^", "Aviso");
                    //habilito las opciones de editar las cajas de texto
                    txtNombre.ReadOnly = true;
                    txtPrecio.ReadOnly = true;
                    txtCantidad.ReadOnly = true;

                    //habilito las opciones de guardar y cancelar
                    ordenGuardar.Enabled = false;
                    ordenCancelar.Enabled = false;
                    guardar.Enabled = false;
                    cancel.Enabled = false;

                    //deshabilito la opcione de nuevo y las de desplazamiento por la lista
                    ordenNuevo.Enabled = true;
                    nuevo.Enabled = true;
                    btnPrimero.Enabled = true;
                    btnAnterior.Enabled = true;
                    btnSiguiente.Enabled = true;
                    btnUltimo.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("Complete la información", "CAution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ordenCancelar_Click(object sender, EventArgs e)
        {
            if (products.Count != 0)
            {
                producto ptemp = products[products.Count - 1];
                txtCodigo.Text = ptemp.Codigo.ToString();
                txtNombre.Text = ptemp.Nombre.ToString();
                txtPrecio.Text = ptemp.Precio.ToString();
                txtCantidad.Text = ptemp.Cantidad.ToString();
            }
            else
            {
                //borro las cajas de texto
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Text = "";
            }

            nprod--;
            //habilito las opciones de editar las cajas de texto
            txtNombre.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            txtCantidad.ReadOnly = true;

            //habilito las opciones de guardar y cancelar
            ordenGuardar.Enabled = false;
            ordenCancelar.Enabled = false;
            guardar.Enabled = false;
            cancel.Enabled = false;

            //deshabilito la opcione de nuevo y las de desplazamiento por la lista
            ordenNuevo.Enabled = true;
            nuevo.Enabled = true;
            btnPrimero.Enabled = true;
            btnAnterior.Enabled = true;
            btnSiguiente.Enabled = true;
            btnUltimo.Enabled = true;
        }

        private void ordenTotalR_Click(object sender, EventArgs e)
        {
            double total = 0;

            foreach (producto v in products)
            {
                total = total + (v.Precio * v.Cantidad);
            }
            MessageBox.Show("El dinero recaudado en total es de: " + total + ".", "Total Recaudado");
        }

        private void barraDeHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (barraDeErramientasToolStripMenuItem.Checked)
            {
                barradeerramientas.Visible = true;
            }
            else
            {
                barradeerramientas.Visible = false;
            }
        }

        private void barraDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (barraDeEstadosToolStripMenuItem.Checked)
            {
                barradeestados.Visible = true;
            }
            else
            {
                barradeestados.Visible = false;
            }
        }

        private void ordenAcercade_Click(object sender, EventArgs e)
        {
            Form about = new AboutBox1();
            about.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void Buscador_Click(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (products.Count != 0)
            {
                bool cnf = false;
                foreach (producto v in products)
                {
                    if (v.Nombre.ToLower() == buscador.Text.ToLower())
                    {
                        cnf = true;
                        txtCodigo.Text = v.Codigo.ToString();
                        txtNombre.Text = v.Nombre.ToString();
                        txtPrecio.Text = v.Precio.ToString();
                        txtCantidad.Text = v.Cantidad.ToString();
                        break;
                    }
                }

                if (!cnf)
                    MessageBox.Show("No se encontró resultados.\n\n  Busque por nombre.", "Busqueda");
            }
            else
                MessageBox.Show("No hay Productos");
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (products.Count != 0)
            {
                producto ptemp = products[0];
                txtCodigo.Text = ptemp.Codigo.ToString();
                txtNombre.Text = ptemp.Nombre.ToString();
                txtPrecio.Text = ptemp.Precio.ToString();
                txtCantidad.Text = ptemp.Cantidad.ToString();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (products.Count != 0)
            {
                try
                {
                    producto ptemp = products[int.Parse(txtCodigo.Text) - 2];
                    txtCodigo.Text = ptemp.Codigo.ToString();
                    txtNombre.Text = ptemp.Nombre.ToString();
                    txtPrecio.Text = ptemp.Precio.ToString();
                    txtCantidad.Text = ptemp.Cantidad.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Primero");
                }

            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (products.Count != 0)
            {
                try
                {
                    producto ptemp = products[int.Parse(txtCodigo.Text)];
                    txtCodigo.Text = ptemp.Codigo.ToString();
                    txtNombre.Text = ptemp.Nombre.ToString();
                    txtPrecio.Text = ptemp.Precio.ToString();
                    txtCantidad.Text = ptemp.Cantidad.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ultimo");
                }

            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (products.Count != 0)
            {
                producto ptemp = products[products.Count - 1];
                txtCodigo.Text = ptemp.Codigo.ToString();
                txtNombre.Text = ptemp.Nombre.ToString();
                txtPrecio.Text = ptemp.Precio.ToString();
                txtCantidad.Text = ptemp.Cantidad.ToString();
            }
        }
    }
}

  

