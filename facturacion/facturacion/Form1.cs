using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
