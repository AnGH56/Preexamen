using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Preexamen.Controller;

namespace Preexamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        ControllerAlumno calumno = new ControllerAlumno();

        void LimpiarTexTbox(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (calumno.Insertar(Convert.ToInt32(txtMatricula.Text),txtNombre.Text, txtApellido.Text, Convert.ToString(dtpikrFechaNac.Value), txtCorreo.Text))
                {
                    MessageBox.Show("El alumno se agregó con éxito");
                    LimpiarTexTbox(this);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = calumno.ObtenerAlumnos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                lblEliminar.Visible = false;
                txtEliminar.Visible = false;
                okeliminar.Visible = false;

                lblActualizar.Visible = true;
                txtActualizar.Visible = true;
                okactualizar.Visible = true;
                MessageBox.Show("Vuelve a llenar el formulario con los mismo campos \n" +
                        " y al terminar vuelve a dar clic en 'OK' <3");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error:(");
                throw;
            }
        }
        private void okactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                bool siactualiza = calumno.Actualizar(
                    txtNombre.Text,
                    txtApellido.Text,
                    dtpikrFechaNac.Value.ToString("yyyy-MM-dd"),
                    txtCorreo.Text,
                    Convert.ToInt32(txtActualizar.Text)
                );

                if (siactualiza)
                {
                    MessageBox.Show("El alumno se actualizó con éxito");
                    LimpiarTexTbox(this);
                }
                else
                {
                    MessageBox.Show("Hubo un eorror:(");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                lblActualizar.Visible = false;
                txtActualizar.Visible = false;
                okactualizar.Visible = false;

                lblEliminar.Visible = true;
                txtEliminar.Visible = true;
                okeliminar.Visible = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void okeliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (calumno.Eliminar(Convert.ToInt32(txtEliminar.Text)))
                {
                    MessageBox.Show("El alumno se eliminó con éxito");
                }
                else
                {
                    MessageBox.Show("Hubo un eorror:(");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
