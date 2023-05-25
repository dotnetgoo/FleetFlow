using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.DTOs.Inventories
{
    public class InventoryForUpdateDto
    {

        [Required(ErrorMessage = "Product id is required")]
        public long ProductId { get; set; }
        [Required(ErrorMessage = "Amount is requred")]
        public int Amount { get; set; }
        [Required(ErrorMessage = "Location id is requred")]
        public long LocationId { get; set; }
    }
}
