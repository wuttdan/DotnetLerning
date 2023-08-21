using Application.Common.Core;
using System.Security.Cryptography;

namespace Application.Util;

public static class GenUtil
{
    public static string GenTransactionId(string prefix = "", int num = -1)
    {
        prefix = prefix ?? string.Empty;
        num = (num < 0) ? RandomNumberGenerator.GetInt32(1, 100000) : num;
        var datetime = DateTime.Now.ToString(AppConstant.DateTimeFormat.FORMAT_DT03);
        var fragment = num.ToString("D7");
        return $"{prefix}{datetime}{fragment}";
    }

    public static string RanLen(int len = 4)
    {
        var num = RandomNumberGenerator.GetInt32(1, 100000);
        return num.ToString($"D{len}");
    }
}
