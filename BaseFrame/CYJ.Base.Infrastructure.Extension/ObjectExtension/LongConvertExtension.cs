using System;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.ObjectExtension
{
    public static class LongConvertExtension
    {
        #region ToNullableLong

        /// <summary>
        ///     An object extension method that converts the @this to a nullable long.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a long?</returns>
        public static long? ToNullableLong(this object @this)
        {
            if (@this == null || @this == DBNull.Value) return null;

            return Convert.ToInt64(@this);
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable long or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a long?</returns>
        public static long? ToNullableLongOrDefault(this object @this)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToInt64(@this);
            }
            catch (Exception)
            {
                return default(long);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable long or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to a long?</returns>
        public static long? ToNullableLongOrDefault(this object @this, long? defaultValue)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToInt64(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable long or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to a long?</returns>
        public static long? ToNullableLongOrDefault(this object @this, Func<long?> defaultValueFactory)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToInt64(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion


        #region ToLong

        /// <summary>
        ///     An object extension method that converts the @this to a long.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a long.</returns>
        public static long ToLong(this object @this)
        {
            return Convert.ToInt64(@this);
        }

        /// <summary>
        ///     An object extension method that converts this object to a long or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a long.</returns>
        public static long ToLongOrDefault(this object @this)
        {
            try
            {
                return Convert.ToInt64(@this);
            }
            catch (Exception)
            {
                return default(long);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a long or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to a long.</returns>
        public static long ToLongOrDefault(this object @this, long defaultValue)
        {
            try
            {
                return Convert.ToInt64(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>An object extension method that converts this object to a long or default.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <param name="useDefaultIfNull">true to use default if null.</param>
        /// <returns>The given data converted to a long.</returns>
        public static long ToLongOrDefault(this object @this, long defaultValue, bool useDefaultIfNull)
        {
            if (useDefaultIfNull && @this == null) return defaultValue;

            try
            {
                return Convert.ToInt64(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a long or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to a long.</returns>
        public static long ToLongOrDefault(this object @this, Func<long> defaultValueFactory)
        {
            try
            {
                return Convert.ToInt64(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        /// <summary>An object extension method that converts this object to a long or default.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <param name="useDefaultIfNull">true to use default if null.</param>
        /// <returns>The given data converted to a long.</returns>
        public static long ToLongOrDefault(this object @this, Func<long> defaultValueFactory, bool useDefaultIfNull)
        {
            if (useDefaultIfNull && @this == null) return defaultValueFactory();

            try
            {
                return Convert.ToInt64(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion
    }
}