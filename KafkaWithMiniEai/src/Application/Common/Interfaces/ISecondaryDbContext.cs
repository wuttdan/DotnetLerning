using Domain.Entities.Hvr;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface ISecondaryDbContext : IBaseDbContext
{
    DbSet<FaultOrderAttribute> FaultOrderAttributes { get; set; }
    DbSet<SoaHvrOrderInstall> SoaHvrOrderInstalls { get; set; }
    DbSet<SoaHvrOrderMa> SoaHvrOrderMas { get; set; }
    DbSet<WfsReason> WfsReasons { get; set; }
}
