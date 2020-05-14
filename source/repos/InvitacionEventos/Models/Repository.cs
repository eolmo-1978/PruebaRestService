using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvitacionEventos.Models
{
    public class Repository
    {
        private static Dictionary<string, Invitaciones> responses;
        static Repository()
        {
            responses = new Dictionary<string, Invitaciones>();
            responses.Add("Alberto", new Invitaciones
            {
                Nombre = "Alberto",
                Email = "alberto@ejemplo.com",
                Asistira = true
            });
            responses.Add("Alicia", new Invitaciones
            {
                Nombre = "Alicia",
                Email = "alicia@ejemplo.com",
                Asistira = true
            });
            responses.Add("Pablo", new Invitaciones
            {
                Nombre = "Pablo",
                Email = "pablo@ejemplo.com",
                Asistira = true
            });
        }
        public static void Add(Invitaciones newResponse)
        {
            string key = newResponse.Nombre.ToLowerInvariant();
            if (responses.ContainsKey(key))
            {
                responses[key] = newResponse;
            }
            else
            {
                responses.Add(key, newResponse);
            }
        }
        public static IEnumerable<Invitaciones> Responses
        {
            get { return responses.Values; }
        }
    }
}
