namespace SistemaEscuela.UI.Registros
{
    partial class rCurso
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
            System.Windows.Forms.Label estudianteIdLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label nombreLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuargar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.IDCursoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            estudianteIdLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDCursoNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // estudianteIdLabel
            // 
            estudianteIdLabel.AutoSize = true;
            estudianteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estudianteIdLabel.Location = new System.Drawing.Point(28, 27);
            estudianteIdLabel.Name = "estudianteIdLabel";
            estudianteIdLabel.Size = new System.Drawing.Size(62, 16);
            estudianteIdLabel.TabIndex = 22;
            estudianteIdLabel.Text = "Curso ID:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matriculaLabel.Location = new System.Drawing.Point(32, 120);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(65, 16);
            matriculaLabel.TabIndex = 23;
            matriculaLabel.Text = "Cantidad:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(12, 81);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(83, 16);
            nombreLabel.TabIndex = 24;
            nombreLabel.Text = "Descripcion:";
            nombreLabel.Click += new System.EventHandler(this.nombreLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuargar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(2, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 66);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::SistemaEscuela.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(277, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 60);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            // 
            // btnGuargar
            // 
            this.btnGuargar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuargar.FlatAppearance.BorderSize = 0;
            this.btnGuargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuargar.Image = global::SistemaEscuela.Properties.Resources.save;
            this.btnGuargar.Location = new System.Drawing.Point(148, 6);
            this.btnGuargar.Name = "btnGuargar";
            this.btnGuargar.Size = new System.Drawing.Size(75, 60);
            this.btnGuargar.TabIndex = 1;
            this.btnGuargar.UseVisualStyleBackColor = false;
            this.btnGuargar.Click += new System.EventHandler(this.btnGuargar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::SistemaEscuela.Properties.Resources._new;
            this.btnNuevo.Location = new System.Drawing.Point(12, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 60);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::SistemaEscuela.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(284, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 52);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataSource = typeof(SistemaEscuela.Entidades.Estudiante);
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Matricula", true));
            this.CantidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadTextBox.Location = new System.Drawing.Point(107, 120);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(171, 22);
            this.CantidadTextBox.TabIndex = 24;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Nombre", true));
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(107, 78);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(171, 22);
            this.DescripcionTextBox.TabIndex = 25;
            this.DescripcionTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // IDCursoNumericUpDown
            // 
            this.IDCursoNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCursoNumericUpDown.Location = new System.Drawing.Point(107, 25);
            this.IDCursoNumericUpDown.Name = "IDCursoNumericUpDown";
            this.IDCursoNumericUpDown.Size = new System.Drawing.Size(171, 22);
            this.IDCursoNumericUpDown.TabIndex = 27;
            // 
            // rCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 227);
            this.Controls.Add(this.IDCursoNumericUpDown);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(estudianteIdLabel);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "rCurso";
            this.Text = "rCurso";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDCursoNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuargar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.NumericUpDown IDCursoNumericUpDown;
    }
}