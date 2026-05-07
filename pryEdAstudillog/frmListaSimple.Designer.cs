namespace pryEdAstudillog
{
    partial class frmListaSimple
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
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEliminado = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.picListaSimple = new System.Windows.Forms.PictureBox();
            this.grpNuevo.SuspendLayout();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.grpEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picListaSimple)).BeginInit();
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
            this.grpNuevo.Location = new System.Drawing.Point(174, 5);
            this.grpNuevo.Name = "grpNuevo";
            this.grpNuevo.Size = new System.Drawing.Size(185, 173);
            this.grpNuevo.TabIndex = 1;
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
            // grpListado
            // 
            this.grpListado.Controls.Add(this.lstLista);
            this.grpListado.Controls.Add(this.dgvGrilla);
            this.grpListado.Location = new System.Drawing.Point(6, 184);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(538, 219);
            this.grpListado.TabIndex = 4;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(6, 14);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(162, 199);
            this.lstLista.TabIndex = 2;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvGrilla.Location = new System.Drawing.Point(174, 14);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(358, 199);
            this.dgvGrilla.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 114;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Trámite";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // grpEliminado
            // 
            this.grpEliminado.Controls.Add(this.cmbCodigo);
            this.grpEliminado.Controls.Add(this.lblCodigo2);
            this.grpEliminado.Controls.Add(this.btnEliminar);
            this.grpEliminado.Location = new System.Drawing.Point(371, 5);
            this.grpEliminado.Name = "grpEliminado";
            this.grpEliminado.Size = new System.Drawing.Size(173, 173);
            this.grpEliminado.TabIndex = 5;
            this.grpEliminado.TabStop = false;
            this.grpEliminado.Text = "Elemento a Eliminar";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Items.AddRange(new object[] {
            "hola"});
            this.cmbCodigo.Location = new System.Drawing.Point(67, 67);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(100, 21);
            this.cmbCodigo.TabIndex = 16;
            this.cmbCodigo.SelectedIndexChanged += new System.EventHandler(this.cmbCodigo_SelectedIndexChanged);
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(6, 71);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo2.TabIndex = 15;
            this.lblCodigo2.Text = "Código";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(46, 137);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // picListaSimple
            // 
            this.picListaSimple.Image = global::pryEdAstudillog.Properties.Resources._01_ListasSimplementeEnlazadas;
            this.picListaSimple.Location = new System.Drawing.Point(6, 12);
            this.picListaSimple.Name = "picListaSimple";
            this.picListaSimple.Size = new System.Drawing.Size(162, 166);
            this.picListaSimple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picListaSimple.TabIndex = 6;
            this.picListaSimple.TabStop = false;
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 415);
            this.Controls.Add(this.picListaSimple);
            this.Controls.Add(this.grpEliminado);
            this.Controls.Add(this.grpListado);
            this.Controls.Add(this.grpNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Simple";
            this.Load += new System.EventHandler(this.frmListaSimple_Load);
            this.grpNuevo.ResumeLayout(false);
            this.grpNuevo.PerformLayout();
            this.grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.grpEliminado.ResumeLayout(false);
            this.grpEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picListaSimple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNuevo;
        private System.Windows.Forms.TextBox txtCodigo1;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox txtTramite1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox grpEliminado;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox picListaSimple;
    }
}