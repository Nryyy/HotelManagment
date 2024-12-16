using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;

namespace HotelManagmentLogic.Interfaces.IRepoository.Querys
{
    public interface IPaymentStatusQueryRepository
    {
        Task<PaymentStatus> GetPaymentStatusByIdAsync(int id);
        Task<IEnumerable<PaymentStatus>> GetAllPaymentStatusAsync();
    }
}
