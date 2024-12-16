using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;

namespace HotelManagmentLogic.Interfaces.IRepoository.Commands
{
    public interface IPaymentStatusCommandRepository
    {
        Task AddAsync(PaymentStatus paymentStatus);
        Task UpdateAsync(PaymentStatus paymentStatus);
        Task DeleteAsync(int id);
    }
}
