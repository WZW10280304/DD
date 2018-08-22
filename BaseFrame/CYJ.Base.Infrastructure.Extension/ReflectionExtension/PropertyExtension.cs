using System.Reflection;
using CYJ.Utils.Extension.ReflectionExtension;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.ReflectionExtension
{
    public static class PropertyExtension
    {
        /// <summary>An object extension method that gets the properties.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>An array of property information.</returns>
        public static PropertyInfo[] GetProperties(this object @this)
        {
            return @this.GetType().GetProperties();
        }

        /// <summary>An object extension method that gets the properties.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="bindingAttr">The binding attribute.</param>
        /// <returns>An array of property information.</returns>
        public static PropertyInfo[] GetProperties(this object @this, BindingFlags bindingAttr)
        {
            return @this.GetType().GetProperties(bindingAttr);
        }

        /// <summary>
        ///     A T extension method that gets a property.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The name.</param>
        /// <returns>The property.</returns>
        public static PropertyInfo GetProperty<T>(this T @this, string name)
        {
            return @this.GetType().GetProperty(name);
        }

        /// <summary>
        ///     A T extension method that gets a property.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The name.</param>
        /// <param name="bindingAttr">The binding attribute.</param>
        /// <returns>The property.</returns>
        public static PropertyInfo GetProperty<T>(this T @this, string name, BindingFlags bindingAttr)
        {
            return @this.GetType().GetProperty(name, bindingAttr);
        }

        /// <summary>A T extension method that gets property or field.</summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The name.</param>
        /// <returns>The property or field.</returns>
        public static MemberInfo GetPropertyOrField<T>(this T @this, string name)
        {
            var property = @this.GetProperty(name);
            if (property != null) return property;

            var field = @this.GetField(name);
            if (field != null) return field;

            return null;
        }

        /// <summary>
        ///     A T extension method that sets property value.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="value">The value.</param>
        public static void SetPropertyValue<T>(this T @this, string propertyName, object value)
        {
            var type = @this.GetType();
            var property = type.GetProperty(propertyName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            property.SetValue(@this, value, null);
        }

        /// <summary>
        ///     A T extension method that gets property value.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>The property value.</returns>
        public static object GetPropertyValue<T>(this T @this, string propertyName)
        {
            var type = @this.GetType();
            var property = type.GetProperty(propertyName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

            return property.GetValue(@this, null);
        }
    }
}