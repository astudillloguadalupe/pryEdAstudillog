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
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbDestino2 = new System.Windows.Forms.ComboBox();
            this.cmbOrigen2 = new System.Windows.Forms.ComboBox();
            this.lblPrecioRTA = new System.Windows.Forms.Label();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblDestino2 = new System.Windows.Forms.Label();
            this.lblOrigen2 = new System.Windows.Forms.Label();
            this.picGrafo = new System.Windows.Forms.PictureBox();
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
            this.grpListar.Controls.Add(this.cmbHasta);
            this.grpListar.Controls.Add(this.btnListarDestinos);
            this.grpListar.Controls.Add(this.cmbDesde);
            this.grpListar.Controls.Add(this.lblHasta);
            this.grpListar.Controls.Add(this.lblDesde);
            this.grpListar.Controls.Add(this.dgvLista);
            this.grpListar.Location = new System.Drawing.Point(4, 222);
            this.grpListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpListar.Name = "grpListar";
            this.grpListar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpListar.Size = new System.Drawing.Size(839, 338);
            this.grpListar.TabIndex = 0;
            this.grpListar.TabStop = false;
            this.grpListar.Text = "Listar viajes";
            // 
            // btnVerViajes
            // 
            this.btnVerViajes.Location = new System.Drawing.Point(639, 23);
            this.btnVerViajes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerViajes.Name = "btnVerViajes";
            this.btnVerViajes.Size = new System.Drawing.Size(152, 28);
            this.btnVerViajes.TabIndex = 8;
            this.btnVerViajes.Text = "Ver Todos los viajes";
            this.btnVerViajes.UseVisualStyleBackColor = true;
            this.btnVerViajes.Click += new System.EventHandler(this.btnVerViajes_Click);
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(520, 23);
            this.btnListarOrigenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(115, 28);
            this.btnListarOrigenes.TabIndex = 7;
            this.btnListarOrigenes.Text = "Listar Origines";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            this.btnListarOrigenes.Click += new System.EventHandler(this.btnListarOrigenes_Click);
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(365, 25);
            this.cmbHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(133, 24);
            this.cmbHasta.TabIndex = 6;
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(197, 25);
            this.btnListarDestinos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(116, 28);
            this.btnListarDestinos.TabIndex = 5;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            this.btnListarDestinos.Click += new System.EventHandler(this.btnListarDestinos_Click);
            // 
            // cmbDesde
            // 
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(55, 27);
            this.cmbDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(133, 24);
            this.cmbDesde.TabIndex = 4;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(316, 30);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(46, 16);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(4, 33);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(51, 16);
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
            this.dgvLista.Location = new System.Drawing.Point(8, 69);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.Size = new System.Drawing.Size(823, 262);
            this.dgvLista.TabIndex = 1;
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Origen";
            this.Origen.MinimumWidth = 6;
            this.Origen.Name = "Origen";
            this.Origen.Width = 125;
            // 
            // Córdoba
            // 
            this.Córdoba.HeaderText = "Córdoba";
            this.Córdoba.MinimumWidth = 6;
            this.Córdoba.Name = "Córdoba";
            this.Córdoba.Width = 125;
            // 
            // Mendoza
            // 
            this.Mendoza.HeaderText = "Mendoza";
            this.Mendoza.MinimumWidth = 6;
            this.Mendoza.Name = "Mendoza";
            this.Mendoza.Width = 125;
            // 
            // SantaFe
            // 
            this.SantaFe.HeaderText = "Santa Fe";
            this.SantaFe.MinimumWidth = 6;
            this.SantaFe.Name = "SantaFe";
            this.SantaFe.Width = 125;
            // 
            // BuenosAires
            // 
            this.BuenosAires.HeaderText = "Buenos Aires";
            this.BuenosAires.MinimumWidth = 6;
            this.BuenosAires.Name = "BuenosAires";
            this.BuenosAires.Width = 125;
            // 
            // Salta
            // 
            this.Salta.HeaderText = "Salta";
            this.Salta.MinimumWidth = 6;
            this.Salta.Name = "Salta";
            this.Salta.Width = 125;
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
            this.grpCargadeDatos.Location = new System.Drawing.Point(259, 7);
            this.grpCargadeDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCargadeDatos.Name = "grpCargadeDatos";
            this.grpCargadeDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCargadeDatos.Size = new System.Drawing.Size(283, 207);
            this.grpCargadeDatos.TabIndex = 4;
            this.grpCargadeDatos.TabStop = false;
            this.grpCargadeDatos.Text = "Carga de Datos";
            // 
            // lblPrecvio
            // 
            this.lblPrecvio.AutoSize = true;
            this.lblPrecvio.Location = new System.Drawing.Point(8, 124);
            this.lblPrecvio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecvio.Name = "lblPrecvio";
            this.lblPrecvio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecvio.TabIndex = 6;
            this.lblPrecvio.Text = "Precio:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(8, 73);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(56, 16);
            this.lblDestino.TabIndex = 7;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen1
            // 
            this.lblOrigen1.AutoSize = true;
            this.lblOrigen1.Location = new System.Drawing.Point(8, 27);
            this.lblOrigen1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen1.Name = "lblOrigen1";
            this.lblOrigen1.Size = new System.Drawing.Size(50, 16);
            this.lblOrigen1.TabIndex = 8;
            this.lblOrigen1.Text = "Origen:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(92, 116);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(160, 22);
            this.txtPrecio.TabIndex = 10;
            // 
            // cmbDestino1
            // 
            this.cmbDestino1.FormattingEnabled = true;
            this.cmbDestino1.Location = new System.Drawing.Point(92, 69);
            this.cmbDestino1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDestino1.Name = "cmbDestino1";
            this.cmbDestino1.Size = new System.Drawing.Size(160, 24);
            this.cmbDestino1.TabIndex = 9;
            // 
            // cmbOrigen1
            // 
            this.cmbOrigen1.FormattingEnabled = true;
            this.cmbOrigen1.Location = new System.Drawing.Point(92, 23);
            this.cmbOrigen1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOrigen1.Name = "cmbOrigen1";
            this.cmbOrigen1.Size = new System.Drawing.Size(160, 24);
            this.cmbOrigen1.TabIndex = 8;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(153, 171);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 28);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(29, 171);
            this.btnBorrarTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(100, 28);
            this.btnBorrarTodo.TabIndex = 7;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.btnBorrar);
            this.grpConsulta.Controls.Add(this.btnConsultar);
            this.grpConsulta.Controls.Add(this.cmbDestino2);
            this.grpConsulta.Controls.Add(this.cmbOrigen2);
            this.grpConsulta.Controls.Add(this.lblPrecioRTA);
            this.grpConsulta.Controls.Add(this.lblPrecio2);
            this.grpConsulta.Controls.Add(this.lblDestino2);
            this.grpConsulta.Controls.Add(this.lblOrigen2);
            this.grpConsulta.Location = new System.Drawing.Point(549, 7);
            this.grpConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConsulta.Size = new System.Drawing.Size(293, 207);
            this.grpConsulta.TabIndex = 5;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Consulta de Datos";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(153, 171);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 28);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(25, 171);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 28);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbDestino2
            // 
            this.cmbDestino2.FormattingEnabled = true;
            this.cmbDestino2.Location = new System.Drawing.Point(92, 79);
            this.cmbDestino2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDestino2.Name = "cmbDestino2";
            this.cmbDestino2.Size = new System.Drawing.Size(160, 24);
            this.cmbDestino2.TabIndex = 11;
            // 
            // cmbOrigen2
            // 
            this.cmbOrigen2.FormattingEnabled = true;
            this.cmbOrigen2.Location = new System.Drawing.Point(92, 30);
            this.cmbOrigen2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOrigen2.Name = "cmbOrigen2";
            this.cmbOrigen2.Size = new System.Drawing.Size(160, 24);
            this.cmbOrigen2.TabIndex = 10;
            // 
            // lblPrecioRTA
            // 
            this.lblPrecioRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrecioRTA.Location = new System.Drawing.Point(92, 124);
            this.lblPrecioRTA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioRTA.Name = "lblPrecioRTA";
            this.lblPrecioRTA.Size = new System.Drawing.Size(160, 30);
            this.lblPrecioRTA.TabIndex = 6;
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(8, 138);
            this.lblPrecio2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio2.TabIndex = 7;
            this.lblPrecio2.Text = "Precio:";
            // 
            // lblDestino2
            // 
            this.lblDestino2.AutoSize = true;
            this.lblDestino2.Location = new System.Drawing.Point(8, 82);
            this.lblDestino2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino2.Name = "lblDestino2";
            this.lblDestino2.Size = new System.Drawing.Size(56, 16);
            this.lblDestino2.TabIndex = 8;
            this.lblDestino2.Text = "Destino:";
            // 
            // lblOrigen2
            // 
            this.lblOrigen2.AutoSize = true;
            this.lblOrigen2.Location = new System.Drawing.Point(8, 33);
            this.lblOrigen2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen2.Name = "lblOrigen2";
            this.lblOrigen2.Size = new System.Drawing.Size(50, 16);
            this.lblOrigen2.TabIndex = 9;
            this.lblOrigen2.Text = "Origen:";
            // 
            // picGrafo
            // 
            this.picGrafo.Image = global::pryEdAstudillog.Properties.Resources.Grafo;
            this.picGrafo.Location = new System.Drawing.Point(4, 15);
            this.picGrafo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picGrafo.Name = "picGrafo";
            this.picGrafo.Size = new System.Drawing.Size(247, 199);
            this.picGrafo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGrafo.TabIndex = 3;
            this.picGrafo.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 569);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.grpCargadeDatos);
            this.Controls.Add(this.picGrafo);
            this.Controls.Add(this.grpListar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
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
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.ComboBox cmbDesde;
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
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConsultar;
    }
}