using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void EditarTarea_Click(object sender, EventArgs e)
        {
           string editar= "UPDATE tarea SET nombreTarea = "+textBox1+", Descripcion="+textBox2+", prioridad="+textBox3+" WHERE id = "+textBox4+"";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void AgregarEtiqueta_Click(object sender, EventArgs e)
        {
            var url = $"https://localhost:5001/api/tarea";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);
                            List<tarea> listadetareas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<tarea>>(responseBody);

                            DataTable dt = new DataTable();
                            dt.Columns.Add("nombreTarea");
                            dt.Columns.Add("Descripcion");
                            dt.Columns.Add("Prioridad");
                            dt.Columns.Add("estado");

                            foreach(tarea itarea in listadetareas)
                            {
                                DataRow row = dt.NewRow();
                                row["nombreTarea"] = itarea.nombreTarea;
                                row["Descripcion"] = itarea.descripcion;
                                row["Prioridad"] = itarea.prioridad;
                                row["estado"] = itarea.estado;
                                dt.Rows.Add(row);

                            }

                            this.dataGridView1.DataSource = dt;
                            

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
        }
    }
}
