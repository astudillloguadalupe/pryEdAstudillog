namespace pryEdAstudillog
{
    partial class frmBdOperaciones
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
            this.grbAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.grbSeleccion = new System.Windows.Forms.GroupBox();
            this.btnSelecConv = new System.Windows.Forms.Button();
            this.btnSelecMulti = new System.Windows.Forms.Button();
            this.btnSelecSimple = new System.Windows.Forms.Button();
            this.grbProyeccion = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProyMulti = new System.Windows.Forms.Button();
            this.btnProySimple = new System.Windows.Forms.Button();
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.grbAlgebraicas.SuspendLayout();
            this.grbSeleccion.SuspendLayout();
            this.grbProyeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAlgebraicas
            // 
            this.grbAlgebraicas.Controls.Add(this.btnDiferencia);
            this.grbAlgebraicas.Controls.Add(this.btnInterseccion);
            this.grbAlgebraicas.Controls.Add(this.btnUnion);
            this.grbAlgebraicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAlgebraicas.Location = new System.Drawing.Point(683, 370);
            this.grbAlgebraicas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAlgebraicas.Name = "grbAlgebraicas";
            this.grbAlgebraicas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAlgebraicas.Size = new System.Drawing.Size(284, 169);
            this.grbAlgebraicas.TabIndex = 8;
            this.grbAlgebraicas.TabStop = false;
            this.grbAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(15, 135);
            this.btnDiferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(251, 28);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(15, 85);
            this.btnInterseccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(251, 28);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(15, 39);
            this.btnUnion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(251, 28);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // grbSeleccion
            // 
            this.grbSeleccion.Controls.Add(this.btnSelecConv);
            this.grbSeleccion.Controls.Add(this.btnSelecMulti);
            this.grbSeleccion.Controls.Add(this.btnSelecSimple);
            this.grbSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSeleccion.Location = new System.Drawing.Point(353, 370);
            this.grbSeleccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSeleccion.Name = "grbSeleccion";
            this.grbSeleccion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSeleccion.Size = new System.Drawing.Size(303, 169);
            this.grbSeleccion.TabIndex = 7;
            this.grbSeleccion.TabStop = false;
            this.grbSeleccion.Text = "Operaciones de Selección - WHERE";
            // 
            // btnSelecConv
            // 
            this.btnSelecConv.Location = new System.Drawing.Point(15, 135);
            this.btnSelecConv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecConv.Name = "btnSelecConv";
            this.btnSelecConv.Size = new System.Drawing.Size(251, 28);
            this.btnSelecConv.TabIndex = 2;
            this.btnSelecConv.Text = "Selección por convolución";
            this.btnSelecConv.UseVisualStyleBackColor = true;
            this.btnSelecConv.Click += new System.EventHandler(this.btnSelecConv_Click);
            // 
            // btnSelecMulti
            // 
            this.btnSelecMulti.Location = new System.Drawing.Point(15, 85);
            this.btnSelecMulti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecMulti.Name = "btnSelecMulti";
            this.btnSelecMulti.Size = new System.Drawing.Size(251, 28);
            this.btnSelecMulti.TabIndex = 1;
            this.btnSelecMulti.Text = "Selección multiatributo";
            this.btnSelecMulti.UseVisualStyleBackColor = true;
            // 
            // btnSelecSimple
            // 
            this.btnSelecSimple.Location = new System.Drawing.Point(15, 39);
            this.btnSelecSimple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecSimple.Name = "btnSelecSimple";
            this.btnSelecSimple.Size = new System.Drawing.Size(251, 28);
            this.btnSelecSimple.TabIndex = 0;
            this.btnSelecSimple.Text = "Selección simple";
            this.btnSelecSimple.UseVisualStyleBackColor = true;
            // 
            // grbProyeccion
            // 
            this.grbProyeccion.Controls.Add(this.btnJuntar);
            this.grbProyeccion.Controls.Add(this.btnProyMulti);
            this.grbProyeccion.Controls.Add(this.btnProySimple);
            this.grbProyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProyeccion.Location = new System.Drawing.Point(11, 370);
            this.grbProyeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbProyeccion.Name = "grbProyeccion";
            this.grbProyeccion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbProyeccion.Size = new System.Drawing.Size(313, 169);
            this.grbProyeccion.TabIndex = 6;
            this.grbProyeccion.TabStop = false;
            this.grbProyeccion.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(15, 135);
            this.btnJuntar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(251, 28);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnProyMulti
            // 
            this.btnProyMulti.Location = new System.Drawing.Point(15, 85);
            this.btnProyMulti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProyMulti.Name = "btnProyMulti";
            this.btnProyMulti.Size = new System.Drawing.Size(251, 28);
            this.btnProyMulti.TabIndex = 1;
            this.btnProyMulti.Text = "Proyección multiatributo";
            this.btnProyMulti.UseVisualStyleBackColor = true;
            this.btnProyMulti.Click += new System.EventHandler(this.btnProyMulti_Click);
            // 
            // btnProySimple
            // 
            this.btnProySimple.Location = new System.Drawing.Point(15, 39);
            this.btnProySimple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProySimple.Name = "btnProySimple";
            this.btnProySimple.Size = new System.Drawing.Size(251, 28);
            this.btnProySimple.TabIndex = 0;
            this.btnProySimple.Text = "Proyección simple";
            this.btnProySimple.UseVisualStyleBackColor = true;
            this.btnProySimple.Click += new System.EventHandler(this.btnProySimple_Click);
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(15, 14);
            this.dgvBaseDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.RowHeadersWidth = 51;
            this.dgvBaseDatos.RowTemplate.Height = 24;
            this.dgvBaseDatos.Size = new System.Drawing.Size(956, 334);
            this.dgvBaseDatos.TabIndex = 5;
            // 
            // frmBdOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 554);
            this.Controls.Add(this.grbAlgebraicas);
            this.Controls.Add(this.grbSeleccion);
            this.Controls.Add(this.grbProyeccion);
            this.Controls.Add(this.dgvBaseDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBdOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            this.Load += new System.EventHandler(this.frmBdOperaciones_Load);
            this.grbAlgebraicas.ResumeLayout(false);
            this.grbSeleccion.ResumeLayout(false);
            this.grbProyeccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAlgebraicas;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.GroupBox grbSeleccion;
        private System.Windows.Forms.Button btnSelecConv;
        private System.Windows.Forms.Button btnSelecMulti;
        private System.Windows.Forms.Button btnSelecSimple;
        private System.Windows.Forms.GroupBox grbProyeccion;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyMulti;
        private System.Windows.Forms.Button btnProySimple;
        private System.Windows.Forms.DataGridView dgvBaseDatos;
    }
}