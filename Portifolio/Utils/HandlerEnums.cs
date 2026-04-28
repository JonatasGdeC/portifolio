using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Portifolio.Utils;

public static class HandlerEnums
{
  public static string GetDescription<TEnum>(this TEnum value) where TEnum : Enum
  {
    FieldInfo? field = value.GetType().GetField(name: value.ToString());
    DescriptionAttribute? attributeDescription = field?.GetCustomAttribute<DescriptionAttribute>();
    DisplayNameAttribute? attributeDisplayName = field?.GetCustomAttribute<DisplayNameAttribute>();
    DisplayAttribute? attributeDisplay = field?.GetCustomAttribute<DisplayAttribute>();

    return attributeDescription?.Description ?? attributeDisplay?.GetName() ?? attributeDisplayName?.DisplayName ?? value.ToString();
  }

  public static List<TEnum> GetValuesList<TEnum>() where TEnum : Enum => Enum.GetValues(enumType: typeof(TEnum)).Cast<TEnum>().ToList();

  public static IEnumerable<TEnum> WhereNot<TEnum>(this IEnumerable<TEnum> source, params TEnum[] ignored) where TEnum : struct, Enum
  {
    return source.Where(predicate: item => !ignored.Contains(value: item));
  }
}
