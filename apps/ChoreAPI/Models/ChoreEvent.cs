﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreData
{
    public class ChoreEvent : EntityBase
    {
        public int? Id { get; set; }

        public Chore Chore { get; set; }

        public DateTime? Completed { get; set; }
    }
}
