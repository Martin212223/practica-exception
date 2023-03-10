using LibMedico.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico(txtIngresoNombre.Text);

                MessageBox.Show(medico.Nombre);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtIngresoNombre.Text = "";
            }
        }
    }
}
