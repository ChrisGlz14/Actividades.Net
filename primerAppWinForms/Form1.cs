using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerAppWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido a tu HOLA MUNDO");
            cbSeniority.Items.Add("Trainee");
            cbSeniority.Items.Add("Junior");
            cbSeniority.Items.Add("Semi-Senior");
            cbSeniority.Items.Add("Senior");
        }




        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Hasta la Proximaaaaaaaaaaa");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string elem = txtElements.Text;
            lvElements.Items.Add(elem);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSaludo_Click(object sender, EventArgs e)
        {

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtElements.Text;
           string fechaNacimiento = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd");

            
            //Operador ternario
            string conformidad = cbConformidad.Checked == true ? "Estas conforme con tu Salario" : "No estas conforme con tu salario";
            string estadoCivil;
            if (rbtn1Casado.Checked)
            {
               estadoCivil = "Casado";    
            } else
            {
               estadoCivil = "Soltero";
            }

            string seniority = cbSeniority.SelectedItem.ToString();

            string añosSenority = numAñosExperiencia.Value.ToString();

            MessageBox.Show(" Nombre: " + nombre + ", Fecha de Nacimiento:  " + fechaNacimiento + ",  conformidad " + conformidad + ", Estado Civil: " + estadoCivil + ", Señority de: " + nombre + " es de: " + añosSenority + " Año/s");
        }

    }
}
