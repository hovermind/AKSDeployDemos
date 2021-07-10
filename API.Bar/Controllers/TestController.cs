﻿using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace API.Bar.Controllers
{
    [Route("test")]
    public class TestController : BarBaseApiController
    {
        [HttpGet("")]
        public string Index()
        {
            return $@"{{ ""scope"" : ""{ Assembly.GetAssembly(GetType()).GetName().Name}"", ""controller-name"" : ""{GetType().Name}"", ""method-name"" : ""{MethodBase.GetCurrentMethod().Name}"" }}";
        }

        [HttpGet("xyz/{id:int?}")]
        public string Xyz(int? id)
        {
            return $@"{{ ""scope"" : ""{ Assembly.GetAssembly(GetType()).GetName().Name}"", ""controller-name"" : ""{GetType().Name}"", ""method-name"" : ""{MethodBase.GetCurrentMethod().Name}"", ""Id"" : ""{id}"" }}";
        }
    }
}
