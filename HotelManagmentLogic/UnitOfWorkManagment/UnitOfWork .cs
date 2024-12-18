using Enteties;
using HotelManagmentLogic.ApplicationContext;
using HotelManagmentLogic.Interfaces.Commands;
using HotelManagmentLogic.Interfaces.Queries;
using HotelManagmentLogic.Repositories.Commands;
using HotelManagmentLogic.Repositories.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.UnitOfWorkManagment
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HotelDBContext _context;

        // GUEST SECTION
        private RepositoryQueries<Guest> _guestQueryRepository;
        private RepositoryCommands<Guest> _guestCommandRepository;

        // EMPLOYEE SECTION
        private RepositoryQueries<Employee> _employeeQueryRepository;
        private RepositoryCommands<Employee> _employeeCommandRepository;
        private RepositoryCommands<EmployeeAction> _employeeActionCommandRepository;
        private RepositoryQueries<EmployeeAction> _employeeActionQueryRepository;

        // ROLE SECTION
        private RepositoryQueries<Role> _roleQueryRepository;
        private RepositoryCommands<Role> _roleCommandRepository;

        // PAYMENT SECTION
        private RepositoryCommands<PaymentStatus> _paymentStatusCommandRepository;
        private RepositoryQueries<PaymentStatus> _paymentStatusQueryRepository;
        private RepositoryCommands<PaymentMethod> _paymentMethodCommandRepository;
        private RepositoryQueries<PaymentMethod> _paymentMethodQueryRepository;
        private RepositoryCommands<BookingPayment> _bookingPaymentCommandRepository;
        private RepositoryQueries<BookingPayment> _bookingPaymentQueryRepository;

        // ROOM SECTION
        private RepositoryCommands<RoomStatus> _roomStatusCommandRepository;
        private RepositoryQueries<RoomStatus> _roomStatusQueryRepository;

        private RepositoryCommands<Room> _roomCommandRepository;
        private RepositoryQueries<Room> _roomQueryRepository;

        // CATEGORY SECTION
        private RepositoryCommands<Category> _roomCategoryCommandRepository;
        private RepositoryQueries<Category> _roomCategoryQueryRepository;

        // BOOKING SECTION
        private RepositoryCommands<BookingStatus> _bookingCommandRepository;
        private RepositoryQueries<BookingStatus> _bookingQueryRepository;
        private RepositoryQueries<Booking> _bookQueryRepository;
        private RepositoryCommands<Booking> _bookStatusCommandRepository;


        public UnitOfWork(HotelDBContext context)
        {
            _context = context;
        }


        // GUEST BLOCK
        public IRepositoryQueries<Guest> GuestQueryRepository
        {
            get
            {
                if (_guestQueryRepository == null)
                {
                    _guestQueryRepository = new RepositoryQueries<Guest>(_context);
                }
                return _guestQueryRepository;
            }
        }

        public IRepositoryCommands<Guest> GuestCommandRepository
        {
            get
            {
                if (_guestCommandRepository == null)
                {
                    _guestCommandRepository = new RepositoryCommands<Guest>(_context);
                }
                return _guestCommandRepository;
            }
        }

        // EMPLOYEE BLOCK
        public IRepositoryQueries<Employee> EmployeeQueryRepository
        {
            get
            {
                if (_employeeQueryRepository == null)
                {
                    _employeeQueryRepository = new RepositoryQueries<Employee>(_context);
                }
                return _employeeQueryRepository;
            }
        }

        public IRepositoryCommands<Employee> EmployeeCommandRepository
        {
            get
            {
                if (_employeeCommandRepository == null)
                {
                    _employeeCommandRepository = new RepositoryCommands<Employee>(_context);
                }
                return _employeeCommandRepository;
            }
        }

        public IRepositoryCommands<EmployeeAction> EmployeeActionCommandRepository
        {
            get
            {
                if (_employeeActionCommandRepository == null)
                {
                    _employeeActionCommandRepository = new RepositoryCommands<EmployeeAction>(_context);
                }
                return _employeeActionCommandRepository;
            }
        }

        public IRepositoryQueries<EmployeeAction> EmployeeActionQueryRepository
        {
            get
            {
                if (_employeeActionQueryRepository == null)
                {
                    _employeeActionQueryRepository = new RepositoryQueries<EmployeeAction>(_context);
                }
                return _employeeActionQueryRepository;
            }
        }

        // ROLE BLOCK
        public IRepositoryQueries<Role> RoleQueryRepository
        {
            get
            {
                if (_roleQueryRepository == null)
                {
                    _roleQueryRepository = new RepositoryQueries<Role>(_context);
                }
                return _roleQueryRepository;
            }
        }

        public IRepositoryCommands<Role> RoleCommandRepository
        {
            get
            {
                if (_roleCommandRepository == null)
                {
                    _roleCommandRepository = new RepositoryCommands<Role>(_context);
                }
                return _roleCommandRepository;
            }
        }

        // PAYMENT BLOCK
        public IRepositoryCommands<PaymentStatus> PaymentStatusCommandRepository
        {
            get
            {
                if (_paymentStatusCommandRepository == null)
                {
                    _paymentStatusCommandRepository = new RepositoryCommands<PaymentStatus>(_context);
                }
                return _paymentStatusCommandRepository;
            }
        }

        public IRepositoryQueries<PaymentStatus> PaymentStatusQueryRepository
        {
            get
            {
                if (_paymentStatusQueryRepository == null)
                {
                    _paymentStatusQueryRepository = new RepositoryQueries<PaymentStatus>(_context);
                }
                return _paymentStatusQueryRepository;
            }
        }

        public IRepositoryCommands<PaymentMethod> PaymentMethodCommandRepository
        {
            get
            {
                if (_paymentMethodCommandRepository == null)
                {
                    _paymentMethodCommandRepository = new RepositoryCommands<PaymentMethod>(_context);
                }
                return _paymentMethodCommandRepository;
            }
        }

        public IRepositoryQueries<PaymentMethod> PaymentMethodQueryRepository
        {
            get
            {
                if (_paymentMethodQueryRepository == null)
                {
                    _paymentMethodQueryRepository = new RepositoryQueries<PaymentMethod>(_context);
                }
                return _paymentMethodQueryRepository;
            }
        }

        public IRepositoryCommands<BookingPayment> BookingPaymentCommandRepository
        {
            get
            {
                if (_bookingPaymentCommandRepository == null)
                {
                    _bookingPaymentCommandRepository = new RepositoryCommands<BookingPayment>(_context);
                }
                return _bookingPaymentCommandRepository;
            }
        }

        public IRepositoryQueries<BookingPayment> BookingPaymentQueryRepository
        {
            get
            {
                if (_bookingPaymentQueryRepository == null)
                {
                    _bookingPaymentQueryRepository = new RepositoryQueries<BookingPayment>(_context);
                }
                return _bookingPaymentQueryRepository;
            }
        }

        // ROOM BLOCK
        public IRepositoryCommands<RoomStatus> RoomStatusCommandRepository
        {
            get
            {
                if (_roomStatusCommandRepository == null)
                {
                    _roomStatusCommandRepository = new RepositoryCommands<RoomStatus>(_context);
                }
                return _roomStatusCommandRepository;
            }
        }

        public IRepositoryQueries<RoomStatus> RoomStatusQueryRepository
        {
            get
            {
                if (_roomStatusQueryRepository == null)
                {
                    _roomStatusQueryRepository = new RepositoryQueries<RoomStatus>(_context);
                }
                return _roomStatusQueryRepository;
            }
        }

        public IRepositoryCommands<Room> RoomCommandRepository
        {
            get
            {
                if (_roomCommandRepository == null)
                {
                    _roomCommandRepository = new RepositoryCommands<Room>(_context);
                }
                return _roomCommandRepository;
            }
        }

        public IRepositoryQueries<Room> RoomQueryRepository
        {
            get
            {
                if (_roomQueryRepository == null)
                {
                    _roomQueryRepository = new RepositoryQueries<Room>(_context);
                }
                return _roomQueryRepository;
            }
        }

        // CATEGORY BLOCK

        public IRepositoryQueries<Category> RoomCategoryQueryRepository
        {
            get
            {
                if (_roomCategoryQueryRepository == null)
                {
                    _roomCategoryQueryRepository = new RepositoryQueries<Category>(_context);
                }
                return _roomCategoryQueryRepository;
            }
        }

        public IRepositoryCommands<Category> RoomCategoryCommandRepository
        {
            get
            {
                if (_roomCategoryCommandRepository == null)
                {
                    _roomCategoryCommandRepository = new RepositoryCommands<Category>(_context);
                }
                return _roomCategoryCommandRepository;
            }
        }

        // BOOKING BLOCK

        public IRepositoryCommands<BookingStatus> BookingStatusCommandRepository
        {
            get
            {
                if (_bookingCommandRepository == null)
                {
                    _bookingCommandRepository = new RepositoryCommands<BookingStatus>(_context);
                }
                return _bookingCommandRepository;
            }
        }

        public IRepositoryQueries<BookingStatus> BookingStatusQueryRepository
        {
            get
            {
                if (_bookingQueryRepository == null)
                {
                    _bookingQueryRepository = new RepositoryQueries<BookingStatus>(_context);
                }
                return _bookingQueryRepository;
            }
        }

        public IRepositoryCommands<Booking> BookingCommandRepository
        {
            get
            {
                if (_bookStatusCommandRepository == null)
                {
                    _bookStatusCommandRepository = new RepositoryCommands<Booking>(_context);
                }
                return _bookStatusCommandRepository;
            }
        }

        public IRepositoryQueries<Booking> BookingQueryRepository
        {
            get
            {
                if (_bookQueryRepository == null)
                {
                    _bookQueryRepository = new RepositoryQueries<Booking>(_context);
                }
                return _bookQueryRepository;
            }
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
