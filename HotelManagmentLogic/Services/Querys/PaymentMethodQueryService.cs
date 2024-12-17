using HotelManagmentLogic.UnitOfWorkManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Services.Querys
{
    public class PaymentMethodQueryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PaymentMethodQueryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Enteties.PaymentMethod> GetPaymentMethodByIdAsync(int id)
        {
            return await _unitOfWork.PaymentMethodQueryRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Enteties.PaymentMethod>> GetAllPaymentMethodAsync()
        {
            return await _unitOfWork.PaymentMethodQueryRepository.GetAllAsync();
        }
    }
}
