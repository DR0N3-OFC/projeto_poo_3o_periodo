using System.ComponentModel;
using System.Reflection;

namespace Domain.Enumerators
{
    public static class EnumMethods
    {
        public static IList<T> EnumToList<T>()
        {
            if (!typeof(T).IsEnum)
                throw new Exception("O item não é um tipo enumerado");

            IList<T> list = new List<T>();
            Type type = typeof(T);
            if (type != null)
            {
                Array enumValues = Enum.GetValues(type);
                foreach (T value in enumValues)
                {
                    list.Add(value);
                }
            }
            return list;
        }

        public static String GetDescription(this Enum item)
        {
            Type tipo = item.GetType();
            FieldInfo? fi = tipo.GetField(item.ToString());
            DescriptionAttribute[]? atributos = fi?.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
            if (atributos?.Length > 0)
                return atributos[0].Description;
            else
                return String.Empty;
        }

        public static T GetEnumByDescription<T>(String description)
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T não é tipo enumerado");

            IList<T> list = EnumToList<T>();
            foreach (T item in list)
            {
                if (((Enum)Enum.Parse(typeof(T), item.ToString())).GetDescription() == description)
                    return item;
            }
            throw new Exception("A descrição é inválida");
        }
    }
}
