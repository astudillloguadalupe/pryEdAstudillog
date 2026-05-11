namespace pryEdAstudillog
{
    partial class frmCola
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
            this.grpNuevo = new System.Windows.Forms.GroupBox();
            this.txtCodigo1 = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtTramite1 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.grpEliminado = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTra = new System.Windows.Forms.Label();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.picCola = new System.Windows.Forms.PictureBox();
            this.lstListar = new System.Windows.Forms.ListBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpListadoGrilla = new System.Windows.Forms.GroupBox();
            this.grpNuevo.SuspendLayout();
            this.grpEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.grpListadoGrilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNuevo
            // 
            this.grpNuevo.Controls.Add(this.txtCodigo1);
            this.grpNuevo.Controls.Add(this.txtNombre1);
            this.grpNuevo.Controls.Add(this.txtTramite1);
            this.grpNuevo.Controls.Add(this.btnAgregar);
            this.grpNuevo.Controls.Add(this.lblTramite1);
            this.grpNuevo.Controls.Add(this.lblNombre1);
            this.grpNuevo.Controls.Add(this.lblCodigo1);
            this.grpNuevo.Location = new System.Drawing.Point(172, 12);
            this.grpNuevo.Name = "grpNuevo";
            this.grpNuevo.Size = new System.Drawing.Size(185, 166);
            this.grpNuevo.TabIndex = 0;
            this.grpNuevo.TabStop = false;
            this.grpNuevo.Text = "Nuevo Elemento";
            // 
            // txtCodigo1
            // 
            this.txtCodigo1.Location = new System.Drawing.Point(93, 24);
            this.txtCodigo1.Name = "txtCodigo1";
            this.txtCodigo1.Size = new System.Drawing.Size(83, 20);
            this.txtCodigo1.TabIndex = 6;
            this.txtCodigo1.TextChanged += new System.EventHandler(this.txtCodigo1_TextChanged);
            // 
            // txtNombre1
            // 
            this.txtNombre1.Enabled = false;
            this.txtNombre1.Location = new System.Drawing.Point(76, 64);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(100, 20);
            this.txtNombre1.TabIndex = 5;
            this.txtNombre1.TextChanged += new System.EventHandler(this.txtNombre1_TextChanged);
            // 
            // txtTramite1
            // 
            this.txtTramite1.Enabled = false;
            this.txtTramite1.Location = new System.Drawing.Point(73, 103);
            this.txtTramite1.Name = "txtTramite1";
            this.txtTramite1.Size = new System.Drawing.Size(103, 20);
            this.txtTramite1.TabIndex = 4;
            this.txtTramite1.TextChanged += new System.EventHandler(this.txtTramite1_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(42, 137);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramite1
            // 
            this.lblTramite1.AutoSize = true;
            this.lblTramite1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite1.Location = new System.Drawing.Point(12, 106);
            this.lblTramite1.Name = "lblTramite1";
            this.lblTramite1.Size = new System.Drawing.Size(52, 15);
            this.lblTramite1.TabIndex = 2;
            this.lblTramite1.Text = "Trámite:";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre1.Location = new System.Drawing.Point(10, 67);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(55, 15);
            this.lblNombre1.TabIndex = 1;
            this.lblNombre1.Text = "Nombre:";
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo1.Location = new System.Drawing.Point(10, 31);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(49, 15);
            this.lblCodigo1.TabIndex = 0;
            this.lblCodigo1.Text = "Código:";
            // 
            // grpEliminado
            // 
            this.grpEliminado.Controls.Add(this.btnEliminar);
            this.grpEliminado.Controls.Add(this.lblCod);
            this.grpEliminado.Controls.Add(this.lblNom);
            this.grpEliminado.Controls.Add(this.lblTra);
            this.grpEliminado.Controls.Add(this.lblTramite2);
            this.grpEliminado.Controls.Add(this.lblNombre2);
            this.grpEliminado.Controls.Add(this.lblCodigo2);
            this.grpEliminado.Location = new System.Drawing.Point(363, 12);
            this.grpEliminado.Name = "grpEliminado";
            this.grpEliminado.Size = new System.Drawing.Size(185, 166);
            this.grpEliminado.TabIndex = 0;
            this.grpEliminado.TabStop = false;
            this.grpEliminado.Text = "Elemento Eliminado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(42, 137);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCod
            // 
            this.lblCod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCod.Location = new System.Drawing.Point(76, 24);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(100, 23);
            this.lblCod.TabIndex = 12;
            // 
            // lblNom
            // 
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNom.Location = new System.Drawing.Point(76, 61);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(100, 23);
            this.lblNom.TabIndex = 11;
            // 
            // lblTra
            // 
            this.lblTra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTra.Location = new System.Drawing.Point(76, 100);
            this.lblTra.Name = "lblTra";
            this.lblTra.Size = new System.Drawing.Size(100, 23);
            this.lblTra.TabIndex = 10;
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite2.Location = new System.Drawing.Point(6, 106);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(52, 15);
            this.lblTramite2.TabIndex = 7;
            this.lblTramite2.Text = "Trámite:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.Location = new System.Drawing.Point(6, 64);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(55, 15);
            this.lblNombre2.TabIndex = 8;
            this.lblNombre2.Text = "Nómbre:";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo2.Location = new System.Drawing.Point(6, 27);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(49, 15);
            this.lblCodigo2.TabIndex = 9;
            this.lblCodigo2.Text = "Código:";
            // 
            // picCola
            // 
            this.picCola.Image = global::pryEdAstudillog.Properties.Resources.cola;
            this.picCola.Location = new System.Drawing.Point(13, 12);
            this.picCola.Name = "picCola";
            this.picCola.Size = new System.Drawing.Size(153, 166);
            this.picCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCola.TabIndex = 0;
            this.picCola.TabStop = false;
            // 
            // lstListar
            // 
            this.lstListar.FormattingEnabled = true;
            this.lstListar.Location = new System.Drawing.Point(6, 19);
            this.lstListar.Name = "lstListar";
            this.lstListar.Size = new System.Drawing.Size(153, 173);
            this.lstListar.TabIndex = 1;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Trámite});
            this.dgvGrilla.Location = new System.Drawing.Point(165, 19);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(367, 173);
            this.dgvGrilla.TabIndex = 2;
            this.dgvGrilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 75;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 157;
            // 
            // Trámite
            // 
            this.Trámite.HeaderText = "Trámite";
            this.Trámite.Name = "Trámite";
            this.Trámite.ReadOnly = true;
            this.Trámite.Width = 90;
            // 
            // grpListadoGrilla
            // 
            this.grpListadoGrilla.Controls.Add(this.dgvGrilla);
            this.grpListadoGrilla.Controls.Add(this.lstListar);
            this.grpListadoGrilla.Location = new System.Drawing.Point(7, 184);
            this.grpListadoGrilla.Name = "grpListadoGrilla";
            this.grpListadoGrilla.Size = new System.Drawing.Size(543, 201);
            this.grpListadoGrilla.TabIndex = 3;
            this.grpListadoGrilla.TabStop = false;
            this.grpListadoGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(562, 397);
            this.Controls.Add(this.grpListadoGrilla);
            this.Controls.Add(this.picCola);
            this.Controls.Add(this.grpEliminado);
            this.Controls.Add(this.grpNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            this.grpNuevo.ResumeLayout(false);
            this.grpNuevo.PerformLayout();
            this.grpEliminado.ResumeLayout(false);
            this.grpEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.grpListadoGrilla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNuevo;
        private System.Windows.Forms.GroupBox grpEliminado;
        private System.Windows.Forms.PictureBox picCola;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.ListBox lstListar;
        private System.Windows.Forms.GroupBox grpListadoGrilla;
        private System.Windows.Forms.TextBox txtCodigo1;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox txtTramite1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
    }
}