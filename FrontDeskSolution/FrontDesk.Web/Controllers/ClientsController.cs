﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using FrontDesk.Web.Models;

namespace FrontDesk.Web.Controllers
{
    public class ClientsController : ApiController
    {
        // GET api/values
        public IEnumerable<ClientViewModel> Get()
        {
            return new ClientViewModel[] { 
                new ClientViewModel() {
                    //ClientId= Guid.Empty,
                    Name="Steve Smith"
                    //Patients = new List<PatientViewModel>()
                    //{
                    //    //new PatientViewModel()
                    //    //{
                    //    //    Name="Darwin",
                    //    //    PatientId=Guid.Empty,
                    //    //    PhotoUrl="darwin.jpg"
                    //    //}
                    //}
                },
                new ClientViewModel() { Name="Julie" }
            };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}