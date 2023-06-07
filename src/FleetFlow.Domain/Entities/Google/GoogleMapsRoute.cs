using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Entities.Google;

public class GoogleMapsRoute
{
    public List<GoogleMapsLeg> Legs { get; set; }
}
