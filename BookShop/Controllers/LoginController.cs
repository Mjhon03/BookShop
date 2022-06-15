using BookShop.Models;
using Microsoft.AspNetCore.Mvc;
using BookShop.Models.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        BaseData db = new BaseData();      
        [HttpPost]
        public string Post([FromBody]Usuarios client)
        {
            string sql = "select nombres, apellidos, documento, correo, direccion, fechaNacimiento, librosEncargados from Cliente where correo = '"+client.correo+"' and contrasenna = '"+client.contrasenna+"';";
            DataTable table = db.getTable(sql);
            string json = JsonConvert.SerializeObject(table);
            return json;
        }
    }
}
