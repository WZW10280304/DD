using System;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.ObjectExtension
{
    public static class FloatConvertExtension
    {
        #region ToNullableFloat

        /// <summary>
        ///     An object extension method that converts the @this to a nullable float.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a float?</returns>
        public static float? ToNullableFloat(this object @this)
        {
            if (@this == null || @this == DBNull.Value) return null;

            return Convert.ToSingle(@this);
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable float or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a float?</returns>
        public static float? ToNullableFloatOrDefault(this object @this)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToSingle(@this);
            }
            catch (Exception)
            {
                return default(float);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable float or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to a float?</returns>
        public static float? ToNullableFloatOrDefault(this object @this, float? defaultValue)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToSingle(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable float or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to a float?</returns>
        public static float? ToNullableFloatOrDefault(this object @this, Func<float?> defaultValueFactory)
        {
            try
            {
                if (@this == null || @this == DBNull.Value) return null;

                return Convert.ToSingle(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToFloat

        /// <summary>
        ///     An object extension method that converts the @this to a float.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a float.</returns>
        public static float ToFloat(this object @this)
        {
            return Convert.ToSingle(@this);
        }

        /// <summary>
        ///     An object extension method that converts this object to a float or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a float.</returns>
        public static float ToFloatOrDefault(this object @this)
        {
            try
            {
                return Convert.ToSingle(@this);
            }
            catch (Exception)
            {
                return default(float);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a float or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to a float.</returns>
        public static float ToFloatOrDefault(this object @this, float defaultValue)
        {
            try
            {
                return Convert.ToSingle(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a float or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <param name="useDefaultIfNull">true to use default if null.</param>
        /// <returns>The given data converted to a float.</returns>
        public static float ToFloatOrDefault(this object @this, float defaultValue, bool useDefaultIfNull)
        {
            if (useDefaultIfNull && @this == null) return defaultValue;

            try
            {
                return Convert.ToSingle(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a float or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to a float.</returns>
        public static float ToFloatOrDefault(this object @this, Func<float> defaultValueFactory)
        {
            try
            {
                return Convert.ToSingle(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a float or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <param name="useDefaultIfNull">true to use default if null.</param>
        /// <returns>The given data converted to a float.</returns>
        public static float ToFloatOrDefault(this object @this, Func<float> defaultValueFactory, bool useDefaultIfNull)
        {
            if (useDefaultIfNull && @this == null) return defaultValueFactory();

            try
            {
                return Convert.ToSingle(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion
    }
}