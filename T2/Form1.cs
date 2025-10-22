using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2
{
    public partial class T2_FP_G25 : Form
    {
        List<Producto> G25_listproduc = new List<Producto>();
        public T2_FP_G25()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtNombr_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void regis_Click(object sender, EventArgs e)
        {
            try
            {
                //En caso de que no hayan valores en los textbox, se mostrará un mensaje.
                if (string.IsNullOrWhiteSpace(txtNombr.Text) ||
                    string.IsNullOrWhiteSpace(txtCat.Text) ||
                    string.IsNullOrWhiteSpace(txtPrec.Text) ||
                    string.IsNullOrWhiteSpace(txtcant.Text))
                {
                    MessageBox.Show("Por favor, complete los campos de registro.", "Error de validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Esta variable se marca como false para que al momento de registrarse, el valor cambie a true 
                bool G25_eDuplicado = false;
                foreach (Producto prodexistente in G25_listproduc)
                {
                    if (prodexistente.G25_Nombre.Equals(txtNombr.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        //Al cambiar de valor a true, no se pueden generar productos con el mismo nombre. Esto para evitar duplicados en la lista. 
                        G25_eDuplicado = true;
                        break;
                    }
                }
                if (G25_eDuplicado)
                {
                    MessageBox.Show("Ya existe un producto con ese nombre.", "Error de duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Producto G25_nuevoProd = new Producto
                {
                    G25_Nombre = txtNombr.Text,
                    G25_Categoria = txtCat.Text,
                    G25_Precio = decimal.Parse(txtPrec.Text),
                    G25_Cantidad = int.Parse(txtcant.Text)
                };
                G25_listproduc.Add(G25_nuevoProd);
                actualizListBox();
                txtNombr.Clear();
                txtCat.Clear();
                txtPrec.Clear();
                txtcant.Clear();

                txtNombr.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("El precio y cantidad deben ser números válidos, intente registrar de nuevo.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void busc_Click(object sender, EventArgs e)
        {
            string G25_prodabuscar = txtbuscar.Text;
            if (string.IsNullOrWhiteSpace(G25_prodabuscar))
            {
                MessageBox.Show("Ingrese un nombre para buscar", "Error de Búsqueda.");
                return;
            }
            Producto G25_prodencontrado = null;
            foreach (Producto prodactual in G25_listproduc)
            {
                if (prodactual.G25_Nombre.Equals(G25_prodabuscar, StringComparison.OrdinalIgnoreCase))
                {
                    G25_prodencontrado = prodactual; break;
                }
            }
            if (G25_prodencontrado != null)
            {
                listaproductos.SelectedItem = G25_prodencontrado;
                MessageBox.Show("El producto ha sido encontrado!", "Búsqueda exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("El producto no se encuentra en la lista.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            string G25_categ = txtcater.Text;
            if (string.IsNullOrWhiteSpace(G25_categ))
            {
                MessageBox.Show("Por favor ingrese una categoría para calcular el stock total.", "Error!");
                return;
            }
            else
            {
                int G25_sumastock = sumastock(G25_categ, G25_listproduc);
                lblsumatot.Text = G25_sumastock.ToString();
            }
        }
        private int sumastock(string categ, List<Producto> productos)
        {
            if (productos.Count == 0)
            {
                return 0;
            }
            Producto G25_primerprod = productos[0];
            List<Producto> G25_products = new List<Producto>(productos);
            G25_products.RemoveAt(0);
            int G25_stockprimerprod = 0;
            if (G25_primerprod.G25_Categoria.Equals(categ, StringComparison.OrdinalIgnoreCase))
            {
                G25_stockprimerprod = G25_primerprod.G25_Cantidad;
            }
            return G25_stockprimerprod + sumastock(categ, G25_products);
        }

        private void btnascend_Click(object sender, EventArgs e)
        {
            ordenalistaporprecio(true); // true para que se ordene ascendente
            actualizListBox();
        }

        private void btndescend_Click(object sender, EventArgs e)
        {
            ordenalistaporprecio(false); // false para que se ordene de forma descendente
            actualizListBox();
        }
        private void actualizListBox()
        {
            listaproductos.DataSource = null;
            listaproductos.DataSource = G25_listproduc;
        }
        private void ordenalistaporprecio(bool G25_ascendente)
        {
            int n = G25_listproduc.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    bool G25_nS = false;
                    if (G25_ascendente)
                    {
                        if (G25_listproduc[j].G25_Precio > G25_listproduc[j + 1].G25_Precio)
                            G25_nS = true;
                    }
                    else
                    {
                        if (G25_listproduc[j].G25_Precio < G25_listproduc[j + 1].G25_Precio)
                            G25_nS = true;
                    }
                    if (G25_nS)
                    {
                        Producto G25_temp = G25_listproduc[j];
                        G25_listproduc[j] = G25_listproduc[j + 1];
                        G25_listproduc[j + 1] = G25_temp;
                    }
                }
            }
        }

        private void lblsumatot_Click(object sender, EventArgs e)
        {

        }
    }
}
