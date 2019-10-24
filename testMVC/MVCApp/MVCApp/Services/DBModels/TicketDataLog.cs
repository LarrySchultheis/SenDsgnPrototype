﻿using System;
using System.Collections.Generic;

namespace MVCApp.Services.DBModels
{
    public partial class TicketDataLog
    {
        public int LogId { get; set; }
        public DateTime ChangeTime { get; set; }
        public string DataAction { get; set; }
        public string Details { get; set; }
        public int EntryId { get; set; }

        public virtual TicketData Entry { get; set; }
    }
}