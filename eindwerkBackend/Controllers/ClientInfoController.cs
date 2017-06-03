﻿using eindwerkBackend.EF;
using eindwerkBackend.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace eindwerkBackend.Controllers
{
    public class ClientInfoController : ApiController
    {
        public IEnumerable<ClientInfo> Get()
        {
            List<ClientInfo> result = new List<ClientInfo>();

            using (var context = new EindwerkBackendContext())
            {
                result = context.ClientInfo.ToList();
            }
            return result;
        }

        // GET api/values/5
        public ClientInfo Get(int id)
        {
            var result = new ClientInfo();
            using (var context = new EindwerkBackendContext())
            {
                result = context.ClientInfo.FirstOrDefault(c => c.Id == id);
            }
            return result;
        }

        // POST api/values
        public ClientInfo Post([FromBody] ClientInfo clientInfo)
        {
            var result = new ClientInfo();
            using (var context = new EindwerkBackendContext())
            {

                result = context.ClientInfo.Add(clientInfo);
                context.SaveChanges();
            }
            return result;

        }

        // DELETE api/values/5
        public async System.Threading.Tasks.Task<ClientInfo> DeleteAsync([FromBody]int id)
        {
            var result = new ClientInfo();
            using (var context = new EindwerkBackendContext())
            {
              
                result = await context.ClientInfo.SingleOrDefaultAsync(c => c.Id == id);
                context.ClientInfo.Remove(result);
                context.SaveChanges();

            }

            return result;
        }
    }

 }
