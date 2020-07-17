namespace SistemaHorariosHESAR
{
    partial class VistaCurso_periodo
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnder = new System.Windows.Forms.Button();
            this.btnizq = new System.Windows.Forms.Button();
            this.txtcampo = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(33, 24);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(184, 292);
            this.listBox1.TabIndex = 9;
            this.listBox1.ValueMember = "Nombre";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(341, 24);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(188, 292);
            this.listBox2.TabIndex = 10;
            this.listBox2.ValueMember = "Nombre";
            // 
            // btnder
            // 
            this.btnder.Location = new System.Drawing.Point(236, 133);
            this.btnder.Margin = new System.Windows.Forms.Padding(4);
            this.btnder.Name = "btnder";
            this.btnder.Size = new System.Drawing.Size(75, 42);
            this.btnder.TabIndex = 11;
            this.btnder.Text = ">>";
            this.btnder.UseVisualStyleBackColor = true;
            this.btnder.Click += new System.EventHandler(this.btnder_Click);
            // 
            // btnizq
            // 
            this.btnizq.Location = new System.Drawing.Point(236, 197);
            this.btnizq.Margin = new System.Windows.Forms.Padding(4);
            this.btnizq.Name = "btnizq";
            this.btnizq.Size = new System.Drawing.Size(75, 42);
            this.btnizq.TabIndex = 12;
            this.btnizq.Text = "<<";
            this.btnizq.UseVisualStyleBackColor = true;
            this.btnizq.Click += new System.EventHandler(this.btnizq_Click);
            // 
            // txtcampo
            // 
            this.txtcampo.Location = new System.Drawing.Point(33, 343);
            this.txtcampo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcampo.Name = "txtcampo";
            this.txtcampo.Size = new System.Drawing.Size(184, 22);
            this.txtcampo.TabIndex = 13;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(61, 386);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(121, 38);
            this.btnagregar.TabIndex = 14;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(61, 432);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(121, 38);
            this.btneliminar.TabIndex = 15;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(61, 477);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(121, 38);
            this.btnlimpiar.TabIndex = 16;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(61, 523);
            this.btnmostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(121, 38);
            this.btnmostrar.TabIndex = 17;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // VistaCurso_periodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 584);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtcampo);
            this.Controls.Add(this.btnizq);
            this.Controls.Add(this.btnder);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VistaCurso_periodo";
            this.Text = "VistaCurso_periodo";
            this.Load += new System.EventHandler(this.VistaCurso_periodo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnder;
        private System.Windows.Forms.Button btnizq;
        private System.Windows.Forms.TextBox txtcampo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnmostrar;
    }
}