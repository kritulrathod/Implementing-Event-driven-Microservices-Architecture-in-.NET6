﻿using MTAEDA.Core.Interfaces;
using MTAEDA.Maintenance.Domain.Entities;
using MTAEDA.Maintenance.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTAEDA.Maintenance.Domain.Aggregates
{
    public class Camera : IDomainAggregateRoot, IMaintenanceHistory
    {
        public int CameraId { get; set; }   
        public IList<WorkOrder>? MaintenanceHistory { get; set; }
    }
}
