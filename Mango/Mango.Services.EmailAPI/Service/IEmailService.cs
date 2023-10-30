using Mango.Services.EmailAPI.Message;
using Mango.Services.EmailAPI.Models.DTO;

namespace Mango.Services.EmailAPI.Service
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
