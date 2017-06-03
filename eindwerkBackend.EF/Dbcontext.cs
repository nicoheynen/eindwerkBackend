using eindwerkBackend.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eindwerkBackend.EF
{
    public class EindwerkBackendContext : DbContext
    {
        
        public DbSet<ClientInfo> ClientInfo { get; set; }
        public DbSet<UserCompanyInfo> UserCompanyInfo { get; set; }
        public DbSet<GeneralOfferInfo> GeneralOfferInfo { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
