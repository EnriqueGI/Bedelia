using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bedelias
{
    public partial class Form1 : Form
    {

        Estudiante[] listaEstudiantes = new Estudiante[4];
        int poss = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textCedula.Text =="" || textNombre.Text == "" || textEdad.Text == "" ||
                textN1.Text == "" || textN2.Text == "" || textN3.Text == "" ||
                textN4.Text == "")
            {
              DialogResult resultado =  MessageBox.Show("Faltan ingresar datos","Atención",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Information);
            
            if(resultado == DialogResult.Abort)
                {
                    Limpiar();

                }
                if (resultado == DialogResult.Ignore)
                {
                    Cargar();
                    Limpiar();
                }

            }
            else
            {
                Cargar();
              
            }
            
        }

        public void Limpiar()
        {
            textCedula.Text = "";
            textNombre.Text = "";
            textEdad.Text = "";
            textN1.Text = "";
            textN2.Text = "";
            textN3.Text = "";
            textN4.Text = "";
        }
        public void Cargar()
        {
            bool estado = true;
            Estudiante e = new Estudiante();
            e.Cedula = Convert.ToInt32(textCedula.Text);
            e.Nombre = textNombre.Text;
            e.Edad = Convert.ToInt32(textEdad.Text);

            int[] n = new int[4];

            // NOTA 1

            if (e.ValidarNota(Convert.ToInt32(textN1.Text))){
                n[0] = Convert.ToInt32(textN1.Text);
           
            }
            else
            {
                
                labelN1.Text = "X";
                labelN1.BackColor = Color.Red;
                estado =false;
            }

            //NOTA 2
            if (e.ValidarNota(Convert.ToInt32(textN2.Text)))
            {
                n[0] = Convert.ToInt32(textN1.Text);

            }
            else
            {

                labeN2.Text = "X";
                labeN2.BackColor = Color.Red;
                estado = false;
            }
            // NOTA 3
            if (e.ValidarNota(Convert.ToInt32(textN3.Text)))
            {
                n[0] = Convert.ToInt32(textN1.Text);

            }
            else
            {

                labelN3.Text = "X";
                labelN3.BackColor = Color.Red;
                estado = false;
            }
            //NOTA 4
            if (e.ValidarNota(Convert.ToInt32(textN4.Text)))
            {
                n[0] = Convert.ToInt32(textN1.Text);

            }
            else
            {

               labelN6.Text = "X";
                labelN6.BackColor = Color.Red;
                estado = false;
            }

            e.Notas = n;
            if (estado)
            {
                listaEstudiantes[poss] = e;
                poss++;
                // se crea una instancia de la case ListViewItems y se cargan los valores

                ListViewItem itemAgregar = new ListViewItem();

                itemAgregar.Text = e.Cedula.ToString();
                itemAgregar.SubItems.Add(e.Nombre);
                itemAgregar.SubItems.Add(e.Edad.ToString());
                itemAgregar.SubItems.Add(e.Notas[0].ToString());
                itemAgregar.SubItems.Add(e.Notas[1].ToString());
                itemAgregar.SubItems.Add(e.Notas[2].ToString());
                itemAgregar.SubItems.Add(e.Notas[3].ToString());
                listView1.Items.Add(itemAgregar);


                MessageBox.Show("Se cargaron los datos");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
