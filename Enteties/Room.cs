﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public int CategoryId { get; set; }
        public int Capacity { get; set; }
        public int StatusId { get; set; }

        public Category Category { get; set; }
        public RoomStatus Status { get; set; }
    }

}
