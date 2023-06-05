using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Entities.Google;

public class GoogleMapsDirectionResponse
{
    public List<GoogleMapsRoute> Routes { get; set; }
}
