using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBaseet.Core.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public Customer? Customer { get; set; }
        public RealEstate? RealEstate { get; set; }
        public User? User { get; set; }
    }
}
