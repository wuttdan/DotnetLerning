using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Domain.Extension;

public static class ObjectExtension
{
    public static object? GetValueByName([NotNull] this object target, [NotNull] string propertyName)
    {
        var propertyInfo = target.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        if (propertyInfo != null && propertyInfo.CanWrite)
        {
            return propertyInfo.GetValue(target);
        }
        return null;
    }

    public static void SetValueByName([NotNull] this object target, string propertyName, object value)
    {
        var propertyInfo = target.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        if (propertyInfo != null && propertyInfo.CanWrite)
        {
            propertyInfo.SetValue(target, value, null);
        }
    }

    public static List<string> GetAllProperties([NotNull] this object target)
    {
        var res = new List<string>();
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(target.GetType());
        foreach (PropertyDescriptor pp in properties)
        {
            res.Add(pp.Name);
        }
        return res;
    }

    public static void SetAllProperties([NotNull] this object target, [NotNull] object source)
    {
        PropertyDescriptorCollection targetProperties = TypeDescriptor.GetProperties(target.GetType());
        PropertyDescriptorCollection sourceProperties = TypeDescriptor.GetProperties(source.GetType());
        foreach (PropertyDescriptor sourceProp in sourceProperties)
        {
            var targetProp = targetProperties[sourceProp.Name];
            if (targetProp != null)
            {
                var value = sourceProp.GetValue(source);
                targetProp.SetValue(target, value);
            }
        }
    }
}