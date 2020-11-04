using System;
namespace HairCut.Domain.Models
{
    public class HairCutAppointmentModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string HairCutStyle { get; set; }
        public DateTime Date { get; set; }

        public int BarberId { get; set; }
        public virtual BarberModel Barber { get; set; }


        public int BarberShopId { get; set; }
        public virtual BarberShopModel BarberShop { get; set; }
    }
}
