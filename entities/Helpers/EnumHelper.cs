using System.ComponentModel;

namespace entities.Helpers
{
    public static class EnumHelper
    {
        public static string GetEnumDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            if (fieldInfo?.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] attributes && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }
    }
}