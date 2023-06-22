using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Domain.Entities.Orders;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Domain.Entities.Users
{
    public class User : Auditable
    {
        [MinLength(3), MaxLength(50)]
        public string FirstName { get; set; }
        [MinLength(3), MaxLength(50)]
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public long RoleId { get; set; }
        public Role Role { get; set; }


        [JsonIgnore]
        public ICollection<Order> Orders { get; set; }
    }
}
