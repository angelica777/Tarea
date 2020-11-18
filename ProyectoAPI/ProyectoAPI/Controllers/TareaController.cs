using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoAPI.Entidades;
using ProyectoAPI.accessdata;
using System.Data;

using MySql.Data.MySqlClient;

namespace ProyectoAPI.Controllers
{
    [Route("api/tarea")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        // GET: api/Tarea
        [HttpGet]
        public IEnumerable<Tarea> Get()
        {

            List<Tarea> lista = new List<Tarea>();

            conexion con = new conexion();
            DataTable datos = con.EjecutarConsulta("select *from tarea",CommandType.Text);
            foreach(DataRow idatos in datos.Rows)
            {
                lista.Add(new Tarea()
                {
                    nombreTarea = idatos["nombreTarea"].ToString(),
                    descripcion = idatos["descripcion"].ToString(),
                    prioridad = idatos["prioridad"].ToString(),
                    estado = idatos["estado"].ToString()
                });
            }
            IEnumerable<Tarea> tareas = lista;
            return tareas;
        }


   
        // GET: api/Tarea/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tarea
        [HttpPost]
        public void Post([FromBody] Tarea value)
        {
            conexion con = new conexion();
            List<MySqlParameter> ListaParametros = new List<MySqlParameter>();
            ListaParametros.Add(new MySqlParameter()
            {
                 Direction = ParameterDirection.Input,
                 ParameterName = "nombre",
                 Value =value.nombreTarea
            });
            ListaParametros.Add(new MySqlParameter()
            {
                Direction = ParameterDirection.Input,
                ParameterName = "descripcion",
                Value = value.descripcion,
            });

            ListaParametros.Add(new MySqlParameter()
            {
                Direction = ParameterDirection.Input,
                ParameterName = "prioridad",
                Value = value.prioridad


            });

            ListaParametros.Add(new MySqlParameter()
            {
                Direction = ParameterDirection.Input,
                ParameterName = "estado",
                Value = value.estado 
            });
            con.EjecutarOperacion("registrar_tarea",ListaParametros, CommandType.StoredProcedure);
        }

        // PUT: api/Tarea/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
