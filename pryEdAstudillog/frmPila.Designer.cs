namespace pryEdAstudillog
{
    partial class frmPila
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
            this.grpEliminado = new System.Windows.Forms.GroupBox();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodigoRTA = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombreRTA = new System.Windows.Forms.Label();
            this.lblTramiteRTA = new System.Windows.Forms.Label();
            this.grpNuevo.SuspendLayout();
            this.grpEliminado.SuspendLayout();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.grpNuevo.Location = new System.Drawing.Point(186, 12);
            this.grpNuevo.Name = "grpNuevo";
            this.grpNuevo.Size = new System.Drawing.Size(185, 181);
            this.grpNuevo.TabIndex = 0;
            this.grpNuevo.TabStop = false;
            this.grpNuevo.Text = "Nuevo elemento ";
            // 
            // grpEliminado
            // 
            this.grpEliminado.Controls.Add(this.lblTramiteRTA);
            this.grpEliminado.Controls.Add(this.lblNombreRTA);
            this.grpEliminado.Controls.Add(this.label6);
            this.grpEliminado.Controls.Add(this.label5);
            this.grpEliminado.Controls.Add(this.label4);
            this.grpEliminado.Controls.Add(this.btnEliminar);
            this.grpEliminado.Controls.Add(this.lblCodigoRTA);
            this.grpEliminado.Location = new System.Drawing.Point(377, 12);
            this.grpEliminado.Name = "grpEliminado";
            this.grpEliminado.Size = new System.Drawing.Size(173, 181);
            this.grpEliminado.TabIndex = 0;
            this.grpEliminado.TabStop = false;
            this.grpEliminado.Text = "Elemento Eliminado ";
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.lstPila);
            this.grpListado.Controls.Add(this.dataGridView1);
            this.grpListado.Location = new System.Drawing.Point(12, 199);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(538, 213);
            this.grpListado.TabIndex = 0;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Listado en una Lista y una Grilla";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dataGridView1.Location = new System.Drawing.Point(174, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(358, 186);
            this.dataGridView1.TabIndex = 1;
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(6, 19);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(162, 186);
            this.lstPila.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 181);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 114;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Trámite";
            this.Tramite.Name = "Tramite";
            // 
            // lblCodigoRTA
            // 
            this.lblCodigoRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoRTA.Location = new System.Drawing.Point(96, 25);
            this.lblCodigoRTA.Name = "lblCodigoRTA";
            this.lblCodigoRTA.Size = new System.Drawing.Size(71, 23);
            this.lblCodigoRTA.TabIndex = 6;
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
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(57, 152);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(54, 152);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(107, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(72, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(79, 108);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Código";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Trámite";
            // 
            // lblNombreRTA
            // 
            this.lblNombreRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreRTA.Location = new System.Drawing.Point(67, 67);
            this.lblNombreRTA.Name = "lblNombreRTA";
            this.lblNombreRTA.Size = new System.Drawing.Size(100, 23);
            this.lblNombreRTA.TabIndex = 18;
            // 
            // lblTramiteRTA
            // 
            this.lblTramiteRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteRTA.Location = new System.Drawing.Point(67, 110);
            this.lblTramiteRTA.Name = "lblTramiteRTA";
            this.lblTramiteRTA.Size = new System.Drawing.Size(100, 23);
            this.lblTramiteRTA.TabIndex = 19;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpListado);
            this.Controls.Add(this.grpEliminado);
            this.Controls.Add(this.grpNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pila";
            this.grpNuevo.ResumeLayout(false);
            this.grpNuevo.PerformLayout();
            this.grpEliminado.ResumeLayout(false);
            this.grpEliminado.PerformLayout();
            this.grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNuevo;
        private System.Windows.Forms.GroupBox grpEliminado;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.Label lblCodigoRTA;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTramiteRTA;
        private System.Windows.Forms.Label lblNombreRTA;
    }
}