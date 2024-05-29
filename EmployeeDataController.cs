using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Aps.NetFirstWebApi.Controllers
{
    public class EmployeeDataController : ApiController
    {
        //  By Default Asp.Net Web Api return XML formate data
        string[] myEmployee = { "ani", "Anish", "Ram" };
        [HttpGet]  //By default
        public string[] GetEmployee() 
        {
            //return new string[] {}
            return myEmployee;
        }
        public string GetEmployeeByIndex(int id)
        {
            return myEmployee[id];
        }
    }
}
