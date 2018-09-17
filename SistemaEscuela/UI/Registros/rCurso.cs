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
    public partial class rCurso : Form
    {
        public rCurso()
        {
            InitializeComponent();
        }

        //Inicio metodos de soporte
        private void LimpiarCampos()
        {
            IDCursoNumericUpDown.Value = 0;
            DescripcionTextBox.Text = String.Empty;
            CantidadTextBox.Text = Convert.ToString(0);
        }

        private Curso LlenaCurso()
        {
            Curso curso = new Curso();
            curso.CursoId =(int) IDCursoNumericUpDown.Value;
            curso.Descripcion = DescripcionTextBox.Text;
            if (string.IsNullOrEmpty(CantidadTextBox.Text))
            {
                curso.Cantidad = 0;
            }
            else
            {
                curso.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
            }
            
            return curso;

        }

        private void LlenaCampos(Curso curso)
        {
            IDCursoNumericUpDown.Value = curso.CursoId;
            DescripcionTextBox.Text = curso.Descripcion;
            CantidadTextBox.Text = Convert.ToString(curso.Cantidad);

        }

        private bool Validar()
        {
            bool paso = true;
            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                MessageBox.Show("Introduzca la descripcion");
                paso = false;

            }

            return paso;
        }
        //Fin metodos de soporte

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = (int)IDCursoNumericUpDown.Value;
            if (id>0)
            {
                Curso curso = CursoBLL.Buscar(id);
                if (curso != null)
                {
                    LlenaCampos(curso);
                    MessageBox.Show("Registros encontrados!");
                }
                else
                {
                    LimpiarCampos();
                    MessageBox.Show("Registro no encontrado!");
                    
                }
            }
            else
            {
                MessageBox.Show("Introduca un id");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuargar_Click(object sender, EventArgs e)
        {
            int id = (int)IDCursoNumericUpDown.Value;
            bool paso = false;
            if (Validar())
            {
                Curso curso = LlenaCurso();
                if (id == 0)
                {
                    paso = CursoBLL.Guardar(curso);
                }
                else
                {
                    paso = CursoBLL.Modificar(curso);
                }
                if (paso)
                {
                    if (id == 0)
                    {
                        MessageBox.Show("Guardado Correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("Modificado Correctamente!");
                    }
                }
                else
                {
                    MessageBox.Show("Error al intentar guardar o modificar");
                }

            }
        }
    }
}
