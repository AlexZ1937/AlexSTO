using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlSTO1.Models.Repository
{
    public class Repository
    {
        private EFDBContext context = new EFDBContext();
        public IEnumerable<Client> Clients { get { return context.Clients; } }
    }
}