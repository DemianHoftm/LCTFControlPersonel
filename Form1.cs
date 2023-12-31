using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.tool.xml;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf.parser;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Imaging;
using System.Globalization;
namespace LCTFControlPersonal
{
    public partial class Form1 : Form
    {
        public M emp_modu;
        public Form1()
        {
            InitializeComponent();
            emp_modu = new M();
            fecha.CustomFormat = "MM/yyyy";

        }

        private void Boton_empleados_Click(object sender, EventArgs e)
        {
            emp_modu.ShowDialog();
        }

        private void reporte_Click(object sender, EventArgs e)
        {
            string tablas = "";
            string relleno_tab = "";
            CultureInfo ci = new CultureInfo("es-ES");
            DateTime fecha_avance = new DateTime(fecha.Value.Year, fecha.Value.Month, 01);
            //esto es para crear el rango de empleados
            foreach (string actu in emp_modu.Empleados) {
                relleno_tab = relleno_tab + Properties.Resources.tabla_relleno_emp.ToString();
                relleno_tab = relleno_tab.Replace("@nombre", actu);
            }
            string backup = "";
            while (fecha_avance.Month == fecha.Value.Month) {
                backup = tablas;
                tablas = tablas + Properties.Resources.tabla_cuerpo.ToString();
                for (int i = 1; i < 7; i = i) {
                    if (fecha_avance.DayOfWeek != DayOfWeek.Sunday)
                    {
                        tablas = tablas.Replace(("@dia" + i.ToString()), (ci.DateTimeFormat.GetDayName(fecha_avance.DayOfWeek) + " " + fecha_avance.Day.ToString()));
                        i = i + 1;
                    }
                    if (fecha_avance.Month != fecha.Value.Month) {
                        tablas = backup;
                        goto prosiga;
                    }
                    fecha_avance = fecha_avance.AddDays(1);
                }
                tablas = tablas.Replace("@relleno", relleno_tab);
                
            
            }
            prosiga:
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = ".pdf";
            sfd.Filter = "PDF Files|*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK) {
                using (FileStream tira = new FileStream(sfd.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4);
                    PdfWriter escriba = PdfWriter.GetInstance(doc, tira);
                    doc.Open();
                    using (StringReader sr = new StringReader(tablas))
                    {
                        //lo combierto a un doc
                        XMLWorkerHelper.GetInstance().ParseXHtml(escriba, doc, sr);

                    }
                    doc.Close();
                    tira.Close();
                }

                MessageBox.Show("Proceso terminado");
            }
        }
    }
}
