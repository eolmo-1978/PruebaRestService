using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InvitacionEventos.Models;

namespace InvitacionEventos.Controllers
{
    public class RsvpController : ApiController
    {
        [HttpGet]
        public IEnumerable<Invitaciones> GetAttendees()
        {
            return Repository.Responses.Where(x => x.Asistira == true);
        }
        [HttpPost]
        public void PostResponse(Invitaciones response)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(response);
            }
        }
    }
}
