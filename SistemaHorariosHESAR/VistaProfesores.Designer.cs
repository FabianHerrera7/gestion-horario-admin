namespace SistemaHorariosHESAR
{
    partial class VistaProfesores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaProfesores));
            this.button3 = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txthrstotales = new System.Windows.Forms.DateTimePicker();
            this.txthorasnoaula = new System.Windows.Forms.DateTimePicker();
            this.txthorasaula = new System.Windows.Forms.DateTimePicker();
            this.lblfecha = new System.Windows.Forms.Label();
            this.txtfechanac = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtappat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtapmat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtcampo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dgProfesor = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidopaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidomaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horascontratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasaulamaximaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasaulaefectivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vigenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(758, 552);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 38);
            this.button3.TabIndex = 18;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnsiguiente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiguiente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsiguiente.Location = new System.Drawing.Point(559, 552);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(193, 38);
            this.btnsiguiente.TabIndex = 17;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = false;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click_1);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Maroon;
            this.btnvolver.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnvolver.Location = new System.Drawing.Point(360, 552);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(193, 38);
            this.btnvolver.TabIndex = 16;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-7, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 495);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantenedor de Profesores";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.btnlimpiar);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.txtcampo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btneliminar);
            this.panel2.Controls.Add(this.btnmodificar);
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.dgProfesor);
            this.panel2.Location = new System.Drawing.Point(3, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 459);
            this.panel2.TabIndex = 0;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(375, 360);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(177, 20);
            this.txtid.TabIndex = 14;
            this.txtid.Visible = false;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.BackgroundImage")));
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlimpiar.Location = new System.Drawing.Point(815, 398);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(60, 58);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txthrstotales);
            this.groupBox1.Controls.Add(this.txthorasnoaula);
            this.groupBox1.Controls.Add(this.txthorasaula);
            this.groupBox1.Controls.Add(this.lblfecha);
            this.groupBox1.Controls.Add(this.txtfechanac);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtappat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtapmat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtrut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(568, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 389);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del profesor";
            // 
            // txthrstotales
            // 
            this.txthrstotales.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.txthrstotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthrstotales.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txthrstotales.Location = new System.Drawing.Point(247, 316);
            this.txthrstotales.Name = "txthrstotales";
            this.txthrstotales.Size = new System.Drawing.Size(158, 24);
            this.txthrstotales.TabIndex = 19;
            // 
            // txthorasnoaula
            // 
            this.txthorasnoaula.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.txthorasnoaula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorasnoaula.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txthorasnoaula.Location = new System.Drawing.Point(247, 274);
            this.txthorasnoaula.Name = "txthorasnoaula";
            this.txthorasnoaula.Size = new System.Drawing.Size(158, 24);
            this.txthorasnoaula.TabIndex = 18;
            // 
            // txthorasaula
            // 
            this.txthorasaula.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.txthorasaula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorasaula.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txthorasaula.Location = new System.Drawing.Point(247, 234);
            this.txthorasaula.Name = "txthorasaula";
            this.txthorasaula.Size = new System.Drawing.Size(158, 24);
            this.txthorasaula.TabIndex = 17;
            this.txthorasaula.Value = new System.DateTime(2020, 7, 31, 0, 0, 0, 0);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(408, 352);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(16, 24);
            this.lblfecha.TabIndex = 16;
            this.lblfecha.Text = ".";
            this.lblfecha.Visible = false;
            // 
            // txtfechanac
            // 
            this.txtfechanac.CustomFormat = "yyyy-MM-dd";
            this.txtfechanac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechanac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfechanac.Location = new System.Drawing.Point(247, 195);
            this.txtfechanac.Name = "txtfechanac";
            this.txtfechanac.Size = new System.Drawing.Size(158, 24);
            this.txtfechanac.TabIndex = 15;
            this.txtfechanac.ValueChanged += new System.EventHandler(this.txtfechanac_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "Horas efectivas en aula:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Fecha de nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Horas contrato:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Horas máximas en aula:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(247, 82);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(158, 29);
            this.txtnombre.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre:";
            // 
            // txtappat
            // 
            this.txtappat.Location = new System.Drawing.Point(247, 119);
            this.txtappat.Name = "txtappat";
            this.txtappat.Size = new System.Drawing.Size(158, 29);
            this.txtappat.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido paterno:";
            // 
            // txtapmat
            // 
            this.txtapmat.Location = new System.Drawing.Point(247, 159);
            this.txtapmat.Name = "txtapmat";
            this.txtapmat.Size = new System.Drawing.Size(158, 29);
            this.txtapmat.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido materno:";
            // 
            // txtrut
            // 
            this.txtrut.Location = new System.Drawing.Point(247, 43);
            this.txtrut.Name = "txtrut";
            this.txtrut.Size = new System.Drawing.Size(158, 29);
            this.txtrut.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rut:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(399, 13);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(126, 37);
            this.btnbuscar.TabIndex = 6;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click_1);
            // 
            // txtcampo
            // 
            this.txtcampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcampo.Location = new System.Drawing.Point(108, 13);
            this.txtcampo.Multiline = true;
            this.txtcampo.Name = "txtcampo";
            this.txtcampo.Size = new System.Drawing.Size(285, 37);
            this.txtcampo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar";
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btneliminar.Location = new System.Drawing.Point(238, 364);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(60, 58);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.Btneliminar_Click_1);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmodificar.BackgroundImage")));
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmodificar.Location = new System.Drawing.Point(144, 364);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(60, 58);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click_1);
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardar.BackgroundImage")));
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnguardar.Location = new System.Drawing.Point(719, 398);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(60, 58);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dgProfesor
            // 
            this.dgProfesor.AutoGenerateColumns = false;
            this.dgProfesor.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rutDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidopaternoDataGridViewTextBoxColumn,
            this.apellidomaternoDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn,
            this.horascontratoDataGridViewTextBoxColumn,
            this.horasaulamaximaDataGridViewTextBoxColumn,
            this.horasaulaefectivaDataGridViewTextBoxColumn,
            this.vigenteDataGridViewTextBoxColumn});
            this.dgProfesor.DataSource = this.profesorBindingSource;
            this.dgProfesor.Location = new System.Drawing.Point(16, 56);
            this.dgProfesor.Name = "dgProfesor";
            this.dgProfesor.Size = new System.Drawing.Size(536, 287);
            this.dgProfesor.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // rutDataGridViewTextBoxColumn
            // 
            this.rutDataGridViewTextBoxColumn.DataPropertyName = "Rut";
            this.rutDataGridViewTextBoxColumn.HeaderText = "Rut";
            this.rutDataGridViewTextBoxColumn.Name = "rutDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidopaternoDataGridViewTextBoxColumn
            // 
            this.apellidopaternoDataGridViewTextBoxColumn.DataPropertyName = "Apellido_paterno";
            this.apellidopaternoDataGridViewTextBoxColumn.HeaderText = "Apellido_paterno";
            this.apellidopaternoDataGridViewTextBoxColumn.Name = "apellidopaternoDataGridViewTextBoxColumn";
            // 
            // apellidomaternoDataGridViewTextBoxColumn
            // 
            this.apellidomaternoDataGridViewTextBoxColumn.DataPropertyName = "Apellido_materno";
            this.apellidomaternoDataGridViewTextBoxColumn.HeaderText = "Apellido_materno";
            this.apellidomaternoDataGridViewTextBoxColumn.Name = "apellidomaternoDataGridViewTextBoxColumn";
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
            // 
            // horascontratoDataGridViewTextBoxColumn
            // 
            this.horascontratoDataGridViewTextBoxColumn.DataPropertyName = "Horas_contrato";
            this.horascontratoDataGridViewTextBoxColumn.HeaderText = "Horas_contrato";
            this.horascontratoDataGridViewTextBoxColumn.Name = "horascontratoDataGridViewTextBoxColumn";
            // 
            // horasaulamaximaDataGridViewTextBoxColumn
            // 
            this.horasaulamaximaDataGridViewTextBoxColumn.DataPropertyName = "Horas_aula_maxima";
            this.horasaulamaximaDataGridViewTextBoxColumn.HeaderText = "Horas_aula_maxima";
            this.horasaulamaximaDataGridViewTextBoxColumn.Name = "horasaulamaximaDataGridViewTextBoxColumn";
            // 
            // horasaulaefectivaDataGridViewTextBoxColumn
            // 
            this.horasaulaefectivaDataGridViewTextBoxColumn.DataPropertyName = "Horas_aula_efectiva";
            this.horasaulaefectivaDataGridViewTextBoxColumn.HeaderText = "Horas_aula_efectiva";
            this.horasaulaefectivaDataGridViewTextBoxColumn.Name = "horasaulaefectivaDataGridViewTextBoxColumn";
            // 
            // vigenteDataGridViewTextBoxColumn
            // 
            this.vigenteDataGridViewTextBoxColumn.DataPropertyName = "Vigente";
            this.vigenteDataGridViewTextBoxColumn.HeaderText = "Vigente";
            this.vigenteDataGridViewTextBoxColumn.Name = "vigenteDataGridViewTextBoxColumn";
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(SistemaHorariosHESAR.Profesor);
            // 
            // VistaProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 619);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.panel1);
            this.Name = "VistaProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaProfesores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtappat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtapmat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtcampo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dgProfesor;
        private System.Windows.Forms.DateTimePicker txtfechanac;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidopaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidomaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horascontratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasaulamaximaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasaulaefectivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vigenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.DateTimePicker txthorasaula;
        private System.Windows.Forms.DateTimePicker txthrstotales;
        private System.Windows.Forms.DateTimePicker txthorasnoaula;
    }
}