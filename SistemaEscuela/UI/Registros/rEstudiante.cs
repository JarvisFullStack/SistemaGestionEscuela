using SistemaEscuela.BLL;
using SistemaEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscuela.UI.Registros
{
    public partial class rEstudiante : Form
    {
        public rEstudiante()
        {
            InitializeComponent();
            LlenarCombobox();
        }
        //Inicio de metodos de respaldo
        private void LlenarCombobox()
        {
            CursoComboBox1.DataSource = CursoBLL.GetList(x=>true);
            CursoComboBox1.ValueMember = "CursoId";
            CursoComboBox1.DisplayMember = "Descripcion";
        }

        private Estudiante LlenaEstudiante()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.EstudianteId = (int)EstudianteIdNumericUpDown.Value;
            estudiante.Nombre = NombreTextBox.Text;
            estudiante.Matricula = MatriculaTextBox.Text;
            estudiante.CursoId = (int)CursoComboBox1.SelectedValue;
            return estudiante;
        }

        private void LlenaCampos(Estudiante estudiante)
        {
            EstudianteIdNumericUpDown.Value = estudiante.EstudianteId;
            NombreTextBox.Text = estudiante.Nombre;
            MatriculaTextBox.Text = estudiante.Matricula;
            CursoComboBox1.SelectedValue = estudiante.CursoId;

        }

        public bool GuardarValidar()
        {
            bool paso = true;
            if(string.IsNullOrWhiteSpace(NombreTextBox.Text) || string.IsNullOrWhiteSpace(MatriculaTextBox.Text) || string.IsNullOrWhiteSpace(CursoComboBox1.SelectedItem.ToString()) )
            {
                if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
                {
                    nombreErrorProvider.SetError(NombreTextBox, "Introduzca un valor");
                    MessageBox.Show("El campo nombre no puede estar vacio");
                }
                if (string.IsNullOrWhiteSpace(MatriculaTextBox.Text))
                {
                    MatriculaErrorProvider1.SetError(NombreTextBox, "Introduzca un valor");
                    MessageBox.Show("El campo matricula no puede estar vacio");
                }
                if (string.IsNullOrWhiteSpace(CursoComboBox1.Text))
                {
                   
                    MessageBox.Show("Debe crear un curso previamente.");
                }


                paso = false;
            }

            return paso;

        }

        private bool Existe(int id)
        {
            return (EstudianteBLL.Buscar(id) != null);
        }

        private void LimpiarCampos()
        {
            LimpiarProvider();
            EstudianteIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            MatriculaTextBox.Text = string.Empty;
            CursoComboBox1.SelectedIndex = 0;
        }

        private void LimpiarProvider()
        {
            nombreErrorProvider.Clear();
            MatriculaErrorProvider1.Clear();
            CursoErrorProvider.Clear();
        }

        //fin de metodos de respaldo

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuargar_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Estudiante estudiante = new Estudiante();
            if (GuardarValidar())
            {
                estudiante = LlenaEstudiante();
                if(EstudianteIdNumericUpDown.Value == 0)
                {
                    paso = EstudianteBLL.Guardar(estudiante);

                }
                else
                {
                    if (Existe(estudiante.EstudianteId))
                    {
                        paso = EstudianteBLL.Modificar(estudiante);
                    }
                }

                if (paso)
                {
                    if (EstudianteIdNumericUpDown.Value == 0)
                    {
                        MessageBox.Show("Registro Guardado!","Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro Modificado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LimpiarCampos();

            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Estudiante estudiante = new Estudiante();
            int valor = (int)EstudianteIdNumericUpDown.Value;
            if (valor > 0)
            {
                estudiante = EstudianteBLL.Buscar(valor);
                if(estudiante != null)
                {
                    paso = EstudianteBLL.Eliminar(valor);

                }
                if (paso)
                {
                    MessageBox.Show("Estudiante: "+estudiante.Nombre + " Eliminado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al intentar eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Introduzca el id", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            int valor = (int)EstudianteIdNumericUpDown.Value;
            if (valor > 0)
            {
                estudiante = EstudianteBLL.Buscar(valor);
                if (estudiante != null)
                {
                    LlenaCampos(estudiante);
                    MessageBox.Show("Registro Encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    LimpiarCampos();
                    MessageBox.Show("Registro no encontrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }

            }
            else
            {
                MessageBox.Show("Introduzca un id valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cursobutton_Click(object sender, EventArgs e)
        {
            rCurso rcurso = new rCurso();
            rcurso.MdiParent = MainForm.ActiveForm;
            rcurso.Show();
        }

        private void rEstudiante_Activated(object sender, EventArgs e)
        {
            LlenarCombobox();
        }
    }
}
