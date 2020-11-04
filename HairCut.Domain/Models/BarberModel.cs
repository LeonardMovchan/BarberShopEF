using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairCut.Domain.Models
{
    public class BarberModel
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Expirience { get; set; }

        public ICollection<HairCutAppointmentModel> HairCutAppointmentModels { get; set; }
    }
}
