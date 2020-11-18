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
            var url = $"https://localhost:5001/api/tarea";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            

        }

        private void EditarTarea_Click(object sender, EventArgs e)
        {

            var url = $"https://localhost:5001/api/tarea";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            tarea tarea = new tarea();

            string dato = tarea.idTarea;
           

            if (dataGridView1.SelectedRows.Equals(dato))
            {
                try
                {
                    textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                   // dataGridView1.DataSource
            }
                catch (WebException ex)
                {
                    Console.WriteLine("error al cargar los datos");
                }
            }
            DataTable dt = new DataTable();

           
            
            tarea.nombreTarea = textBox1.Text;
            tarea.descripcion = textBox2.Text;
            tarea.prioridad = textBox3.Text;
            tarea.estado = textBox4.Text;
            tarea.responsable = textBox5.Text;

            string jsondata = Newtonsoft.Json.JsonConvert.SerializeObject(tarea);
            byte[] byteArray = Encoding.UTF8.GetBytes(jsondata);

            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();

            

            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            using (dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
            }

            // Close the response.
            response.Close();
            // textBox1.Text=nombreTarea


            //    this.dataGridView1.DataSource = dt;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void AgregarEtiqueta_Click(object sender, EventArgs e)   //consultar
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
                            dt.Columns.Add("fk_responsable");

                            foreach (tarea itarea in listadetareas)
                            {
                                DataRow row = dt.NewRow();
                                row["nombreTarea"] = itarea.nombreTarea;
                                row["Descripcion"] = itarea.descripcion;
                                row["Prioridad"] = itarea.prioridad;
                                row["estado"] = itarea.estado;
                                row["fk_responsable"] = itarea.responsable;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
