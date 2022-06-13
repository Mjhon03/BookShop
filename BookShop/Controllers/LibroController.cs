using BookShop.Models;
using BookShop.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {

        BaseData db = new BaseData();
        

        [HttpGet]
        public string Get()
        {
            string sql = "select * from Libro";
            DataTable table = db.getTable(sql);
            string json = JsonConvert.SerializeObject(table);
            return json;
        }

        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
        [HttpPost]
        public string Post([FromBody] Libro libros  )
        {
            string sql = $"insert into Libro (nombre, autor, cantPaginas, fechaLanzamiento, genero) values ('"+ libros.nombre + "','"+ libros.autor + "', '"+ libros.cantPaginas + "', '"+ libros.fechaLanzamiento + "', '"+ libros.genero + "')";
            return db.executeSql(sql);
        }

        
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Libro libros)
        {
            string sql = $"update Libro set nombre = '{libros.nombre}', autor = '{libros.autor}', cantPaginas = {libros.cantPaginas}, fechaLanzamiento = '{libros.fechaLanzamiento}', genero = '{libros.genero}' where idLibro = {id}";
            return db.executeSql(sql);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string sql = "delete from Libro where idLibro = " + id + "";
            return db.executeSql(sql);
        }
    }
}
