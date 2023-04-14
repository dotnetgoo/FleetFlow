using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FleetFlow.Api.Models
{
    public class Response
    {
        public int Code { get; set; }
        public object Data { get; set; }
        public string Error { get; set; }
    }
}