using FleetFlow.Domain.Enums;
using FleetFlow.Service.Interfaces;
using FleetFlow.Service.Services;

namespace FleetFlow.Presentation
{
    public class Program
    {
        private static IUserService userService = new UserService();
        static void Main(string[] args)
        {
            userService.GetAllByRoleAsync();
        }
    }
}
