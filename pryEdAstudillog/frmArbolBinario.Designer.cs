namespace pryEdAstudillog
{
    partial class frmArbolBinario
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
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.radPostOrden = new System.Windows.Forms.RadioButton();
            this.radPreOrden = new System.Windows.Forms.RadioButton();
            this.radInOrden = new System.Windows.Forms.RadioButton();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.trvArbol = new System.Windows.Forms.TreeView();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.grpNuevo.SuspendLayout();
            this.grpEliminado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.radPostOrden);
            this.grpListado.Controls.Add(this.radPreOrden);
            this.grpListado.Controls.Add(this.radInOrden);
            this.grpListado.Controls.Add(this.dgvGrilla);
            this.grpListado.Location = new System.Drawing.Point(4, 238);
            this.grpListado.Margin = new System.Windows.Forms.Padding(4);
            this.grpListado.Name = "grpListado";
            this.grpListado.Padding = new System.Windows.Forms.Padding(4);
            this.grpListado.Size = new System.Drawing.Size(729, 278);
            this.grpListado.TabIndex = 9;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Listado de Arbol";
            // 
            // radPostOrden
            // 
            this.radPostOrden.AutoSize = true;
            this.radPostOrden.Location = new System.Drawing.Point(27, 202);
            this.radPostOrden.Margin = new System.Windows.Forms.Padding(4);
            this.radPostOrden.Name = "radPostOrden";
            this.radPostOrden.Size = new System.Drawing.Size(96, 20);
            this.radPostOrden.TabIndex = 13;
            this.radPostOrden.TabStop = true;
            this.radPostOrden.Text = "Post-Orden";
            this.radPostOrden.UseVisualStyleBackColor = true;
            this.radPostOrden.CheckedChanged += new System.EventHandler(this.radPostOrden_CheckedChanged);
            // 
            // radPreOrden
            // 
            this.radPreOrden.AutoSize = true;
            this.radPreOrden.Location = new System.Drawing.Point(27, 127);
            this.radPreOrden.Margin = new System.Windows.Forms.Padding(4);
            this.radPreOrden.Name = "radPreOrden";
            this.radPreOrden.Size = new System.Drawing.Size(90, 20);
            this.radPreOrden.TabIndex = 14;
            this.radPreOrden.TabStop = true;
            this.radPreOrden.Text = "Pre-Orden";
            this.radPreOrden.UseVisualStyleBackColor = true;
            this.radPreOrden.CheckedChanged += new System.EventHandler(this.radPreOrden_CheckedChanged);
            // 
            // radInOrden
            // 
            this.radInOrden.AutoSize = true;
            this.radInOrden.Location = new System.Drawing.Point(27, 54);
            this.radInOrden.Margin = new System.Windows.Forms.Padding(4);
            this.radInOrden.Name = "radInOrden";
            this.radInOrden.Size = new System.Drawing.Size(79, 20);
            this.radInOrden.TabIndex = 15;
            this.radInOrden.TabStop = true;
            this.radInOrden.Text = "In-Orden";
            this.radInOrden.UseVisualStyleBackColor = true;
            this.radInOrden.CheckedChanged += new System.EventHandler(this.radInOrden_CheckedChanged);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.tramite});
            this.dgvGrilla.Location = new System.Drawing.Point(232, 23);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.RowHeadersWidth = 51;
            this.dgvGrilla.Size = new System.Drawing.Size(489, 244);
            this.dgvGrilla.TabIndex = 1;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.Width = 105;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 120;
            // 
            // tramite
            // 
            this.tramite.HeaderText = "Trámite";
            this.tramite.MinimumWidth = 6;
            this.tramite.Name = "tramite";
            this.tramite.Width = 125;
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
            this.grpNuevo.Location = new System.Drawing.Point(236, 7);
            this.grpNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.grpNuevo.Name = "grpNuevo";
            this.grpNuevo.Padding = new System.Windows.Forms.Padding(4);
            this.grpNuevo.Size = new System.Drawing.Size(247, 223);
            this.grpNuevo.TabIndex = 10;
            this.grpNuevo.TabStop = false;
            this.grpNuevo.Text = "Nuevo elemento ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 82);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(76, 187);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(105, 133);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(132, 22);
            this.txtTramite.TabIndex = 13;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(143, 31);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(95, 22);
            this.txtCodigo.TabIndex = 10;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(13, 39);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(51, 16);
            this.lblTramite.TabIndex = 10;
            this.lblTramite.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 91);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(11, 142);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 16);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Trámite";
            // 
            // grpEliminado
            // 
            this.grpEliminado.Controls.Add(this.cmbCodigo);
            this.grpEliminado.Controls.Add(this.lblCodigo2);
            this.grpEliminado.Controls.Add(this.btnEliminar);
            this.grpEliminado.Location = new System.Drawing.Point(487, 7);
            this.grpEliminado.Margin = new System.Windows.Forms.Padding(4);
            this.grpEliminado.Name = "grpEliminado";
            this.grpEliminado.Padding = new System.Windows.Forms.Padding(4);
            this.grpEliminado.Size = new System.Drawing.Size(247, 148);
            this.grpEliminado.TabIndex = 11;
            this.grpEliminado.TabStop = false;
            this.grpEliminado.Text = "Elemento a Eliminar";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(105, 39);
            this.cmbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(132, 24);
            this.cmbCodigo.TabIndex = 16;
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(8, 43);
            this.lblCodigo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo2.TabIndex = 15;
            this.lblCodigo2.Text = "Código";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(57, 91);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 28);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(491, 187);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(247, 36);
            this.btnEquilibrar.TabIndex = 12;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // trvArbol
            // 
            this.trvArbol.Location = new System.Drawing.Point(4, 7);
            this.trvArbol.Margin = new System.Windows.Forms.Padding(4);
            this.trvArbol.Name = "trvArbol";
            this.trvArbol.Size = new System.Drawing.Size(223, 222);
            this.trvArbol.TabIndex = 2;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 519);
            this.Controls.Add(this.trvArbol);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.grpEliminado);
            this.Controls.Add(this.grpNuevo);
            this.Controls.Add(this.grpListado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.grpListado.ResumeLayout(false);
            this.grpListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.grpNuevo.ResumeLayout(false);
            this.grpNuevo.PerformLayout();
            this.grpEliminado.ResumeLayout(false);
            this.grpEliminado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tramite;
        private System.Windows.Forms.GroupBox grpNuevo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.RadioButton radPostOrden;
        private System.Windows.Forms.RadioButton radPreOrden;
        private System.Windows.Forms.RadioButton radInOrden;
        private System.Windows.Forms.GroupBox grpEliminado;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.TreeView trvArbol;
    }
}