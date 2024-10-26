namespace CalculoNomina
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTipoNomina = new Label();
            lblName = new Label();
            lblID = new Label();
            groupBoxDatos = new GroupBox();
            txtAntigüedad = new TextBox();
            lblAntigüedad = new Label();
            textBox1 = new TextBox();
            lblDepartamento = new Label();
            txtHorasExtras = new TextBox();
            txtSalarioMensual = new TextBox();
            txtID = new TextBox();
            txtNombre = new TextBox();
            cmbTipoNomina = new ComboBox();
            btnCalcularNomina = new Button();
            lblHorasExtras = new Label();
            lblSalarioMensual = new Label();
            dataGridView1 = new DataGridView();
            clmID = new DataGridViewTextBoxColumn();
            clmNombre = new DataGridViewTextBoxColumn();
            clmDepartamento = new DataGridViewTextBoxColumn();
            clmSalarioMensual = new DataGridViewTextBoxColumn();
            clmSalarioQuincenal = new DataGridViewTextBoxColumn();
            clmSalarioSemanal = new DataGridViewTextBoxColumn();
            clmHorasExtras = new DataGridViewTextBoxColumn();
            clmAntiguedad = new DataGridViewTextBoxColumn();
            clmTotalIngresos = new DataGridViewTextBoxColumn();
            clmINSSLaboral = new DataGridViewTextBoxColumn();
            clmIR = new DataGridViewTextBoxColumn();
            clmTotalDeducciones = new DataGridViewTextBoxColumn();
            clmSalarioNeto = new DataGridViewTextBoxColumn();
            clmINATEC = new DataGridViewTextBoxColumn();
            cmlINSSPatronal = new DataGridViewTextBoxColumn();
            clmVacaciones = new DataGridViewTextBoxColumn();
            clmTreceavoMes = new DataGridViewTextBoxColumn();
            clmIndemizacion = new DataGridViewTextBoxColumn();
            groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTipoNomina
            // 
            lblTipoNomina.AutoSize = true;
            lblTipoNomina.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoNomina.Location = new Point(6, 67);
            lblTipoNomina.Name = "lblTipoNomina";
            lblTipoNomina.Size = new Size(185, 27);
            lblTipoNomina.TabIndex = 0;
            lblTipoNomina.Text = "Tipo de Nomina:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            lblName.Location = new Point(6, 124);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 27);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            lblID.Location = new Point(6, 181);
            lblID.Name = "lblID";
            lblID.Size = new Size(42, 27);
            lblID.TabIndex = 2;
            lblID.Text = "ID:";
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.BackColor = Color.GhostWhite;
            groupBoxDatos.Controls.Add(txtAntigüedad);
            groupBoxDatos.Controls.Add(lblAntigüedad);
            groupBoxDatos.Controls.Add(textBox1);
            groupBoxDatos.Controls.Add(lblDepartamento);
            groupBoxDatos.Controls.Add(txtHorasExtras);
            groupBoxDatos.Controls.Add(txtSalarioMensual);
            groupBoxDatos.Controls.Add(txtID);
            groupBoxDatos.Controls.Add(txtNombre);
            groupBoxDatos.Controls.Add(cmbTipoNomina);
            groupBoxDatos.Controls.Add(btnCalcularNomina);
            groupBoxDatos.Controls.Add(lblHorasExtras);
            groupBoxDatos.Controls.Add(lblSalarioMensual);
            groupBoxDatos.Controls.Add(lblTipoNomina);
            groupBoxDatos.Controls.Add(lblID);
            groupBoxDatos.Controls.Add(lblName);
            groupBoxDatos.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
            groupBoxDatos.Location = new Point(52, 34);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Size = new Size(557, 602);
            groupBoxDatos.TabIndex = 3;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = "Datos:";
            // 
            // txtAntigüedad
            // 
            txtAntigüedad.Location = new Point(264, 421);
            txtAntigüedad.Name = "txtAntigüedad";
            txtAntigüedad.Size = new Size(230, 34);
            txtAntigüedad.TabIndex = 12;
            // 
            // lblAntigüedad
            // 
            lblAntigüedad.AutoSize = true;
            lblAntigüedad.Location = new Point(6, 428);
            lblAntigüedad.Name = "lblAntigüedad";
            lblAntigüedad.Size = new Size(140, 27);
            lblAntigüedad.TabIndex = 11;
            lblAntigüedad.Text = "Antigüedad:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 237);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 34);
            textBox1.TabIndex = 10;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(6, 244);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(170, 27);
            lblDepartamento.TabIndex = 9;
            lblDepartamento.Text = "Departamento:";
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Location = new Point(264, 363);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(230, 34);
            txtHorasExtras.TabIndex = 8;
            // 
            // txtSalarioMensual
            // 
            txtSalarioMensual.Location = new Point(264, 298);
            txtSalarioMensual.Name = "txtSalarioMensual";
            txtSalarioMensual.Size = new Size(230, 34);
            txtSalarioMensual.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(264, 174);
            txtID.Name = "txtID";
            txtID.Size = new Size(230, 34);
            txtID.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(264, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(230, 34);
            txtNombre.TabIndex = 7;
            // 
            // cmbTipoNomina
            // 
            cmbTipoNomina.FormattingEnabled = true;
            cmbTipoNomina.Items.AddRange(new object[] { "Mensual", "Quincenal", "Semanal" });
            cmbTipoNomina.Location = new Point(264, 59);
            cmbTipoNomina.Name = "cmbTipoNomina";
            cmbTipoNomina.Size = new Size(230, 35);
            cmbTipoNomina.TabIndex = 6;
            // 
            // btnCalcularNomina
            // 
            btnCalcularNomina.Location = new Point(152, 482);
            btnCalcularNomina.Name = "btnCalcularNomina";
            btnCalcularNomina.Size = new Size(200, 67);
            btnCalcularNomina.TabIndex = 5;
            btnCalcularNomina.Text = "Calcular Nomina";
            btnCalcularNomina.UseVisualStyleBackColor = true;
            // 
            // lblHorasExtras
            // 
            lblHorasExtras.AutoSize = true;
            lblHorasExtras.Location = new Point(6, 370);
            lblHorasExtras.Name = "lblHorasExtras";
            lblHorasExtras.Size = new Size(154, 27);
            lblHorasExtras.TabIndex = 4;
            lblHorasExtras.Text = "Horas Extras:";
            // 
            // lblSalarioMensual
            // 
            lblSalarioMensual.AutoSize = true;
            lblSalarioMensual.Location = new Point(6, 305);
            lblSalarioMensual.Name = "lblSalarioMensual";
            lblSalarioMensual.Size = new Size(186, 27);
            lblSalarioMensual.TabIndex = 3;
            lblSalarioMensual.Text = "Salario Mensual:";
            lblSalarioMensual.Click += lblSalarioMensual_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmID, clmNombre, clmDepartamento, clmSalarioMensual, clmSalarioQuincenal, clmSalarioSemanal, clmHorasExtras, clmAntiguedad, clmTotalIngresos, clmINSSLaboral, clmIR, clmTotalDeducciones, clmSalarioNeto, clmINATEC, cmlINSSPatronal, clmVacaciones, clmTreceavoMes, clmIndemizacion });
            dataGridView1.Location = new Point(627, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1081, 602);
            dataGridView1.TabIndex = 4;
            // 
            // clmID
            // 
            clmID.HeaderText = "ID";
            clmID.MinimumWidth = 6;
            clmID.Name = "clmID";
            clmID.ReadOnly = true;
            clmID.Width = 125;
            // 
            // clmNombre
            // 
            clmNombre.HeaderText = "Nombres";
            clmNombre.MinimumWidth = 6;
            clmNombre.Name = "clmNombre";
            clmNombre.ReadOnly = true;
            clmNombre.Width = 125;
            // 
            // clmDepartamento
            // 
            clmDepartamento.HeaderText = "Departamento";
            clmDepartamento.MinimumWidth = 6;
            clmDepartamento.Name = "clmDepartamento";
            clmDepartamento.ReadOnly = true;
            clmDepartamento.Width = 125;
            // 
            // clmSalarioMensual
            // 
            clmSalarioMensual.HeaderText = "Salario Mensual";
            clmSalarioMensual.MinimumWidth = 6;
            clmSalarioMensual.Name = "clmSalarioMensual";
            clmSalarioMensual.ReadOnly = true;
            clmSalarioMensual.Width = 125;
            // 
            // clmSalarioQuincenal
            // 
            clmSalarioQuincenal.HeaderText = "Salario Quincenal";
            clmSalarioQuincenal.MinimumWidth = 6;
            clmSalarioQuincenal.Name = "clmSalarioQuincenal";
            clmSalarioQuincenal.ReadOnly = true;
            clmSalarioQuincenal.Width = 125;
            // 
            // clmSalarioSemanal
            // 
            clmSalarioSemanal.HeaderText = "Salario Semanal";
            clmSalarioSemanal.MinimumWidth = 6;
            clmSalarioSemanal.Name = "clmSalarioSemanal";
            clmSalarioSemanal.ReadOnly = true;
            clmSalarioSemanal.Width = 125;
            // 
            // clmHorasExtras
            // 
            clmHorasExtras.HeaderText = "HorasExtras";
            clmHorasExtras.MinimumWidth = 6;
            clmHorasExtras.Name = "clmHorasExtras";
            clmHorasExtras.ReadOnly = true;
            clmHorasExtras.Width = 125;
            // 
            // clmAntiguedad
            // 
            clmAntiguedad.HeaderText = "Antiguedad";
            clmAntiguedad.MinimumWidth = 6;
            clmAntiguedad.Name = "clmAntiguedad";
            clmAntiguedad.ReadOnly = true;
            clmAntiguedad.Width = 125;
            // 
            // clmTotalIngresos
            // 
            clmTotalIngresos.HeaderText = "Total Ingresos";
            clmTotalIngresos.MinimumWidth = 6;
            clmTotalIngresos.Name = "clmTotalIngresos";
            clmTotalIngresos.ReadOnly = true;
            clmTotalIngresos.Width = 125;
            // 
            // clmINSSLaboral
            // 
            clmINSSLaboral.HeaderText = "INSS Laboral";
            clmINSSLaboral.MinimumWidth = 6;
            clmINSSLaboral.Name = "clmINSSLaboral";
            clmINSSLaboral.ReadOnly = true;
            clmINSSLaboral.Width = 125;
            // 
            // clmIR
            // 
            clmIR.HeaderText = "IR";
            clmIR.MinimumWidth = 6;
            clmIR.Name = "clmIR";
            clmIR.ReadOnly = true;
            clmIR.Width = 125;
            // 
            // clmTotalDeducciones
            // 
            clmTotalDeducciones.HeaderText = "Total Deducciones";
            clmTotalDeducciones.MinimumWidth = 6;
            clmTotalDeducciones.Name = "clmTotalDeducciones";
            clmTotalDeducciones.ReadOnly = true;
            clmTotalDeducciones.Width = 125;
            // 
            // clmSalarioNeto
            // 
            clmSalarioNeto.HeaderText = "Salario Neto";
            clmSalarioNeto.MinimumWidth = 6;
            clmSalarioNeto.Name = "clmSalarioNeto";
            clmSalarioNeto.ReadOnly = true;
            clmSalarioNeto.Width = 125;
            // 
            // clmINATEC
            // 
            clmINATEC.HeaderText = "INATEC";
            clmINATEC.MinimumWidth = 6;
            clmINATEC.Name = "clmINATEC";
            clmINATEC.ReadOnly = true;
            clmINATEC.Width = 125;
            // 
            // cmlINSSPatronal
            // 
            cmlINSSPatronal.HeaderText = "INSS Patronal";
            cmlINSSPatronal.MinimumWidth = 6;
            cmlINSSPatronal.Name = "cmlINSSPatronal";
            cmlINSSPatronal.ReadOnly = true;
            cmlINSSPatronal.Width = 125;
            // 
            // clmVacaciones
            // 
            clmVacaciones.HeaderText = "Vacaciones";
            clmVacaciones.MinimumWidth = 6;
            clmVacaciones.Name = "clmVacaciones";
            clmVacaciones.ReadOnly = true;
            clmVacaciones.Width = 125;
            // 
            // clmTreceavoMes
            // 
            clmTreceavoMes.HeaderText = "Treceavo Mes";
            clmTreceavoMes.MinimumWidth = 6;
            clmTreceavoMes.Name = "clmTreceavoMes";
            clmTreceavoMes.ReadOnly = true;
            clmTreceavoMes.Width = 125;
            // 
            // clmIndemizacion
            // 
            clmIndemizacion.HeaderText = "Indemizacion";
            clmIndemizacion.MinimumWidth = 6;
            clmIndemizacion.Name = "clmIndemizacion";
            clmIndemizacion.ReadOnly = true;
            clmIndemizacion.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1750, 753);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxDatos);
            Name = "Form1";
            Text = "Form1";
            groupBoxDatos.ResumeLayout(false);
            groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTipoNomina;
        private Label lblName;
        private Label lblID;
        private GroupBox groupBoxDatos;
        private Label lblHorasExtras;
        private Label lblSalarioMensual;
        private TextBox txtSalarioMensual;
        private TextBox txtID;
        private TextBox txtNombre;
        private ComboBox cmbTipoNomina;
        private Button btnCalcularNomina;
        private TextBox txtHorasExtras;
        private DataGridView dataGridView1;
        private Label lblDepartamento;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmDepartamento;
        private DataGridViewTextBoxColumn clmSalarioMensual;
        private DataGridViewTextBoxColumn clmSalarioQuincenal;
        private DataGridViewTextBoxColumn clmSalarioSemanal;
        private DataGridViewTextBoxColumn clmHorasExtras;
        private DataGridViewTextBoxColumn clmAntiguedad;
        private Label lblAntigüedad;
        private DataGridViewTextBoxColumn clmTotalIngresos;
        private DataGridViewTextBoxColumn clmINSSLaboral;
        private DataGridViewTextBoxColumn clmIR;
        private DataGridViewTextBoxColumn clmTotalDeducciones;
        private DataGridViewTextBoxColumn clmSalarioNeto;
        private DataGridViewTextBoxColumn clmINATEC;
        private DataGridViewTextBoxColumn cmlINSSPatronal;
        private DataGridViewTextBoxColumn clmVacaciones;
        private DataGridViewTextBoxColumn clmTreceavoMes;
        private DataGridViewTextBoxColumn clmIndemizacion;
        private TextBox txtAntigüedad;
    }
}
