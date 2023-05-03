using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Interfaces
{
    public interface ICartService
    {
        ValueTask<object> AddItemAsync(long productId, int amount);
        ValueTask<object> RemoveItemAsync(long cartItemId);
        ValueTask<object> UpdateItemAsync(long cartItemId, int amount);
    }
}
