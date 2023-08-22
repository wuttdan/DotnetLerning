
namespace Application.Common.Core;

public static class AppConstant
{
    public static readonly string SystemName = "minieai";
    public static readonly string DefValidateErrorFormat = "'{0}' should not be dual null or empty.";

    public static class DateTimeFormat
    {
        public const string FORMAT_DT01 = "yyyy-MM-dd HH:mm:ss";
        public const string FORMAT_D01 = "yyyy-MM-dd";
        public const string FORMAT_D02 = "yyyyMMdd";
        public const string FORMAT_DT02 = "yyyyMMddHHmmssfffffff";
        public const string FORMAT_DT03 = "yyyyMMddHHmmss";
        public const string FORMAT_T04 = "HH:mm:ss.fff";
        public const string FORMAT_SQL_DATETIME = "dd/MM/yyyy HH:mm:ss";
        public const string FORMAT_D01_T04 = "yyyy-MM-dd HH:mm:ss.fff";
    }
}