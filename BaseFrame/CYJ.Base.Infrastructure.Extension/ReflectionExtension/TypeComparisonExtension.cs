using System;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.ReflectionExtension
{
    public static class TypeComparisonExtension
    {
        #region 判断

        /// <summary>
        ///     A T extension method that query if '@this' is array.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if array, false if not.</returns>
        public static bool IsArray<T>(this T @this)
        {
            return @this.GetType().IsArray;
        }

        /// <summary>
        ///     A T extension method that query if '@this' is class.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if class, false if not.</returns>
        public static bool IsClass<T>(this T @this)
        {
            return @this.GetType().IsClass;
        }

        /// <summary>
        ///     A T extension method that query if '@this' is enum.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if enum, false if not.</returns>
        public static bool IsEnum<T>(this T @this)
        {
            return @this.GetType().IsEnum;
        }

        /// <summary>
        ///     A T extension method that query if '@this' is subclass of.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="type">The Type to process.</param>
        /// <returns>true if subclass of, false if not.</returns>
        public static bool IsSubclassOf<T>(this T @this, Type type)
        {
            return @this.GetType().IsSubclassOf(type);
        }

        /// <summary>
        ///     A T extension method that query if '@this' is type of.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="type">The type.</param>
        /// <returns>true if type of, false if not.</returns>
        public static bool IsTypeOf<T>(this T @this, Type type)
        {
            return @this.GetType() == type;
        }

        /// <summary>
        ///     A T extension method that query if '@this' is type or inherits of.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="type">The type.</param>
        /// <returns>true if type or inherits of, false if not.</returns>
        public static bool IsTypeOrInheritsOf<T>(this T @this, Type type)
        {
            var objectType = @this.GetType();

            while (true)
            {
                if (objectType == type) return true;

                if (objectType == objectType.BaseType || objectType.BaseType == null) return false;

                objectType = objectType.BaseType;
            }
        }

        #endregion
    }
}