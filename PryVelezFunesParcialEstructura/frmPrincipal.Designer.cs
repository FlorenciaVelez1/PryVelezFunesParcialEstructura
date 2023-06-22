namespace PryVelezFunesParcialEstructura
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcListaDatos = new System.Windows.Forms.GroupBox();
            this.optDescendente = new System.Windows.Forms.RadioButton();
            this.optAscendete = new System.Windows.Forms.RadioButton();
            this.GrillaListaDoble = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.mrcEmpleadoEliminado = new System.Windows.Forms.GroupBox();
            this.cbNumeroLegajo = new System.Windows.Forms.ComboBox();
            this.lblCodigoEE = new System.Windows.Forms.Label();
            this.mrcNuevoEmpleado = new System.Windows.Forms.GroupBox();
            this.mskCategoriaNE = new System.Windows.Forms.MaskedTextBox();
            this.mskSueldoBasicoNE = new System.Windows.Forms.MaskedTextBox();
            this.lblSueldoBasicoNE = new System.Windows.Forms.Label();
            this.mskNumeroLegajoNE = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreCompletoNE = new System.Windows.Forms.TextBox();
            this.lbNumeroLegajoNE = new System.Windows.Forms.Label();
            this.lblNombreCompletoNE = new System.Windows.Forms.Label();
            this.lblCategoriaNE = new System.Windows.Forms.Label();
            this.cmdListar = new System.Windows.Forms.Button();
            this.optTodosEmpleados = new System.Windows.Forms.CheckBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.mskSueldo = new System.Windows.Forms.MaskedTextBox();
            this.mrcListaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListaDoble)).BeginInit();
            this.mrcEmpleadoEliminado.SuspendLayout();
            this.mrcNuevoEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcListaDatos
            // 
            this.mrcListaDatos.Controls.Add(this.optDescendente);
            this.mrcListaDatos.Controls.Add(this.optAscendete);
            this.mrcListaDatos.Location = new System.Drawing.Point(278, 123);
            this.mrcListaDatos.Name = "mrcListaDatos";
            this.mrcListaDatos.Size = new System.Drawing.Size(140, 64);
            this.mrcListaDatos.TabIndex = 10;
            this.mrcListaDatos.TabStop = false;
            this.mrcListaDatos.Text = "Listar los Datos";
            // 
            // optDescendente
            // 
            this.optDescendente.AutoSize = true;
            this.optDescendente.Location = new System.Drawing.Point(6, 42);
            this.optDescendente.Name = "optDescendente";
            this.optDescendente.Size = new System.Drawing.Size(89, 17);
            this.optDescendente.TabIndex = 12;
            this.optDescendente.TabStop = true;
            this.optDescendente.Text = "Descendente";
            this.optDescendente.UseVisualStyleBackColor = true;
            // 
            // optAscendete
            // 
            this.optAscendete.AutoSize = true;
            this.optAscendete.Location = new System.Drawing.Point(6, 19);
            this.optAscendete.Name = "optAscendete";
            this.optAscendete.Size = new System.Drawing.Size(82, 17);
            this.optAscendete.TabIndex = 11;
            this.optAscendete.TabStop = true;
            this.optAscendete.Text = "Ascendente";
            this.optAscendete.UseVisualStyleBackColor = true;
            // 
            // GrillaListaDoble
            // 
            this.GrillaListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.GrillaListaDoble.Location = new System.Drawing.Point(11, 242);
            this.GrillaListaDoble.Margin = new System.Windows.Forms.Padding(2);
            this.GrillaListaDoble.Name = "GrillaListaDoble";
            this.GrillaListaDoble.ReadOnly = true;
            this.GrillaListaDoble.RowHeadersVisible = false;
            this.GrillaListaDoble.RowHeadersWidth = 51;
            this.GrillaListaDoble.RowTemplate.Height = 24;
            this.GrillaListaDoble.Size = new System.Drawing.Size(478, 206);
            this.GrillaListaDoble.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero Legajo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Completo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Categoria";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Suledo Basico";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(100, 53);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(76, 31);
            this.cmdEliminar.TabIndex = 9;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click_1);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Enabled = false;
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Location = new System.Drawing.Point(132, 155);
            this.cmdAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(76, 31);
            this.cmdAgregar.TabIndex = 5;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click_1);
            // 
            // mrcEmpleadoEliminado
            // 
            this.mrcEmpleadoEliminado.Controls.Add(this.cbNumeroLegajo);
            this.mrcEmpleadoEliminado.Controls.Add(this.lblCodigoEE);
            this.mrcEmpleadoEliminado.Controls.Add(this.cmdEliminar);
            this.mrcEmpleadoEliminado.Location = new System.Drawing.Point(278, 11);
            this.mrcEmpleadoEliminado.Margin = new System.Windows.Forms.Padding(2);
            this.mrcEmpleadoEliminado.Name = "mrcEmpleadoEliminado";
            this.mrcEmpleadoEliminado.Padding = new System.Windows.Forms.Padding(2);
            this.mrcEmpleadoEliminado.Size = new System.Drawing.Size(209, 93);
            this.mrcEmpleadoEliminado.TabIndex = 7;
            this.mrcEmpleadoEliminado.TabStop = false;
            this.mrcEmpleadoEliminado.Text = "Empleado Eliminado";
            // 
            // cbNumeroLegajo
            // 
            this.cbNumeroLegajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumeroLegajo.FormattingEnabled = true;
            this.cbNumeroLegajo.Location = new System.Drawing.Point(100, 26);
            this.cbNumeroLegajo.Margin = new System.Windows.Forms.Padding(2);
            this.cbNumeroLegajo.Name = "cbNumeroLegajo";
            this.cbNumeroLegajo.Size = new System.Drawing.Size(92, 21);
            this.cbNumeroLegajo.TabIndex = 8;
            this.cbNumeroLegajo.SelectedIndexChanged += new System.EventHandler(this.cbNumeroLegajo_SelectedIndexChanged_1);
            // 
            // lblCodigoEE
            // 
            this.lblCodigoEE.AutoSize = true;
            this.lblCodigoEE.Location = new System.Drawing.Point(4, 29);
            this.lblCodigoEE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoEE.Name = "lblCodigoEE";
            this.lblCodigoEE.Size = new System.Drawing.Size(79, 13);
            this.lblCodigoEE.TabIndex = 6;
            this.lblCodigoEE.Text = "Numero Legajo";
            // 
            // mrcNuevoEmpleado
            // 
            this.mrcNuevoEmpleado.Controls.Add(this.mskCategoriaNE);
            this.mrcNuevoEmpleado.Controls.Add(this.mskSueldoBasicoNE);
            this.mrcNuevoEmpleado.Controls.Add(this.lblSueldoBasicoNE);
            this.mrcNuevoEmpleado.Controls.Add(this.mskNumeroLegajoNE);
            this.mrcNuevoEmpleado.Controls.Add(this.cmdAgregar);
            this.mrcNuevoEmpleado.Controls.Add(this.txtNombreCompletoNE);
            this.mrcNuevoEmpleado.Controls.Add(this.lbNumeroLegajoNE);
            this.mrcNuevoEmpleado.Controls.Add(this.lblNombreCompletoNE);
            this.mrcNuevoEmpleado.Controls.Add(this.lblCategoriaNE);
            this.mrcNuevoEmpleado.Location = new System.Drawing.Point(11, 11);
            this.mrcNuevoEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.mrcNuevoEmpleado.Name = "mrcNuevoEmpleado";
            this.mrcNuevoEmpleado.Padding = new System.Windows.Forms.Padding(2);
            this.mrcNuevoEmpleado.Size = new System.Drawing.Size(260, 190);
            this.mrcNuevoEmpleado.TabIndex = 0;
            this.mrcNuevoEmpleado.TabStop = false;
            this.mrcNuevoEmpleado.Text = "Nuevo Empleado";
            // 
            // mskCategoriaNE
            // 
            this.mskCategoriaNE.Location = new System.Drawing.Point(114, 95);
            this.mskCategoriaNE.Margin = new System.Windows.Forms.Padding(2);
            this.mskCategoriaNE.Mask = "000000";
            this.mskCategoriaNE.Name = "mskCategoriaNE";
            this.mskCategoriaNE.ResetOnSpace = false;
            this.mskCategoriaNE.Size = new System.Drawing.Size(108, 20);
            this.mskCategoriaNE.TabIndex = 3;
            this.mskCategoriaNE.TextChanged += new System.EventHandler(this.mskCategoriaNE_TextChanged);
            // 
            // mskSueldoBasicoNE
            // 
            this.mskSueldoBasicoNE.Location = new System.Drawing.Point(114, 131);
            this.mskSueldoBasicoNE.Margin = new System.Windows.Forms.Padding(2);
            this.mskSueldoBasicoNE.Mask = "000000";
            this.mskSueldoBasicoNE.Name = "mskSueldoBasicoNE";
            this.mskSueldoBasicoNE.ResetOnSpace = false;
            this.mskSueldoBasicoNE.Size = new System.Drawing.Size(108, 20);
            this.mskSueldoBasicoNE.TabIndex = 4;
            this.mskSueldoBasicoNE.TextChanged += new System.EventHandler(this.mskSueldoBasicoNE_TextChanged);
            // 
            // lblSueldoBasicoNE
            // 
            this.lblSueldoBasicoNE.AutoSize = true;
            this.lblSueldoBasicoNE.Location = new System.Drawing.Point(17, 131);
            this.lblSueldoBasicoNE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSueldoBasicoNE.Name = "lblSueldoBasicoNE";
            this.lblSueldoBasicoNE.Size = new System.Drawing.Size(75, 13);
            this.lblSueldoBasicoNE.TabIndex = 4;
            this.lblSueldoBasicoNE.Text = "Sueldo Basico";
            // 
            // mskNumeroLegajoNE
            // 
            this.mskNumeroLegajoNE.Location = new System.Drawing.Point(114, 32);
            this.mskNumeroLegajoNE.Margin = new System.Windows.Forms.Padding(2);
            this.mskNumeroLegajoNE.Mask = "000000";
            this.mskNumeroLegajoNE.Name = "mskNumeroLegajoNE";
            this.mskNumeroLegajoNE.ResetOnSpace = false;
            this.mskNumeroLegajoNE.Size = new System.Drawing.Size(108, 20);
            this.mskNumeroLegajoNE.TabIndex = 1;
            this.mskNumeroLegajoNE.TextChanged += new System.EventHandler(this.mskNumeroLegajoNE_TextChanged);
            // 
            // txtNombreCompletoNE
            // 
            this.txtNombreCompletoNE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCompletoNE.Location = new System.Drawing.Point(114, 65);
            this.txtNombreCompletoNE.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCompletoNE.Name = "txtNombreCompletoNE";
            this.txtNombreCompletoNE.Size = new System.Drawing.Size(108, 20);
            this.txtNombreCompletoNE.TabIndex = 2;
            this.txtNombreCompletoNE.TextChanged += new System.EventHandler(this.txtNombreCompletoNE_TextChanged);
            this.txtNombreCompletoNE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCompletoNE_KeyPress_1);
            // 
            // lbNumeroLegajoNE
            // 
            this.lbNumeroLegajoNE.AutoSize = true;
            this.lbNumeroLegajoNE.Location = new System.Drawing.Point(17, 32);
            this.lbNumeroLegajoNE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumeroLegajoNE.Name = "lbNumeroLegajoNE";
            this.lbNumeroLegajoNE.Size = new System.Drawing.Size(79, 13);
            this.lbNumeroLegajoNE.TabIndex = 0;
            this.lbNumeroLegajoNE.Text = "Numero Legajo";
            // 
            // lblNombreCompletoNE
            // 
            this.lblNombreCompletoNE.AutoSize = true;
            this.lblNombreCompletoNE.Location = new System.Drawing.Point(17, 64);
            this.lblNombreCompletoNE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCompletoNE.Name = "lblNombreCompletoNE";
            this.lblNombreCompletoNE.Size = new System.Drawing.Size(91, 13);
            this.lblNombreCompletoNE.TabIndex = 1;
            this.lblNombreCompletoNE.Text = "Nombre Completo";
            // 
            // lblCategoriaNE
            // 
            this.lblCategoriaNE.AutoSize = true;
            this.lblCategoriaNE.Location = new System.Drawing.Point(17, 98);
            this.lblCategoriaNE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoriaNE.Name = "lblCategoriaNE";
            this.lblCategoriaNE.Size = new System.Drawing.Size(52, 13);
            this.lblCategoriaNE.TabIndex = 2;
            this.lblCategoriaNE.Text = "Categoria";
            // 
            // cmdListar
            // 
            this.cmdListar.Enabled = false;
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(413, 206);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(76, 31);
            this.cmdListar.TabIndex = 26;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click_1);
            // 
            // optTodosEmpleados
            // 
            this.optTodosEmpleados.AutoSize = true;
            this.optTodosEmpleados.Location = new System.Drawing.Point(12, 214);
            this.optTodosEmpleados.Name = "optTodosEmpleados";
            this.optTodosEmpleados.Size = new System.Drawing.Size(127, 17);
            this.optTodosEmpleados.TabIndex = 27;
            this.optTodosEmpleados.Text = "Todos los Empleados";
            this.optTodosEmpleados.UseVisualStyleBackColor = true;
            this.optTodosEmpleados.CheckedChanged += new System.EventHandler(this.optTodosEmpleados_CheckedChanged_1);
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(145, 215);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(149, 13);
            this.lblSueldo.TabIndex = 28;
            this.lblSueldo.Text = "Empleado con sueldo mayor a";
            // 
            // mskSueldo
            // 
            this.mskSueldo.Location = new System.Drawing.Point(309, 212);
            this.mskSueldo.Mask = "00000000";
            this.mskSueldo.Name = "mskSueldo";
            this.mskSueldo.Size = new System.Drawing.Size(98, 20);
            this.mskSueldo.TabIndex = 29;
            this.mskSueldo.TextChanged += new System.EventHandler(this.mskSueldo_TextChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 460);
            this.Controls.Add(this.mskSueldo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.optTodosEmpleados);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.mrcListaDatos);
            this.Controls.Add(this.GrillaListaDoble);
            this.Controls.Add(this.mrcEmpleadoEliminado);
            this.Controls.Add(this.mrcNuevoEmpleado);
            this.Name = "frmPrincipal";
            this.Text = "Lista Doble";
            this.mrcListaDatos.ResumeLayout(false);
            this.mrcListaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListaDoble)).EndInit();
            this.mrcEmpleadoEliminado.ResumeLayout(false);
            this.mrcEmpleadoEliminado.PerformLayout();
            this.mrcNuevoEmpleado.ResumeLayout(false);
            this.mrcNuevoEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcListaDatos;
        private System.Windows.Forms.RadioButton optDescendente;
        private System.Windows.Forms.RadioButton optAscendete;
        private System.Windows.Forms.DataGridView GrillaListaDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.GroupBox mrcEmpleadoEliminado;
        private System.Windows.Forms.ComboBox cbNumeroLegajo;
        private System.Windows.Forms.Label lblCodigoEE;
        private System.Windows.Forms.GroupBox mrcNuevoEmpleado;
        private System.Windows.Forms.MaskedTextBox mskCategoriaNE;
        private System.Windows.Forms.MaskedTextBox mskSueldoBasicoNE;
        private System.Windows.Forms.Label lblSueldoBasicoNE;
        private System.Windows.Forms.MaskedTextBox mskNumeroLegajoNE;
        private System.Windows.Forms.TextBox txtNombreCompletoNE;
        private System.Windows.Forms.Label lbNumeroLegajoNE;
        private System.Windows.Forms.Label lblNombreCompletoNE;
        private System.Windows.Forms.Label lblCategoriaNE;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.CheckBox optTodosEmpleados;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.MaskedTextBox mskSueldo;
    }
}

