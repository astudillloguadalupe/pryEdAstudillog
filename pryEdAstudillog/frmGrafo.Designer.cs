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
            this.treArbol = new System.Windows.Forms.TreeView();
            this.grpNuevo = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grpEliminado = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.radInOrden = new System.Windows.Forms.RadioButton();
            this.radPostOrden = new System.Windows.Forms.RadioButton();
            this.radPreOrden = new System.Windows.Forms.RadioButton();
            this.grpNuevo.SuspendLayout();
            this.grpEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.grpListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // treArbol
            // 
            this.treArbol.Location = new System.Drawing.Point(12, 12);
            this.treArbol.Name = "treArbol";
            this.treArbol.Size = new System.Drawing.Size(151, 175);
            this.treArbol.TabIndex = 0;
            // 
            // grpNuevo
            // 
            this.grpNuevo.Controls.Add(this.txtNombre);
            this.grpNuevo.Controls.Add(this.btnAgregar);
            this.grpNuevo.Controls.Add(this.txtTramite);
            this.grpNuevo.Controls.Add(this.txtCodigo);
            this.grpNuevo.Controls.Add(this.lblTramite);
            this.grpNuevo.Controls.Add(this.lblNombre);
            this.grpNuevo.Controls.Add(this.lblCodigo);
            this.grpNuevo.Location = new System.Drawing.Point(169, 6);
            this.grpNuevo.Name = "grpNuevo";
            this.grpNuevo.Size = new System.Drawing.Size(185, 181);
            this.grpNuevo.TabIndex = 2;
            this.grpNuevo.TabStop = false;
            this.grpNuevo.Text = "Nuevo elemento ";
            this.grpNuevo.Enter += new System.EventHandler(this.grpNuevo_Enter);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(79, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(55, 152);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtTramite
            // 
            this.txtTramite.Enabled = false;
            this.txtTramite.Location = new System.Drawing.Point(79, 108);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 13;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(107, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(72, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(10, 32);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(40, 13);
            this.lblTramite.TabIndex = 10;
            this.lblTramite.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(8, 115);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(42, 13);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Trámite";
            // 
            // grpEliminado
            // 
            this.grpEliminado.Controls.Add(this.cmbCodigo);
            this.grpEliminado.Controls.Add(this.lblCodigo2);
            this.grpEliminado.Controls.Add(this.btnEliminar);
            this.grpEliminado.Location = new System.Drawing.Point(360, 6);
            this.grpEliminado.Name = "grpEliminado";
            this.grpEliminado.Size = new System.Drawing.Size(185, 87);
            this.grpEliminado.TabIndex = 7;
            this.grpEliminado.TabStop = false;
            this.grpEliminado.Text = "Elemento a Eliminar";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(79, 25);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(100, 21);
            this.cmbCodigo.TabIndex = 16;
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(6, 30);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo2.TabIndex = 15;
            this.lblCodigo2.Text = "Código";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(44, 52);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(360, 131);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(185, 34);
            this.btnEquilibrar.TabIndex = 8;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.tramite});
            this.dgvGrilla.Location = new System.Drawing.Point(169, 193);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(376, 198);
            this.dgvGrilla.TabIndex = 9;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Width = 105;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 128;
            // 
            // tramite
            // 
            this.tramite.HeaderText = "Trámite";
            this.tramite.Name = "tramite";
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.radPreOrden);
            this.grpListado.Controls.Add(this.radPostOrden);
            this.grpListado.Controls.Add(this.radInOrden);
            this.grpListado.Location = new System.Drawing.Point(12, 193);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(151, 198);
            this.grpListado.TabIndex = 10;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Listado del arbol";
            // 
            // radInOrden
            // 
            this.radInOrden.AutoSize = true;
            this.radInOrden.Location = new System.Drawing.Point(37, 36);
            this.radInOrden.Name = "radInOrden";
            this.radInOrden.Size = new System.Drawing.Size(66, 17);
            this.radInOrden.TabIndex = 0;
            this.radInOrden.TabStop = true;
            this.radInOrden.Text = "In-Orden";
            this.radInOrden.UseVisualStyleBackColor = true;
            // 
            // radPostOrden
            // 
            this.radPostOrden.AutoSize = true;
            this.radPostOrden.Location = new System.Drawing.Point(37, 148);
            this.radPostOrden.Name = "radPostOrden";
            this.radPostOrden.Size = new System.Drawing.Size(78, 17);
            this.radPostOrden.TabIndex = 1;
            this.radPostOrden.TabStop = true;
            this.radPostOrden.Text = "Post-Orden";
            this.radPostOrden.UseVisualStyleBackColor = true;
            // 
            // radPreOrden
            // 
            this.radPreOrden.AutoSize = true;
            this.radPreOrden.Location = new System.Drawing.Point(37, 90);
            this.radPreOrden.Name = "radPreOrden";
            this.radPreOrden.Size = new System.Drawing.Size(73, 17);
            this.radPreOrden.TabIndex = 2;
            this.radPreOrden.TabStop = true;
            this.radPreOrden.Text = "Pre-Orden";
            this.radPreOrden.UseVisualStyleBackColor = true;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 404);
            this.Controls.Add(this.grpListado);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.grpEliminado);
            this.Controls.Add(this.grpNuevo);
            this.Controls.Add(this.treArbol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafo";
            this.grpNuevo.ResumeLayout(false);
            this.grpNuevo.PerformLayout();
            this.grpEliminado.ResumeLayout(false);
            this.grpEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.grpListado.ResumeLayout(false);
            this.grpListado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treArbol;
        private System.Windows.Forms.GroupBox grpNuevo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grpEliminado;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tramite;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.RadioButton radPreOrden;
        private System.Windows.Forms.RadioButton radPostOrden;
        private System.Windows.Forms.RadioButton radInOrden;
    }
}