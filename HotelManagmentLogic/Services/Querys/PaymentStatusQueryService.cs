using HotelManagmentLogic.UnitOfWorkManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Querys
{
    public class PaymentStatusQueryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PaymentStatusQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Enteties.PaymentStatus> GetPaymentStatusByIdAsync(int id)
        {
            return await _unitOfWork.PaymentStatusQueryRepository.GetPaymentStatusByIdAsync(id);
        }

        public async Task<IEnumerable<Enteties.PaymentStatus>> GetAllPaymentStatusesAsync()
        {
            return await _unitOfWork.PaymentStatusQueryRepository.GetAllPaymentStatusAsync();
        }
    }
}
