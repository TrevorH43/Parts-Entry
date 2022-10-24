using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parts_Entry
{
    internal class UtilityLibrary
    {


        /// <summary>
        /// Validates that a String Value is Numeric
        /// </summary>
        /// <param name="value">String value to validate</param>
        /// <param name="messageIdentifier">Will be prepend this value to error messages</param>
        /// <param name="message">Validation Error Message if applicable</param>
        /// <param name="outValue">Return the Value if valid</param>
        /// <returns>Returns indication of whether the string value is numeric</returns>
        public static bool ValidateIsNumeric<T>(String value,
            String messageIdentifier, out String message, out T outValue)
        {
            bool valid = false;
            outValue = default;
            message = String.Empty;
            Type valueType = typeof(T);

            if (String.IsNullOrEmpty(value))
                message = $"{messageIdentifier} is required.";
            else
                try
                {
                    TypeConverter tc = TypeDescriptor.GetConverter(valueType);
                    outValue = (T)tc.ConvertFrom(value);
                    valid = true;
                }
                catch
                {
                    message = $"{messageIdentifier} is not numeric.";
                }

            return valid;
        }

    }
}
