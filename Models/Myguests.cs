using System;
using System.Collections.Generic;

namespace Final.Model
{
    public partial class Myguests
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTimeOffset Reg_Date { get; set; }
    }
}
