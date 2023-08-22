using Application.Common.Core;

namespace Application.Common.Models.Microsite;

public class MicrositeRequestBase : RequestBase
{
    public string? USER { get; set; }
    public string? SEGMENT { get; set; }
    public string? NUMBER_OF_USER { get; set; }
    public string? RESIDENTIAL { get; set; }
    public string? TYPE_OF_USER { get; set; }
    public string? PACKAGE { get; set; }
    public string? PACKAGE_CODE { get; set; }
    public string? SPEED { get; set; }
    public string? PLAYBOX_BUNDLE { get; set; }
    public string? PLAYBOX_ADDON { get; set; }
    public string? ROUTER_BUNDLE { get; set; }
    public string? ROUTER_ADDON { get; set; }
    public string? PRICE { get; set; }
    public string? FIRSTNAME { get; set; }
    public string? LASTNAME { get; set; }
    public string? TELEPHONE { get; set; }
    public string? EMAIL { get; set; }
    public string? ADDRESS { get; set; }
    public string? SUBDISTRICT { get; set; }
    public string? DISTRICT { get; set; }
    public string? PROVINCE { get; set; }
    public string? ZIPCODE { get; set; }
    public string? MEDIA_STREAMING { get; set; }
    public string? USER_JOURNEY { get; set; }
    public string? CID { get; set; }
    public string? COMPLETE { get; set; }
}
