﻿using System;
using System.Collections.Generic;

namespace WebApplication28.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; } = null!;
        public double? PaymentAmount { get; set; }
        public string CardNumber { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime paymentDate { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
