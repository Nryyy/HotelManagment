using HotelManagmentLogic.UnitOfWorkManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;

namespace HotelManagmentLogic.Services.Commands
{
    public class PaymentStatusCommandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PaymentStatusCommandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddPaymentStatusAsync(PaymentStatus paymentStatus)
        {
            await _unitOfWork.PaymentStatusCommandRepository.AddAsync(paymentStatus);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdatePaymentStatusAsync(PaymentStatus paymentStatus)
        {
            _unitOfWork.PaymentStatusCommandRepository.UpdateAsync(paymentStatus);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeletePaymentStatusAsync(int id)
        {
            await _unitOfWork.PaymentStatusCommandRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
