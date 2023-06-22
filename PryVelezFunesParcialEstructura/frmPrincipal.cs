using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryVelezFunesParcialEstructura
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        clsListaDoble ListaDoble = new clsListaDoble();
        private void cmdEliminar_Click_1(object sender, EventArgs e)
        {
            if (ListaDoble.Primero != null)
            {
                Int32 NumeroLegajo = Convert.ToInt32(cbNumeroLegajo.Text);
                ListaDoble.Eliminar(NumeroLegajo);
                ListaDoble.RecorrerAsc(GrillaListaDoble);
                ListaDoble.RecorrerAsc(cbNumeroLegajo);
            }
            cbNumeroLegajo.SelectedIndex = -1;
            cmdEliminar.Enabled = false;
        }
        private void cmdAgregar_Click_1(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.NumeroLegajo = Convert.ToInt32(mskNumeroLegajoNE.Text);
            objNodo.NombreCompleto = txtNombreCompletoNE.Text;
            objNodo.Categoria = mskCategoriaNE.Text;
            objNodo.SueldoBasico = Convert.ToInt32(mskSueldoBasicoNE.Text);
            ListaDoble.Agregar(objNodo);
            ListaDoble.RecorrerAsc(cbNumeroLegajo);
            mskNumeroLegajoNE.Text = "";
            txtNombreCompletoNE.Text = "";
            mskCategoriaNE.Text = "";
            mskSueldoBasicoNE.Text = "";
            mskNumeroLegajoNE.Focus();
        }
        private void cbNumeroLegajo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cbNumeroLegajo.SelectedIndex != -1)
            {
                cmdEliminar.Enabled = true;
            }
        }
        private void txtNombreCompletoNE_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void optTodosEmpleados_CheckedChanged_1(object sender, EventArgs e)
        {
            if (optTodosEmpleados.Checked == true || mskSueldo.Text != "")
            {
                cmdListar.Enabled = true;

            }
            else
            {
                cmdListar.Enabled = false;
            }
        }
        private void cmdListar_Click_1(object sender, EventArgs e)
        {
            if (optAscendete.Checked == true || optDescendente.Checked == true)
            {
                GrillaListaDoble.Rows.Clear();
                if (optTodosEmpleados.Checked == true)
                {
                    if (optAscendete.Checked == true)
                    {
                        ListaDoble.RecorrerAsc(GrillaListaDoble);
                    }
                    else
                    {
                        ListaDoble.RecorrerDes(GrillaListaDoble);
                    }
                }
                if (optTodosEmpleados.Checked == false)
                {

                    Int32 Sueldo = Convert.ToInt32(mskSueldo.Text);
                    if (optAscendete.Checked == true)
                    {
                        ListaDoble.RecorrerPorSueldoAsc(GrillaListaDoble, Sueldo);
                    }
                    else
                    {
                        ListaDoble.RecorrerPorSueldoDes(GrillaListaDoble, Sueldo);
                    }
                }
            }
            else
            {
                MessageBox.Show("No olvides elegir si quieres los datos ordenados de forma ascendente o descendente");
            }
        }
        private void mskSueldo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void Chequeo()
        {
            if (mskNumeroLegajoNE.Text != "" & txtNombreCompletoNE.Text != "" & mskSueldoBasicoNE.Text != "" & mskCategoriaNE.Text != "")
            {
                cmdAgregar.Enabled = true;
            }
            else
            {
                cmdAgregar.Enabled = false;
            }
        }
        private void mskNumeroLegajoNE_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }

        private void txtNombreCompletoNE_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }

        private void mskCategoriaNE_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }

        private void mskSueldoBasicoNE_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }

        private void mskSueldo_TextChanged(object sender, EventArgs e)
        {
            if (optTodosEmpleados.Checked == true || mskSueldo.Text != "")
            {
                cmdListar.Enabled = true;
            }
            else
            {
                cmdListar.Enabled = false;
            }
        }
    }
}
