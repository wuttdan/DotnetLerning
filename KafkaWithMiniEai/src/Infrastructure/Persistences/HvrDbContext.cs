using Application.Common.Core;
using Application.Common.Interfaces;
using Domain.Entities.Hvr;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistences;

public partial class HvrDbContext : BaseDbContext, ISecondaryDbContext
{
    public HvrDbContext(DbContextOptions<HvrDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FaultOrderAttribute> FaultOrderAttributes { get; set; } = null!;
    public virtual DbSet<SoaHvrOrderInstall> SoaHvrOrderInstalls { get; set; } = null!;
    public virtual DbSet<SoaHvrOrderMa> SoaHvrOrderMas { get; set; } = null!;
    public virtual DbSet<WfsReason> WfsReasons { get; set; } = null!;
}
