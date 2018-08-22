using System;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.ObjectExtension
{
    public static class DecimalConvertExtension
    {
        #region ToNullableDecimal

        /// <summary>
        ///     An object extension method that converts the @this to a nullable decimal.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a decimal?</returns>
        public static decimal? ToNullableDecimal(this object @this)
        {
            if (@this == null || @this == DBNull.Value) return null;

            return Convert.ToDecimal(@this);
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable decimal or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a decimal?</returns>
        public static decimal? ToNullableDecimalOrDefault(this object @this)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToDecimal(@this);
            }
            catch (Exception)
            {
                return default(decimal);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable decimal or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to a decimal?</returns>
        public static decimal? ToNullableDecimalOrDefault(this object @this, decimal? defaultValue)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToDecimal(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable decimal or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to a decimal?</returns>
        public static decimal? ToNullableDecimalOrDefault(this object @this, Func<decimal?> defaultValueFactory)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToDecimal(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToDecimal

        /// <summary>
        ///     An object extension method that converts the @this to a decimal.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a decimal.</returns>
        public static decimal ToDecimal(this object @this)
        {
            return Convert.ToDecimal(@this);
        }

        /// <summary>
        ///     An object extension method that converts this object to a decimal or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a decimal.</returns>
        public static decimal ToDecimalOrDefault(this object @this)
        {
            try
            {
                return Convert.ToDecimal(@this);
            }
            catch (Exception)
            {
                return default(decimal);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a decimal or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to a decimal.</returns>
        public static decimal ToDecimalOrDefault(this object @this, decimal defaultValue)
        {
            try
            {
                return Convert.ToDecimal(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a decimal or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <param name="useDefaultIfNull">true to use default if null.</param>
        /// <returns>The given data converted to a decimal.</returns>
        public static decimal ToDecimalOrDefault(this object @this, decimal defaultValue, bool useDefaultIfNull)
        {
            if (useDefaultIfNull && @this == null) return defaultValue;

            try
            {
                return Convert.ToDecimal(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a decimal or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to a decimal.</returns>
        public static decimal ToDecimalOrDefault(this object @this, Func<decimal> defaultValueFactory)
        {
            try
            {
                return Convert.ToDecimal(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a decimal or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <param name="useDefaultIfNull">true to use default if null.</param>
        /// <returns>The given data converted to a decimal.</returns>
        public static decimal ToDecimalOrDefault(this object @this, Func<decimal> defaultValueFactory,
            bool useDefaultIfNull)
        {
            if (useDefaultIfNull && @this == null) return defaultValueFactory();

            try
            {
                return Convert.ToDecimal(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion
    }
}