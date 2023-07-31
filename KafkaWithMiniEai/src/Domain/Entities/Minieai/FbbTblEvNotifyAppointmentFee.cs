﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.Minieai
{
    public partial class FbbTblEvNotifyAppointmentFee
    {
        public int Id { get; set; }
        public long OrderId { get; set; }
        public int? Group { get; set; }
        public string? Data { get; set; }
        public string? Created { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastUpd { get; set; }
        public DateTime? LastUpdDate { get; set; }

        public virtual FbbTblEvNotifyAppointmentOrder Order { get; set; } = null!;
    }
}