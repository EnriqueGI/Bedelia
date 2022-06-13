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
    public partial class FormDocente : Form
    {
        Materia[] listaMaterias = new Materia[4];
        Docente[] listDocentes = new Docente[4];
        int poss = 0;
        public FormDocente()
        {
            InitializeComponent();
        }

        private void FormDocente_Load(object sender, EventArgs e)
        {

            Materia m1 = new Materia();
            m1.Nombre = "Programción III";
            listaMaterias[0] = m1;
            Materia m2 = new Materia();
            m2.Nombre = "Base de Datos";
            listaMaterias[1] = m2;
            Materia m3 = new Materia();
            m3.Nombre = "Proyecto";
            listaMaterias[2] = m3;
            Materia m4 = new Materia();
            m4.Nombre = "Sistemas Operativos III";
            listaMaterias[3] = m4;


            foreach (Materia m in listaMaterias)
            {
                comboBox1.Items.Add(m.Nombre);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(comboBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = listBox1.SelectedIndex; // Obtenemos el índice seleccionado
            listBox1.Items.RemoveAt(x); // borramos el índice.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (poss < 4)
            {
                Docente d = new Docente();
                d.Cedula = Convert.ToInt32(textCedula.Text);
                d.Nombre = textNombre.Text;
                d.Edad = Convert.ToInt32(textEdad.Text);
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    foreach (Materia m in listaMaterias)
                    {
                        if (m.Nombre == listBox1.Items[i].ToString())
                        {
                            d.CargarMteria(m);
                        }
                    }

                }
                listDocentes[poss] = d;
                poss++;
                Cargar();
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pude cargar más docentes");
            }
        }

        public void Cargar()
        {


            // se crea una instancia de la case ListViewItems y se cargan los valores
            listView1.Items.Clear();

            foreach (Docente d in listDocentes)
            {
                if (d != null)
                {
                    ListViewItem itemAgregar = new ListViewItem();

                    itemAgregar.Text = d.Cedula.ToString();
                    itemAgregar.SubItems.Add(d.Nombre);
                    itemAgregar.SubItems.Add(d.Edad.ToString());
                    listView1.Items.Add(itemAgregar);
                }



            }
            MessageBox.Show("Se cargaron los datos");
        }

      

        // limpiar 

        public void Limpiar()
        {
            textCedula.Text = "";
            textNombre.Text = "";
            textEdad.Text = "";
            listBox1.Items.Clear();
            listBoxMostrarM.Visible = false;
        }

        // mostramos las materias que dicta cada docente 
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            listBoxMostrarM.Items.Clear();

            listBoxMostrarM.Visible = true;
            foreach (Docente d in listDocentes)
  
                if (d != null)
                {
                    if (listView1.SelectedItems[0].Text == d.Cedula.ToString())
                    {
                        foreach (Materia m in d.listaMaterias())
                        {
                            if (m != null)
                            {
                                listBoxMostrarM.Items.Add(m.Nombre);
                            }


                        }
                    }
                }

            
        }
    }
}