using System.Linq;
using System.Text;

namespace BLL
{
    /// <summary>
    /// Кастомные расширения для работы со строкой
    /// </summary>
    public static class CustomStringExtensions
    {
        /// <summary>
        /// Получить информацию по входящим символам в строку
        /// Символ - количество повторений
        /// </summary>
        /// <param name="value">Строка для сбора информации</param>
        /// <returns>Информация по входящим символам в строку</returns>
        public static string GetInfoOnInputCharactersInString(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return "string is empty";

            var stingBuilder = new StringBuilder();

            value.ToLower().ToCharArray().GroupBy(t => t).ToList()
                .ForEach(m => stingBuilder.AppendLine($"Символ {m.Key} - {m.Count()}"));

            return stingBuilder.ToString();
        }

        /// <summary>
        /// Определить что строка является палиндромом
        /// </summary>
        /// <param name="value">Строка для определения</param>
        /// <returns>Признак, указывающий, что строка палиндром</returns>
        public static bool DefinePalindrom(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            var charArray = value.ToLower().ToCharArray();

            return Enumerable.SequenceEqual(charArray, charArray.Reverse());         
        }

        ///// <summary>
        ///// Перевернуть строку
        ///// </summary>
        ///// <param name="value">Строка для переворачивания</param>
        ///// <returns>Перевернутая строка</returns>
        public static string ReverseString(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return "string is empty";

            int stringLength = value.Length;
            string reversedString="";

            for(int i=stringLength-1; i>=0; i--)
            {
                reversedString += value[i];
            }
            return reversedString;
        }
    }
}
