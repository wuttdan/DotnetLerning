using Domain.Entities.Hvr;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces;

public interface ISecondaryDbContext : IBaseDbContext
{
    DbSet<FaultOrderAttribute> FaultOrderAttributes { get; set; }
    DbSet<SoaHvrOrderInstall> SoaHvrOrderInstalls { get; set; }
    DbSet<SoaHvrOrderMa> SoaHvrOrderMas { get; set; }
    DbSet<WfsReason> WfsReasons { get; set; }
}
