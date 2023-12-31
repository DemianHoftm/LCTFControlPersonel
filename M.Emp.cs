using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCTFControlPersonal
{
    public partial class M : Form
    {
        public List<string> Empleados;
        public string path = "Base.txt";

        public M()
        {
            InitializeComponent();
            Empleados = new List<string>();
            this.Leer();
            foreach (string actual in Empleados) { lista_empleado.Items.Add(actual); }
        }

        //boton de guardar
        private void button1_Click(object sender, EventArgs e)
        {
            string guardar = Nombre.Text + " " + Apellido.Text;
            lista_empleado.Items.Add(guardar);
            Nombre.Text = "";
            Apellido.Text = "";
        }
        //Borrar
        private void Borrar_Click(object sender, EventArgs e)
        {
            if (lista_empleado.SelectedItems.Count > 0) {
                foreach (ListViewItem actual in lista_empleado.SelectedItems)
                {
                    lista_empleado.Items.Remove(actual);
                }
            }
        }

        public void Leer() {
            Empleados.Clear();
            if (!File.Exists(path))
            {                
               using(FileStream fs = File.Create(path)) ;
            }
            

            try {
                using (StreamReader lecto = new StreamReader(path)) {
                    string auxiliar = "";
                    while ((auxiliar = lecto.ReadLine()) != null) {
                        Empleados.Add(auxiliar);
                    }
                }
            } catch (IOException exep) {
                return;
            }
       
        }
        private void escribir()
        {
           
            using (StreamWriter escriba = new StreamWriter(path))
            {
                foreach (ListViewItem actual in lista_empleado.Items)
                {
                    escriba.WriteLine(actual.Text) ;
                }               
            }
        }

        private void M_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.escribir();
        }
    }
}
