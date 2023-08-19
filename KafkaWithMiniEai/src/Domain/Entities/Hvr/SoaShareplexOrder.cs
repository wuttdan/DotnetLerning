using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Hvr;

public class SoaHvrOrder
{
    public string? REQUEST_NO { get; set; }
    public string? INSTALLATION_LATITUDE { get; set; }
    public string? INSTALLATION_LONGITUDE { get; set; }
    public string? BUILDING_NAME { get; set; }
    public string? AREA { get; set; }
    public string? REGION { get; set; }
    public string? CS_NOTE { get; set; }
}

[Keyless]
public class SoaHvrOrderInstall : SoaHvrOrder
{
}

[Keyless]
public class SoaHvrOrderMa : SoaHvrOrder
{
    public string? SEVICE_LEVEL { get; set; }
    public string? ADDRESS { get; set; }
}
