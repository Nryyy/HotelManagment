using HotelManagmentLogic.Interfaces.Queries;
using HotelManagmentLogic.Interfaces.Commands;
using Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.UnitOfWorkManagment
{
    public interface IUnitOfWork : IDisposable
    {
        // GUEST BLOCK

        IRepositoryQueries<Guest> GuestQueryRepository { get; }
        IRepositoryCommands<Guest> GuestCommandRepository { get; }

        // EMPLOYEE BLOCK
        IRepositoryQueries<Employee> EmployeeQueryRepository { get; }
        IRepositoryCommands<Employee> EmployeeCommandRepository { get; }

        // ROLE BLOCK
        IRepositoryQueries<Role> RoleQueryRepository { get; }
        IRepositoryCommands<Role> RoleCommandRepository { get; }

        // PAYMENT BLOCK
        IRepositoryCommands<PaymentStatus> PaymentStatusCommandRepository { get; }
        IRepositoryQueries<PaymentStatus> PaymentStatusQueryRepository { get; }

        IRepositoryCommands<PaymentMethod> PaymentMethodCommandRepository { get; }
        IRepositoryQueries<PaymentMethod> PaymentMethodQueryRepository { get; }

        IRepositoryCommands<BookingPayment> BookingPaymentCommandRepository { get; }
        IRepositoryQueries<BookingPayment> BookingPaymentQueryRepository { get; }

        // ROOM BLOCK
        IRepositoryCommands<RoomStatus> RoomStatusCommandRepository { get; }
        IRepositoryQueries<RoomStatus> RoomStatusQueryRepository { get; }

        IRepositoryCommands<Room> RoomCommandRepository { get; }
        IRepositoryQueries<Room> RoomQueryRepository { get; }

        // CATEGORY BLOCK
        IRepositoryCommands<Category> RoomCategoryCommandRepository { get; }
        IRepositoryQueries<Category> RoomCategoryQueryRepository { get; }

        Task<int> CompleteAsync();
    }
}
