using FleetFlow.Domain.Enums;
using FleetFlow.Service.Interfaces;
using FleetFlow.Service.Services;

namespace FleetFlow.Presentation
{
    public class Program
    {
        static void Main(string[] args)
        {
            IUserService userService = new UserService();
            userService.GetAllByRoleAsync();
        }
    }
}
