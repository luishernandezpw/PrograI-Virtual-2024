using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Creado Por: 
//LUIS ENRIQUE HERNANDEZ SANCHEZ.
namespace facturacion {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_facturacionDataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'db_facturacionDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.db_facturacionDataSet.clientes);
            // TODO: esta línea de código carga datos en la tabla 'db_facturacionDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.db_facturacionDataSet.clientes);
            registros();
        }
        private void registros() {
            lblRegistros.Text = (clientesBindingSource.Position + 1) + " de "+ clientesBindingSource.Count;
        }
        private void clientesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e) {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_facturacionDataSet);

        }

        private void btnPrimero_Click(object sender, EventArgs e) {
            clientesBindingSource.MoveFirst();
            registros();
        }

        private void btnAnterior_Click(object sender, EventArgs e) {
            clientesBindingSource.MovePrevious();
            registros();
        }

        private void btnSiguiente_Click(object sender, EventArgs e) {
            clientesBindingSource.MoveNext();
            registros();
        }

        private void btnUltimo_Click(object sender, EventArgs e) {
            clientesBindingSource.MoveLast();
            registros();
        }
        private void estadoCtrls(Boolean estado) {
            grbNavegacion.Enabled = estado;
            btnEliminar.Enabled = estado;
            grbDatos.Enabled = !estado;
            registros();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            if( btnAgregar.Text=="Agregar") {
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                estadoCtrls(false);
                clientesBindingSource.AddNew();//Agrega un nuevo registro.
            } else {//guardar

                clientesBindingSource.EndEdit();
                clientesTableAdapter.Update(this.db_facturacionDataSet);
                estadoCtrls(true);
                btnAgregar.Text = "Agregar";
                btnModificar.Text = "Modificar";
            }
        }
        private void btnModificar_Click(object sender, EventArgs e) {
            if (btnModificar.Text == "Modificar") {
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                estadoCtrls(false);

            } else {//Cancelar
                clientesBindingSource.CancelEdit();
                estadoCtrls(true);
                btnAgregar.Text = "Agregar";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Esta seguro de eliminar a "+ nombreTextBox.Text.Trim()+"?", "Eliminando registro clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes){
                clientesBindingSource.RemoveCurrent();
                clientesTableAdapter.Update(db_facturacionDataSet);
                registros();
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e) {
            BindingSource bs = new BindingSource();
            bs.DataSource = clientesDataGridView.DataSource;
            bs.Filter = "codigo = '"+ txtbuscar.Text +"' or nombre like '%"+ txtbuscar.Text +"%' or dui like '%"+ txtbuscar.Text +"%'";
            clientesDataGridView.DataSource = bs;
        }
    }
}
