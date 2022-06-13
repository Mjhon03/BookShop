using BookShop.Models;
using BookShop.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;

namespace BookShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        BaseData db = new BaseData();
        
       
        [HttpGet]
        public string Get()
        {
            string sql = "select id, nombres, apellidos, documento, correo, direccion, fechaNacimiento, librosEncargados from Cliente";
            var table = db.getTable(sql);
            var json = JsonConvert.SerializeObject(table);
            return json;

        }

        [HttpPost("/Buscador")]
        public string Buscador([FromBody] Usuarios cliente)
        {
            string sql = "";
            DataTable table = db.getTable(sql);
            var json = JsonConvert.SerializeObject(table);
            return json;
        }

        
        [HttpPost]
        public string Post([FromBody]Usuarios cliente)
        {
            string sql = "insert into cliente (nombres, apellidos, documento, correo, contrasenna, direccion, fechaNacimiento) values ('"+cliente.nombres+"','"+cliente.apellidos+"','"+cliente.documento+"','"+cliente.correo+"','"+cliente.contrasenna+"','"+cliente.direccion+"','"+cliente.fechaNacimento+"');";
            return db.executeSql(sql);
        }

        
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Usuarios cliente)
        {
            string sql = "update cliente set nombres = '"+cliente.nombres+"', apellidos = '"+cliente.apellidos+"', documento = '"+cliente.documento+"', correo = '"+cliente.documento+"', contrasenna = '"+cliente.contrasenna+"', direccion = '"+cliente.direccion+"', fechaNacimiento = '"+cliente.fechaNacimento+"' where id = '"+id+"'";
            return db.executeSql(sql);
        }

        
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string sql = "delete from cliente where id = "+id+"";
            return db.executeSql(sql);
        }
    }
}
