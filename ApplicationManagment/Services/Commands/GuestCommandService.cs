using ApplicationManagment.UnitOfWorkManagment;
using EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationManagment.Services.Commands
{
    public class GuestCommandService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GuestCommandService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddGuestAsync(Guest guest)
        {
            await _unitOfWork.GuestCommandRepository.AddAsync(guest);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateGuestAsync(Guest guest)
        {
            _unitOfWork.GuestCommandRepository.UpdateAsync(guest);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteGuestAsync(int id)
        {
            await _unitOfWork.GuestCommandRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
