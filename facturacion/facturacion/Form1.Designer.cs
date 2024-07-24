namespace facturacion {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label duiLabel;
            this.db_facturacionDataSet = new facturacion.db_facturacionDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new facturacion.db_facturacionDataSetTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new facturacion.db_facturacionDataSetTableAdapters.TableAdapterManager();
            this.idClienteLabel1 = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.duiTextBox = new System.Windows.Forms.TextBox();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            duiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_facturacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.grbNavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(25, 13);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(21, 13);
            idClienteLabel.TabIndex = 1;
            idClienteLabel.Text = "ID:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoLabel.Location = new System.Drawing.Point(24, 59);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(85, 20);
            codigoLabel.TabIndex = 3;
            codigoLabel.Text = "CODIGO:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(24, 98);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(90, 20);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "NOMBRE:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(24, 144);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(113, 20);
            direccionLabel.TabIndex = 7;
            direccionLabel.Text = "DIRECCION:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(24, 186);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(107, 20);
            telefonoLabel.TabIndex = 9;
            telefonoLabel.Text = "TELEFONO:";
            // 
            // duiLabel
            // 
            duiLabel.AutoSize = true;
            duiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            duiLabel.Location = new System.Drawing.Point(24, 229);
            duiLabel.Name = "duiLabel";
            duiLabel.Size = new System.Drawing.Size(46, 20);
            duiLabel.TabIndex = 11;
            duiLabel.Text = "DUI:";
            // 
            // db_facturacionDataSet
            // 
            this.db_facturacionDataSet.DataSetName = "db_facturacionDataSet";
            this.db_facturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.db_facturacionDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = facturacion.db_facturacionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idClienteLabel1
            // 
            this.idClienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "idCliente", true));
            this.idClienteLabel1.Location = new System.Drawing.Point(143, 13);
            this.idClienteLabel1.Name = "idClienteLabel1";
            this.idClienteLabel1.Size = new System.Drawing.Size(100, 23);
            this.idClienteLabel1.TabIndex = 2;
            this.idClienteLabel1.Text = "label1";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(143, 59);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(110, 20);
            this.codigoTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(143, 98);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(304, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(143, 144);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.ReadOnly = true;
            this.direccionTextBox.Size = new System.Drawing.Size(382, 20);
            this.direccionTextBox.TabIndex = 8;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(143, 186);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.ReadOnly = true;
            this.telefonoTextBox.Size = new System.Drawing.Size(136, 20);
            this.telefonoTextBox.TabIndex = 10;
            // 
            // duiTextBox
            // 
            this.duiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "dui", true));
            this.duiTextBox.Location = new System.Drawing.Point(143, 229);
            this.duiTextBox.Name = "duiTextBox";
            this.duiTextBox.ReadOnly = true;
            this.duiTextBox.Size = new System.Drawing.Size(136, 20);
            this.duiTextBox.TabIndex = 12;
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblRegistros);
            this.grbNavegacion.Controls.Add(this.btnUltimo);
            this.grbNavegacion.Controls.Add(this.btnSiguiente);
            this.grbNavegacion.Controls.Add(this.btnAnterior);
            this.grbNavegacion.Controls.Add(this.btnPrimero);
            this.grbNavegacion.Location = new System.Drawing.Point(28, 269);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(333, 58);
            this.grbNavegacion.TabIndex = 13;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // btnPrimero
            // 
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(6, 17);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(44, 35);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "|<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(56, 17);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(44, 35);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(283, 17);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(44, 35);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(233, 17);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(44, 35);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "idCliente", true));
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(104, 23);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(123, 23);
            this.lblRegistros.TabIndex = 14;
            this.lblRegistros.Text = "x de n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteLabel1);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(duiLabel);
            this.Controls.Add(this.duiTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_facturacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.grbNavegacion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_facturacionDataSet db_facturacionDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private db_facturacionDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private db_facturacionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idClienteLabel1;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox duiTextBox;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblRegistros;
    }
}

