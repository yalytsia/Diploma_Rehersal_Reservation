﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehersalReservation.DataAccessLayer.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderNumber { get; set; }
        public int UserID { get; set; }
        public int RehersalSpaceID { get; set; }
        public int RehersalRoomID { get; set; }
        public string Comment { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal Price { get; set; }
    }
}
