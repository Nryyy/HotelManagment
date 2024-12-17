using Enteties;
using HotelManagmentLogic.UnitOfWorkManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Commands
{
    public class PaymentMethodCommandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PaymentMethodCommandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddPaymentMethodAsync(PaymentMethod paymentMethod)
        {
            await _unitOfWork.PaymentMethodCommandRepository.AddAsync(paymentMethod);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdatePaymentMethodAsync(PaymentMethod paymentMethod)
        {
            _unitOfWork.PaymentMethodCommandRepository.UpdateAsync(paymentMethod);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeletePaymentMethodAsync(int id)
        {
            _unitOfWork.PaymentMethodCommandRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
