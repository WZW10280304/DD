using System;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.ObjectExtension
{
    public static class ShortConvertExtension
    {
        #region ToNullableShort

        /// <summary>
        ///     An object extension method that converts the @this to a nullable short.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a short?</returns>
        public static short? ToNullableShort(this object @this)
        {
            if (@this == null || @this == DBNull.Value) return null;

            return Convert.ToInt16(@this);
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable short or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a short?</returns>
        public static short? ToNullableShortOrDefault(this object @this)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToInt16(@this);
            }
            catch (Exception)
            {
                return default(short);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable short or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to a short?</returns>
        public static short? ToNullableShortOrDefault(this object @this, short? defaultValue)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToInt16(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable short or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to a short?</returns>
        public static short? ToNullableShortOrDefault(this object @this, Func<short?> defaultValueFactory)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToInt16(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToShort

        /// <summary>
        ///     An object extension method that converts the @this to a short.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a short.</returns>
        public static short ToShort(this object @this)
        {
            return Convert.ToInt16(@this);
        }

        /// <summary>
        ///     An object extension method that converts this object to a short or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a short.</returns>
        public static short ToShortOrDefault(this object @this)
        {
            try
            {
                return Convert.ToInt16(@this);
            }
            catch (Exception)
            {
                return default(short);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a short or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to a short.</returns>
        public static short ToShortOrDefault(this object @this, short defaultValue)
        {
            try
            {
                return Convert.ToInt16(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a short or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <param name="useDefaultIfNull">true to use default if null.</param>
        /// <returns>The given data converted to a short.</returns>
        public static short ToShortOrDefault(this object @this, short defaultValue, bool useDefaultIfNull)
        {
            if (useDefaultIfNull && @this == null) return defaultValue;

            try
            {
                return Convert.ToInt16(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a short or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to a short.</returns>
        public static short ToShortOrDefault(this object @this, Func<short> defaultValueFactory)
        {
            try
            {
                return Convert.ToInt16(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a short or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <param name="useDefaultIfNull">true to use default if null.</param>
        /// <returns>The given data converted to a short.</returns>
        public static short ToShortOrDefault(this object @this, Func<short> defaultValueFactory, bool useDefaultIfNull)
        {
            if (useDefaultIfNull && @this == null) return defaultValueFactory();

            try
            {
                return Convert.ToInt16(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion
    }
}