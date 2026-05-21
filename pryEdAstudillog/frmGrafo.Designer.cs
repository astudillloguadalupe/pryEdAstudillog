namespace pryEdAstudillog
{
    partial class frmGrafo
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
            this.grpListar = new System.Windows.Forms.GroupBox();
            this.btnVerViajes = new System.Windows.Forms.Button();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnListarDeudores = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Córdoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mendoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SantaFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuenosAires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCargadeDatos = new System.Windows.Forms.GroupBox();
            this.lblPrecvio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbDestino1 = new System.Windows.Forms.ComboBox();
            this.cmbOrigen1 = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.cmbDestino2 = new System.Windows.Forms.ComboBox();
            this.cmbOrigen2 = new System.Windows.Forms.ComboBox();
            this.lblPrecioRTA = new System.Windows.Forms.Label();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblDestino2 = new System.Windows.Forms.Label();
            this.lblOrigen2 = new System.Windows.Forms.Label();
            this.picGrafo = new System.Windows.Forms.PictureBox();
            this.lblBorrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grpListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.grpCargadeDatos.SuspendLayout();
            this.grpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListar
            // 
            this.grpListar.Controls.Add(this.btnVerViajes);
            this.grpListar.Controls.Add(this.btnListarOrigenes);
            this.grpListar.Controls.Add(this.comboBox2);
            this.grpListar.Controls.Add(this.btnListarDeudores);
            this.grpListar.Controls.Add(this.comboBox1);
            this.grpListar.Controls.Add(this.lblHasta);
            this.grpListar.Controls.Add(this.lblDesde);
            this.grpListar.Controls.Add(this.dgvLista);
            this.grpListar.Location = new System.Drawing.Point(3, 180);
            this.grpListar.Name = "grpListar";
            this.grpListar.Size = new System.Drawing.Size(629, 275);
            this.grpListar.TabIndex = 0;
            this.grpListar.TabStop = false;
            this.grpListar.Text = "Listar viajes";
            // 
            // btnVerViajes
            // 
            this.btnVerViajes.Location = new System.Drawing.Point(479, 19);
            this.btnVerViajes.Name = "btnVerViajes";
            this.btnVerViajes.Size = new System.Drawing.Size(114, 23);
            this.btnVerViajes.TabIndex = 8;
            this.btnVerViajes.Text = "Ver Todos los viajes";
            this.btnVerViajes.UseVisualStyleBackColor = true;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(390, 19);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(86, 23);
            this.btnListarOrigenes.TabIndex = 7;
            this.btnListarOrigenes.Text = "Listar Origines";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(274, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(101, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // btnListarDeudores
            // 
            this.btnListarDeudores.Location = new System.Drawing.Point(148, 20);
            this.btnListarDeudores.Name = "btnListarDeudores";
            this.btnListarDeudores.Size = new System.Drawing.Size(87, 23);
            this.btnListarDeudores.TabIndex = 5;
            this.btnListarDeudores.Text = "ListarDeudores";
            this.btnListarDeudores.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(237, 24);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(3, 27);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Origen,
            this.Córdoba,
            this.Mendoza,
            this.SantaFe,
            this.BuenosAires,
            this.Salta});
            this.dgvLista.Location = new System.Drawing.Point(6, 56);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(617, 205);
            this.dgvLista.TabIndex = 1;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            // 
            // Córdoba
            // 
            this.Córdoba.HeaderText = "Córdoba";
            this.Córdoba.Name = "Córdoba";
            // 
            // Mendoza
            // 
            this.Mendoza.HeaderText = "Mendoza";
            this.Mendoza.Name = "Mendoza";
            // 
            // SantaFe
            // 
            this.SantaFe.HeaderText = "Santa Fe";
            this.SantaFe.Name = "SantaFe";
            // 
            // BuenosAires
            // 
            this.BuenosAires.HeaderText = "Buenos Aires";
            this.BuenosAires.Name = "BuenosAires";
            // 
            // Salta
            // 
            this.Salta.HeaderText = "Salta";
            this.Salta.Name = "Salta";
            // 
            // grpCargadeDatos
            // 
            this.grpCargadeDatos.Controls.Add(this.lblPrecvio);
            this.grpCargadeDatos.Controls.Add(this.lblDestino);
            this.grpCargadeDatos.Controls.Add(this.lblOrigen1);
            this.grpCargadeDatos.Controls.Add(this.txtPrecio);
            this.grpCargadeDatos.Controls.Add(this.cmbDestino1);
            this.grpCargadeDatos.Controls.Add(this.cmbOrigen1);
            this.grpCargadeDatos.Controls.Add(this.btnCargar);
            this.grpCargadeDatos.Controls.Add(this.btnBorrarTodo);
            this.grpCargadeDatos.Location = new System.Drawing.Point(194, 6);
            this.grpCargadeDatos.Name = "grpCargadeDatos";
            this.grpCargadeDatos.Size = new System.Drawing.Size(212, 168);
            this.grpCargadeDatos.TabIndex = 4;
            this.grpCargadeDatos.TabStop = false;
            this.grpCargadeDatos.Text = "Carga de Datos";
            // 
            // lblPrecvio
            // 
            this.lblPrecvio.AutoSize = true;
            this.lblPrecvio.Location = new System.Drawing.Point(6, 101);
            this.lblPrecvio.Name = "lblPrecvio";
            this.lblPrecvio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecvio.TabIndex = 6;
            this.lblPrecvio.Text = "Precio:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(6, 59);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(46, 13);
            this.lblDestino.TabIndex = 7;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen1
            // 
            this.lblOrigen1.AutoSize = true;
            this.lblOrigen1.Location = new System.Drawing.Point(6, 22);
            this.lblOrigen1.Name = "lblOrigen1";
            this.lblOrigen1.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen1.TabIndex = 8;
            this.lblOrigen1.Text = "Origen:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(69, 94);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // cmbDestino1
            // 
            this.cmbDestino1.FormattingEnabled = true;
            this.cmbDestino1.Location = new System.Drawing.Point(69, 56);
            this.cmbDestino1.Name = "cmbDestino1";
            this.cmbDestino1.Size = new System.Drawing.Size(121, 21);
            this.cmbDestino1.TabIndex = 9;
            // 
            // cmbOrigen1
            // 
            this.cmbOrigen1.FormattingEnabled = true;
            this.cmbOrigen1.Location = new System.Drawing.Point(69, 19);
            this.cmbOrigen1.Name = "cmbOrigen1";
            this.cmbOrigen1.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigen1.TabIndex = 8;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(115, 139);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(22, 139);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarTodo.TabIndex = 7;
            this.btnBorrarTodo.Text = "Borrar";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.lblBorrar);
            this.grpConsulta.Controls.Add(this.btnConsultar);
            this.grpConsulta.Controls.Add(this.cmbDestino2);
            this.grpConsulta.Controls.Add(this.cmbOrigen2);
            this.grpConsulta.Controls.Add(this.lblPrecioRTA);
            this.grpConsulta.Controls.Add(this.lblPrecio2);
            this.grpConsulta.Controls.Add(this.lblDestino2);
            this.grpConsulta.Controls.Add(this.lblOrigen2);
            this.grpConsulta.Location = new System.Drawing.Point(412, 6);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(220, 168);
            this.grpConsulta.TabIndex = 5;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Consulta de Datos";
            // 
            // cmbDestino2
            // 
            this.cmbDestino2.FormattingEnabled = true;
            this.cmbDestino2.Location = new System.Drawing.Point(69, 64);
            this.cmbDestino2.Name = "cmbDestino2";
            this.cmbDestino2.Size = new System.Drawing.Size(121, 21);
            this.cmbDestino2.TabIndex = 11;
            // 
            // cmbOrigen2
            // 
            this.cmbOrigen2.FormattingEnabled = true;
            this.cmbOrigen2.Location = new System.Drawing.Point(69, 24);
            this.cmbOrigen2.Name = "cmbOrigen2";
            this.cmbOrigen2.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigen2.TabIndex = 10;
            // 
            // lblPrecioRTA
            // 
            this.lblPrecioRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrecioRTA.Location = new System.Drawing.Point(69, 101);
            this.lblPrecioRTA.Name = "lblPrecioRTA";
            this.lblPrecioRTA.Size = new System.Drawing.Size(120, 24);
            this.lblPrecioRTA.TabIndex = 6;
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(6, 112);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio2.TabIndex = 7;
            this.lblPrecio2.Text = "Precio:";
            // 
            // lblDestino2
            // 
            this.lblDestino2.AutoSize = true;
            this.lblDestino2.Location = new System.Drawing.Point(6, 67);
            this.lblDestino2.Name = "lblDestino2";
            this.lblDestino2.Size = new System.Drawing.Size(46, 13);
            this.lblDestino2.TabIndex = 8;
            this.lblDestino2.Text = "Destino:";
            // 
            // lblOrigen2
            // 
            this.lblOrigen2.AutoSize = true;
            this.lblOrigen2.Location = new System.Drawing.Point(6, 27);
            this.lblOrigen2.Name = "lblOrigen2";
            this.lblOrigen2.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen2.TabIndex = 9;
            this.lblOrigen2.Text = "Origen:";
            // 
            // picGrafo
            // 
            this.picGrafo.Location = new System.Drawing.Point(3, 12);
            this.picGrafo.Name = "picGrafo";
            this.picGrafo.Size = new System.Drawing.Size(185, 162);
            this.picGrafo.TabIndex = 3;
            this.picGrafo.TabStop = false;
            // 
            // lblBorrar
            // 
            this.lblBorrar.Location = new System.Drawing.Point(115, 139);
            this.lblBorrar.Name = "lblBorrar";
            this.lblBorrar.Size = new System.Drawing.Size(75, 23);
            this.lblBorrar.TabIndex = 11;
            this.lblBorrar.Text = "Borrar";
            this.lblBorrar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(19, 139);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 462);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.grpCargadeDatos);
            this.Controls.Add(this.picGrafo);
            this.Controls.Add(this.grpListar);
            this.Name = "frmGrafo";
            this.Text = "frmGrafo";
            this.grpListar.ResumeLayout(false);
            this.grpListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.grpCargadeDatos.ResumeLayout(false);
            this.grpCargadeDatos.PerformLayout();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.PictureBox picGrafo;
        private System.Windows.Forms.Button btnVerViajes;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnListarDeudores;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox grpCargadeDatos;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Label lblPrecvio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbDestino1;
        private System.Windows.Forms.ComboBox cmbOrigen1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.ComboBox cmbDestino2;
        private System.Windows.Forms.ComboBox cmbOrigen2;
        private System.Windows.Forms.Label lblPrecioRTA;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblDestino2;
        private System.Windows.Forms.Label lblOrigen2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Córdoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mendoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn SantaFe;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuenosAires;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salta;
        private System.Windows.Forms.Button lblBorrar;
        private System.Windows.Forms.Button btnConsultar;
    }
}