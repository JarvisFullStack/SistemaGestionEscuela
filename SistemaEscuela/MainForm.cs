using SistemaEscuela.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscuela
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiante restudiante = new rEstudiante();
            restudiante.MdiParent = this;
            restudiante.Show();

        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCurso rcurso = new rCurso();
            rcurso.MdiParent = this;
            rcurso.Show();
        }
    }
}
