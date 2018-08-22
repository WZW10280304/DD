using System.Reflection;

namespace CYJ.Utils.Extension.ReflectionExtension
{
    public static class FieldExtension
    {
        /// <summary>
        ///     A T extension method that sets field value.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">The value.</param>
        public static void SetFieldValue<T>(this T @this, string fieldName, object value)
        {
            var type = @this.GetType();
            var field = type.GetField(fieldName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            field.SetValue(@this, value);
        }

        /// <summary>A T extension method that searches for the public field with the specified name.</summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The string containing the name of the data field to get.</param>
        /// <returns>
        ///     An object representing the field that matches the specified requirements, if found;
        ///     otherwise, null.
        /// </returns>
        public static FieldInfo GetField<T>(this T @this, string name)
        {
            return @this.GetType().GetField(name);
        }

        /// <summary>
        ///     A T extension method that searches for the specified field, using the specified
        ///     binding constraints.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The string containing the name of the data field to get.</param>
        /// <param name="bindingAttr">
        ///     A bitmask comprised of one or more BindingFlags that specify how the
        ///     search is conducted.
        /// </param>
        /// <returns>
        ///     An object representing the field that matches the specified requirements, if found;
        ///     otherwise, null.
        /// </returns>
        public static FieldInfo GetField<T>(this T @this, string name, BindingFlags bindingAttr)
        {
            return @this.GetType().GetField(name, bindingAttr);
        }

        /// <summary>An object extension method that gets the fields.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>An array of field information.</returns>
        public static FieldInfo[] GetFields(this object @this)
        {
            return @this.GetType().GetFields();
        }

        /// <summary>An object extension method that gets the fields.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="bindingAttr">The binding attribute.</param>
        /// <returns>An array of field information.</returns>
        public static FieldInfo[] GetFields(this object @this, BindingFlags bindingAttr)
        {
            return @this.GetType().GetFields(bindingAttr);
        }

        /// <summary>
        ///     A T extension method that gets a field value (Public | NonPublic | Instance | Static)
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>The field value.</returns>
        public static object GetFieldValue<T>(this T @this, string fieldName)
        {
            var type = @this.GetType();
            var field = type.GetField(fieldName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

            return field.GetValue(@this);
        }
    }
}