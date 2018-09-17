namespace SistemaEscuela.UI.Registros
{
    partial class rEstudiante
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label estudianteIdLabel;
            System.Windows.Forms.Label cursoIdLabel;
            this.EstudianteIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CursoComboBox1 = new System.Windows.Forms.ComboBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.MatriculaTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuargar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.nombreErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MatriculaErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CursoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Cursobutton = new System.Windows.Forms.Button();
            nombreLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            estudianteIdLabel = new System.Windows.Forms.Label();
            cursoIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nombreErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatriculaErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(42, 80);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 16);
            nombreLabel.TabIndex = 33;
            nombreLabel.Text = "Nombre:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matriculaLabel.Location = new System.Drawing.Point(36, 119);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(65, 16);
            matriculaLabel.TabIndex = 32;
            matriculaLabel.Text = "Matricula:";
            // 
            // estudianteIdLabel
            // 
            estudianteIdLabel.AutoSize = true;
            estudianteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estudianteIdLabel.Location = new System.Drawing.Point(17, 26);
            estudianteIdLabel.Name = "estudianteIdLabel";
            estudianteIdLabel.Size = new System.Drawing.Size(88, 16);
            estudianteIdLabel.TabIndex = 31;
            estudianteIdLabel.Text = "Estudiante Id:";
            // 
            // cursoIdLabel
            // 
            cursoIdLabel.AutoSize = true;
            cursoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cursoIdLabel.Location = new System.Drawing.Point(55, 157);
            cursoIdLabel.Name = "cursoIdLabel";
            cursoIdLabel.Size = new System.Drawing.Size(46, 16);
            cursoIdLabel.TabIndex = 30;
            cursoIdLabel.Text = "Curso:";
            // 
            // EstudianteIdNumericUpDown
            // 
            this.EstudianteIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudianteIdNumericUpDown.Location = new System.Drawing.Point(111, 24);
            this.EstudianteIdNumericUpDown.Name = "EstudianteIdNumericUpDown";
            this.EstudianteIdNumericUpDown.Size = new System.Drawing.Size(171, 22);
            this.EstudianteIdNumericUpDown.TabIndex = 37;
            // 
            // CursoComboBox1
            // 
            this.CursoComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CursoComboBox1.FormattingEnabled = true;
            this.CursoComboBox1.Location = new System.Drawing.Point(111, 157);
            this.CursoComboBox1.Name = "CursoComboBox1";
            this.CursoComboBox1.Size = new System.Drawing.Size(171, 24);
            this.CursoComboBox1.TabIndex = 36;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(111, 77);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(171, 22);
            this.NombreTextBox.TabIndex = 35;
            // 
            // MatriculaTextBox
            // 
            this.MatriculaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatriculaTextBox.Location = new System.Drawing.Point(111, 119);
            this.MatriculaTextBox.Name = "MatriculaTextBox";
            this.MatriculaTextBox.Size = new System.Drawing.Size(171, 22);
            this.MatriculaTextBox.TabIndex = 34;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::SistemaEscuela.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(288, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 52);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuargar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(4, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 66);
            this.groupBox1.TabIndex = 28;
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // nombreErrorProvider
            // 
            this.nombreErrorProvider.ContainerControl = this;
            // 
            // MatriculaErrorProvider1
            // 
            this.MatriculaErrorProvider1.ContainerControl = this;
            // 
            // CursoErrorProvider
            // 
            this.CursoErrorProvider.ContainerControl = this;
            // 
            // Cursobutton
            // 
            this.Cursobutton.Location = new System.Drawing.Point(289, 157);
            this.Cursobutton.Name = "Cursobutton";
            this.Cursobutton.Size = new System.Drawing.Size(75, 23);
            this.Cursobutton.TabIndex = 38;
            this.Cursobutton.Text = "Cursos";
            this.Cursobutton.UseVisualStyleBackColor = true;
            this.Cursobutton.Click += new System.EventHandler(this.Cursobutton_Click);
            // 
            // rEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 267);
            this.Controls.Add(this.Cursobutton);
            this.Controls.Add(this.EstudianteIdNumericUpDown);
            this.Controls.Add(this.CursoComboBox1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.MatriculaTextBox);
            this.Controls.Add(estudianteIdLabel);
            this.Controls.Add(cursoIdLabel);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "rEstudiante";
            this.Text = "rEstudiante";
            this.Activated += new System.EventHandler(this.rEstudiante_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nombreErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatriculaErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursoErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown EstudianteIdNumericUpDown;
        private System.Windows.Forms.ComboBox CursoComboBox1;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox MatriculaTextBox;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuargar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ErrorProvider nombreErrorProvider;
        private System.Windows.Forms.ErrorProvider MatriculaErrorProvider1;
        private System.Windows.Forms.ErrorProvider CursoErrorProvider;
        private System.Windows.Forms.Button Cursobutton;
    }
}