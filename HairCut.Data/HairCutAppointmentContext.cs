using HairCut.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairCut.Data
{
    public class HairCutAppointmentContext : DbContext
    {
        public HairCutAppointmentContext() : base("Data source=.;Initial Catalog = BarberShop; Integrated Security = true")
        {

        }
        
        public DbSet<HairCutAppointment> HairCutAppointments { get; set; }
        public DbSet<BarberShop> BarberShops { get; set; }
        public DbSet<Barber> Barbers { get; set; }
    }
}
