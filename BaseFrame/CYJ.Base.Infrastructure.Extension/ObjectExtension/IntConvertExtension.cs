using System;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.ObjectExtension
{
    public static class IntConvertExtension
    {
        #region ToInt

        /// <summary>
        ///     An object extension method that converts the @this to an int 32.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as an int.</returns>
        public static int ToInt(this object @this)
        {
            return Convert.ToInt32(@this);
        }


        /// <summary>
        ///     An object extension method that converts this object to an int 32 or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to an int.</returns>
        public static int ToIntOrDefault(this object @this)
        {
            try
            {
                return Convert.ToInt32(@this);
            }
            catch (Exception)
            {
                return default(int);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to an int 32 or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to an int.</returns>
        public static int ToIntOrDefault(this object @this, int defaultValue)
        {
            try
            {
                return Convert.ToInt32(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to an int 32 or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <param name="useDefaultIfNull">true to use default if null.</param>
        /// <returns>The given data converted to an int.</returns>
        public static int ToIntOrDefault(this object @this, int defaultValue, bool useDefaultIfNull)
        {
            if (useDefaultIfNull && @this == null) return defaultValue;

            try
            {
                return Convert.ToInt32(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to an int 32 or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to an int.</returns>
        public static int ToIntOrDefault(this object @this, Func<int> defaultValueFactory)
        {
            try
            {
                return Convert.ToInt32(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to an int 32 or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <param name="useDefaultIfNull">true to use default if null.</param>
        /// <returns>The given data converted to an int.</returns>
        public static int ToIntOrDefault(this object @this, Func<int> defaultValueFactory, bool useDefaultIfNull)
        {
            if (useDefaultIfNull && @this == null) return defaultValueFactory();

            try
            {
                return Convert.ToInt32(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToNullableInt

        /// <summary>
        ///     An object extension method that converts the @this to a nullable int 32.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as an int?</returns>
        public static int? ToNullableInt(this object @this)
        {
            if (@this == null || @this == DBNull.Value) return null;

            return Convert.ToInt32(@this);
        }


        /// <summary>
        ///     An object extension method that converts this object to a nullable int 32 or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to an int?</returns>
        public static int? ToNullableIntOrDefault(this object @this)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToInt32(@this);
            }
            catch (Exception)
            {
                return default(int);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable int 32 or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to an int?</returns>
        public static int? ToNullableIntOrDefault(this object @this, int? defaultValue)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToInt32(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable int 32 or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to an int?</returns>
        public static int? ToNullableIntOrDefault(this object @this, Func<int?> defaultValueFactory)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToInt32(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion
    }
}