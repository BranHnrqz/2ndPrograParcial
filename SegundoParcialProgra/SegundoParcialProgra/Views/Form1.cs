using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegundoParcialProgra.Negocio;

namespace SegundoParcialProgra
{
    public partial class Form1 : Form
    {
        clsGestionEstudiante GS = new clsGestionEstudiante();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtLastName.Clear();
            txtCarrer.Clear();
            txtSignature.Clear();
            txtProm1.Clear();
            txtProm2.Clear();
            txtProm3.Clear();
        }

        public void ClearRg()
        {
            txtName.Clear();
            txtLastName.Clear();
            txtCarrer.Clear();
            txtSignature.Clear();
            txtProm1.Clear();
            txtProm2.Clear();
            txtProm3.Clear();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            double PromedioFinal = GS.CalcPromFnl(Convert.ToDouble(txtProm1.Text), Convert.ToDouble(txtProm2.Text), Convert.ToDouble(txtProm3.Text) / 3);
            GS.StudentReg(txtName.Text, txtLastName.Text, txtCarrer.Text, txtSignature.Text, Convert.ToDouble(txtProm1.Text), Convert.ToDouble(txtProm2.Text), Convert.ToDouble(txtProm3.Text), PromedioFinal);
            dgvEstudiante.DataSource = GS.ViewStudents();
            ClearRg();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void LimpiarDGV()
        {
            dgvEstudiante.Columns.Clear();
        }

        public void MostrarDGV()
        {
            dgvEstudiante.DataSource = GS.ViewStudents();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarDGV();
        }

        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Solo Decimales", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 ||
                e.KeyChar >= 123 && e.KeyChar <= 255
                )
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


    }
}
