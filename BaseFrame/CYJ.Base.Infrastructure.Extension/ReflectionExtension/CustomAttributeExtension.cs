using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.ReflectionExtension
{
    public static class CustomAttributeExtension
    {
        #region CustomAttribute

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, and the
        ///     type of the custom attribute to search for.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <returns>
        ///     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
        ///     attributes exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this Assembly element, Type attributeType)
        {
            return Attribute.GetCustomAttributes(element, attributeType);
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, the type
        ///     of the custom attribute to search for, and an ignored search option.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
        /// <returns>
        ///     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
        ///     attributes exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this Assembly element, Type attributeType, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, attributeType, inherit);
        }

        /// <summary>
        ///     Retrieves a custom attribute applied to a member of a type. Parameters specify the member, and the type of
        ///     the custom attribute to search for.
        /// </summary>
        /// <param name="element">
        ///     An object derived from the  class that describes a constructor, event, field, method, or
        ///     property member of a class.
        /// </param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <returns>
        ///     A reference to the single custom attribute of type  that is applied to , or null if there is no such
        ///     attribute.
        /// </returns>
        public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType)
        {
            return Attribute.GetCustomAttribute(element, attributeType);
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, and
        ///     the type of the custom attribute to search for.
        /// </summary>
        /// <param name="element">
        ///     An object derived from the  class that describes a constructor, event, field, method, or
        ///     property member of a class.
        /// </param>
        /// <param name="type">The type, or a base type, of the custom attribute to search for.</param>
        /// <returns>
        ///     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
        ///     attributes exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this MemberInfo element, Type type)
        {
            return Attribute.GetCustomAttributes(element, type);
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, the
        ///     type of the custom attribute to search for, and whether to search ancestors of the member.
        /// </summary>
        /// <param name="element">
        ///     An object derived from the  class that describes a constructor, event, field, method, or
        ///     property member of a class.
        /// </param>
        /// <param name="type">The type, or a base type, of the custom attribute to search for.</param>
        /// <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
        /// <returns>
        ///     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
        ///     attributes exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this MemberInfo element, Type type, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, type, inherit);
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to a member of a type. A parameter specifies the member.
        /// </summary>
        /// <param name="element">
        ///     An object derived from the  class that describes a constructor, event, field, method, or
        ///     property member of a class.
        /// </param>
        /// <returns>
        ///     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
        ///     exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this MemberInfo element)
        {
            return Attribute.GetCustomAttributes(element);
        }

        /// <summary>
        ///     Determines whether any custom attributes are applied to a member of a type. Parameters specify the member,
        ///     and the type of the custom attribute to search for.
        /// </summary>
        /// <param name="element">
        ///     An object derived from the  class that describes a constructor, event, field, method, type,
        ///     or property member of a class.
        /// </param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
        public static bool IsDefined(this MemberInfo element, Type attributeType)
        {
            return Attribute.IsDefined(element, attributeType);
        }

        /// <summary>
        ///     Retrieves a custom attribute applied to a module. Parameters specify the module, and the type of the custom
        ///     attribute to search for.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a portable executable file.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <returns>
        ///     A reference to the single custom attribute of type  that is applied to , or null if there is no such
        ///     attribute.
        /// </returns>
        public static Attribute GetCustomAttribute(this Module element, Type attributeType)
        {
            return Attribute.GetCustomAttribute(element, attributeType);
        }

        /// <summary>
        ///     Retrieves a custom attribute applied to a module. Parameters specify the module, the type of the custom
        ///     attribute to search for, and an ignored search option.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a portable executable file.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
        /// <returns>
        ///     A reference to the single custom attribute of type  that is applied to , or null if there is no such
        ///     attribute.
        /// </returns>
        public static Attribute GetCustomAttribute(this Module element, Type attributeType, bool inherit)
        {
            return Attribute.GetCustomAttribute(element, attributeType, inherit);
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to a module. Parameters specify the module, and the type
        ///     of the custom attribute to search for.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a portable executable file.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <returns>
        ///     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
        ///     attributes exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this Module element, Type attributeType)
        {
            return Attribute.GetCustomAttributes(element, attributeType);
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to a module. A parameter specifies the module.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a portable executable file.</param>
        /// <returns>
        ///     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
        ///     exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this Module element)
        {
            return Attribute.GetCustomAttributes(element);
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to a module. Parameters specify the module, and an
        ///     ignored search option.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a portable executable file.</param>
        /// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
        /// <returns>
        ///     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
        ///     exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this Module element, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, inherit);
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to a module. Parameters specify the module, the type of
        ///     the custom attribute to search for, and an ignored search option.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a portable executable file.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
        /// <returns>
        ///     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
        ///     attributes exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this Module element, Type attributeType, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, attributeType, inherit);
        }

        /// <summary>
        ///     Determines whether any custom attributes of a specified type are applied to a module. Parameters specify the
        ///     module, and the type of the custom attribute to search for.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a portable executable file.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
        public static bool IsDefined(this Module element, Type attributeType)
        {
            return Attribute.IsDefined(element, attributeType);
        }

        /// <summary>
        ///     Retrieves a custom attribute applied to a method parameter. Parameters specify the method parameter, and the
        ///     type of the custom attribute to search for.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <returns>
        ///     A reference to the single custom attribute of type  that is applied to , or null if there is no such
        ///     attribute.
        /// </returns>
        public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType)
        {
            return Attribute.GetCustomAttribute(element, attributeType);
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to a method parameter. A parameter specifies the method
        ///     parameter.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
        /// <returns>
        ///     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
        ///     exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this ParameterInfo element)
        {
            return Attribute.GetCustomAttributes(element);
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method
        ///     parameter, and the type of the custom attribute to search for.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <returns>
        ///     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
        ///     attributes exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this ParameterInfo element, Type attributeType)
        {
            return Attribute.GetCustomAttributes(element, attributeType);
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method
        ///     parameter, the type of the custom attribute to search for, and whether to search ancestors of the method
        ///     parameter.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
        /// <returns>
        ///     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
        ///     attributes exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this ParameterInfo element, Type attributeType, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, attributeType, inherit);
        }

        /// <summary>
        ///     Determines whether any custom attributes are applied to a method parameter. Parameters specify the method
        ///     parameter, and the type of the custom attribute to search for.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
        public static bool IsDefined(this ParameterInfo element, Type attributeType)
        {
            return Attribute.IsDefined(element, attributeType);
        }

        /// <summary>
        ///     Determines whether any custom attributes are applied to a method parameter. Parameters specify the method
        ///     parameter, the type of the custom attribute to search for, and whether to search ancestors of the method
        ///     parameter.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
        /// <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
        public static bool IsDefined(this ParameterInfo element, Type attributeType, bool inherit)
        {
            return Attribute.IsDefined(element, attributeType, inherit);
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method
        ///     parameter, and whether to search ancestors of the method parameter.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
        /// <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
        /// <returns>
        ///     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
        ///     exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this ParameterInfo element, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, inherit);
        }

        /// <summary>
        ///     Retrieves a custom attribute applied to a method parameter. Parameters specify the method parameter, the type
        ///     of the custom attribute to search for, and whether to search ancestors of the method parameter.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
        /// <returns>
        ///     A reference to the single custom attribute of type  that is applied to , or null if there is no such
        ///     attribute.
        /// </returns>
        public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType, bool inherit)
        {
            return Attribute.GetCustomAttribute(element, attributeType, inherit);
        }

        /// <summary>
        ///     Determines whether any custom attributes are applied to a module. Parameters specify the module, the type of
        ///     the custom attribute to search for, and an ignored search option.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a portable executable file.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
        /// <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
        public static bool IsDefined(this Module element, Type attributeType, bool inherit)
        {
            return Attribute.IsDefined(element, attributeType, inherit);
        }

        /// <summary>
        ///     Determines whether any custom attributes are applied to a member of a type. Parameters specify the member,
        ///     the type of the custom attribute to search for, and whether to search ancestors of the member.
        /// </summary>
        /// <param name="element">
        ///     An object derived from the  class that describes a constructor, event, field, method, type,
        ///     or property member of a class.
        /// </param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
        /// <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
        public static bool IsDefined(this MemberInfo element, Type attributeType, bool inherit)
        {
            return Attribute.IsDefined(element, attributeType, inherit);
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, the
        ///     type of the custom attribute to search for, and whether to search ancestors of the member.
        /// </summary>
        /// <param name="element">
        ///     An object derived from the  class that describes a constructor, event, field, method, or
        ///     property member of a class.
        /// </param>
        /// <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
        /// <returns>
        ///     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
        ///     exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this MemberInfo element, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, inherit);
        }

        /// <summary>
        ///     Retrieves a custom attribute applied to a member of a type. Parameters specify the member, the type of the
        ///     custom attribute to search for, and whether to search ancestors of the member.
        /// </summary>
        /// <param name="element">
        ///     An object derived from the  class that describes a constructor, event, field, method, or
        ///     property member of a class.
        /// </param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
        /// <returns>
        ///     A reference to the single custom attribute of type  that is applied to , or null if there is no such
        ///     attribute.
        /// </returns>
        public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType, bool inherit)
        {
            return Attribute.GetCustomAttribute(element, attributeType, inherit);
        }

        /// <summary>
        ///     An Assembly extension method that gets an attribute.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The attribute.</returns>
        public static T GetAttribute<T>(this Assembly @this) where T : Attribute
        {
            object[] configAttributes = Attribute.GetCustomAttributes(@this, typeof(T), false);

            if (configAttributes != null && configAttributes.Length > 0) return (T) configAttributes[0];

            return null;
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to an assembly. A parameter specifies the assembly.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
        /// <returns>
        ///     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
        ///     exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this Assembly element)
        {
            return Attribute.GetCustomAttributes(element);
        }

        /// <summary>
        ///     Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, and an
        ///     ignored search option.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
        /// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
        /// <returns>
        ///     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
        ///     exist.
        /// </returns>
        public static Attribute[] GetCustomAttributes(this Assembly element, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, inherit);
        }

        /// <summary>
        ///     Retrieves a custom attribute applied to a specified assembly. Parameters specify the assembly and the type of
        ///     the custom attribute to search for.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <returns>
        ///     A reference to the single custom attribute of type  that is applied to , or null if there is no such
        ///     attribute.
        /// </returns>
        public static Attribute GetCustomAttribute(this Assembly element, Type attributeType)
        {
            return Attribute.GetCustomAttribute(element, attributeType);
        }

        /// <summary>
        ///     Retrieves a custom attribute applied to an assembly. Parameters specify the assembly, the type of the custom
        ///     attribute to search for, and an ignored search option.
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
        /// <returns>
        ///     A reference to the single custom attribute of type  that is applied to , or null if there is no such
        ///     attribute.
        /// </returns>
        public static Attribute GetCustomAttribute(this Assembly element, Type attributeType, bool inherit)
        {
            return Attribute.GetCustomAttribute(element, attributeType, inherit);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is attribute defined.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="attributeType">Type of the attribute.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>true if attribute defined, false if not.</returns>
        public static bool IsAttributeDefined(this object @this, Type attributeType, bool inherit)
        {
            return @this.GetType().IsDefined(attributeType, inherit);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is attribute defined.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>true if attribute defined, false if not.</returns>
        public static bool IsAttributeDefined<T>(this object @this, bool inherit) where T : Attribute
        {
            return @this.GetType().IsDefined(typeof(T), inherit);
        }

        /// <summary>An object extension method that gets the first custom attribute.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="attribute">The attribute.</param>
        /// <returns>The custom attribute.</returns>
        public static object GetCustomAttribute(this object @this, Type attribute)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? Attribute.GetCustomAttribute(type.GetField(@this.ToString()), attribute)
                : Attribute.GetCustomAttribute(type, attribute);
        }

        /// <summary>
        ///     An object extension method that gets the first custom attribute.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="attribute">The attribute.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>The custom attribute.</returns>
        public static object GetCustomAttribute(this object @this, Type attribute, bool inherit)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? Attribute.GetCustomAttribute(type.GetField(@this.ToString()), attribute, inherit)
                : Attribute.GetCustomAttribute(type, attribute, inherit);
        }

        /// <summary>An object extension method that gets custom attribute.</summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The custom attribute.</returns>
        public static T GetCustomAttribute<T>(this object @this) where T : Attribute
        {
            var type = @this.GetType();

            return (T) (type.IsEnum
                ? Attribute.GetCustomAttribute(type.GetField(@this.ToString()), typeof(T))
                : Attribute.GetCustomAttribute(type, typeof(T)));
        }

        /// <summary>
        ///     An object extension method that gets custom attribute.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>The custom attribute.</returns>
        public static T GetCustomAttribute<T>(this object @this, bool inherit) where T : Attribute
        {
            var type = @this.GetType();

            return (T) (type.IsEnum
                ? Attribute.GetCustomAttribute(type.GetField(@this.ToString()), typeof(T), inherit)
                : Attribute.GetCustomAttribute(type, typeof(T), inherit));
        }

        /// <summary>An object extension method that gets custom attribute.</summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The custom attribute.</returns>
        public static T GetCustomAttribute<T>(this MemberInfo @this) where T : Attribute
        {
            return (T) Attribute.GetCustomAttribute(@this, typeof(T));
        }

        /// <summary>An object extension method that gets custom attribute.</summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>The custom attribute.</returns>
        public static T GetCustomAttribute<T>(this MemberInfo @this, bool inherit) where T : Attribute
        {
            return (T) Attribute.GetCustomAttribute(@this, typeof(T), inherit);
        }

        /// <summary>A MemberInfo extension method that gets custom attribute by full name.</summary>
        /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
        /// <param name="this">The @this to act on.</param>
        /// <param name="fullName">Name of the full.</param>
        /// <returns>The custom attribute by full name.</returns>
        public static object GetCustomAttributeByFullName(this object @this, string fullName)
        {
            var type = @this.GetType();

            var attributes = type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes().Where(x => x.GetType().FullName == fullName)
                    .ToArray()
                : type.GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray();

            if (attributes.Length == 0) return null;

            if (attributes.Length == 1) return attributes[0];

            throw new Exception(string.Format(
                "Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.",
                attributes.Length));
        }

        /// <summary>A MemberInfo extension method that gets custom attribute by full name.</summary>
        /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
        /// <param name="this">The @this to act on.</param>
        /// <param name="fullName">Name of the full.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>The custom attribute by full name.</returns>
        public static object GetCustomAttributeByFullName(this object @this, string fullName, bool inherit)
        {
            var type = @this.GetType();

            var attributes = type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName)
                    .ToArray()
                : type.GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray();

            if (attributes.Length == 0) return null;

            if (attributes.Length == 1) return attributes[0];

            throw new Exception(string.Format(
                "Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.",
                attributes.Length));
        }

        /// <summary>A MemberInfo extension method that gets custom attribute by full name.</summary>
        /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
        /// <param name="this">The @this to act on.</param>
        /// <param name="fullName">Name of the full.</param>
        /// <returns>The custom attribute by full name.</returns>
        public static object GetCustomAttributeByFullName(this MemberInfo @this, string fullName)
        {
            var attributes = @this.GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray();

            if (attributes.Length == 0) return null;

            if (attributes.Length == 1) return attributes[0];

            throw new Exception(string.Format(
                "Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.",
                attributes.Length));
        }

        /// <summary>A MemberInfo extension method that gets custom attribute by full name.</summary>
        /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
        /// <param name="this">The @this to act on.</param>
        /// <param name="fullName">Name of the full.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>The custom attribute by full name.</returns>
        public static object GetCustomAttributeByFullName(this MemberInfo @this, string fullName, bool inherit)
        {
            var attributes = @this.GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray();

            if (attributes.Length == 0) return null;

            if (attributes.Length == 1) return attributes[0];

            throw new Exception(string.Format(
                "Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.",
                attributes.Length));
        }

        /// <summary>An object extension method that gets custom attribute by name.</summary>
        /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The name.</param>
        /// <returns>The custom attribute by name.</returns>
        public static object GetCustomAttributeByName(this object @this, string name)
        {
            var type = @this.GetType();

            var attributes = type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray()
                : type.GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray();

            if (attributes.Length == 0) return null;

            if (attributes.Length == 1) return attributes[0];

            throw new Exception(string.Format(
                "Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.",
                attributes.Length));
        }

        /// <summary>An object extension method that gets custom attribute by name.</summary>
        /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The name.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>The custom attribute by name.</returns>
        public static object GetCustomAttributeByName(this object @this, string name, bool inherit)
        {
            var type = @this.GetType();

            var attributes = type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes(inherit).Where(x => x.GetType().Name == name)
                    .ToArray()
                : type.GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray();

            if (attributes.Length == 0) return null;

            if (attributes.Length == 1) return attributes[0];

            throw new Exception(string.Format(
                "Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.",
                attributes.Length));
        }

        /// <summary>An object extension method that gets custom attribute by name.</summary>
        /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The name.</param>
        /// <returns>The custom attribute by name.</returns>
        public static object GetCustomAttributeByName(this MemberInfo @this, string name)
        {
            var attributes = @this.GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray();

            if (attributes.Length == 0) return null;

            if (attributes.Length == 1) return attributes[0];

            throw new Exception(string.Format(
                "Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.",
                attributes.Length));
        }

        /// <summary>An object extension method that gets custom attribute by name.</summary>
        /// <exception cref="Exception">Thrown when an exception error condition occurs.</exception>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The name.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>The custom attribute by name.</returns>
        public static object GetCustomAttributeByName(this MemberInfo @this, string name, bool inherit)
        {
            var attributes = @this.GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray();

            if (attributes.Length == 0) return null;

            if (attributes.Length == 1) return attributes[0];

            throw new Exception(string.Format(
                "Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.",
                attributes.Length));
        }

        /// <summary>
        ///     An object extension method that gets description attribute.
        /// </summary>
        /// <param name="value">The value to act on.</param>
        /// <returns>The description attribute.</returns>
        public static string GetCustomAttributeDescription(this object value)
        {
            var type = value.GetType();

            var attributes = type.IsEnum
                ? type.GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute))
                : type.GetCustomAttributes(typeof(DescriptionAttribute));

            var enumerable = attributes ?? attributes.ToArray();
            if (enumerable.Length == 0) return null;
            if (enumerable.Length == 1) return ((DescriptionAttribute) enumerable[0]).Description;

            throw new Exception(string.Format(
                "Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.",
                enumerable.Length));
        }

        /// <summary>An object extension method that gets description attribute.</summary>
        /// <param name="value">The value to act on.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>The description attribute.</returns>
        public static string GetCustomAttributeDescription(this object value, bool inherit)
        {
            var type = value.GetType();

            var attributes = type.IsEnum
                ? type.GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), inherit)
                : type.GetCustomAttributes(typeof(DescriptionAttribute), inherit);


            if (attributes.Length == 0) return null;
            if (attributes.Length == 1) return ((DescriptionAttribute) attributes[0]).Description;

            throw new Exception(string.Format(
                "Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.",
                attributes.Length));
        }

        /// <summary>An object extension method that gets description attribute.</summary>
        /// <param name="value">The value to act on.</param>
        /// <returns>The description attribute.</returns>
        public static string GetCustomAttributeDescription(this MemberInfo value)
        {
            var attributes = value.GetCustomAttributes(typeof(DescriptionAttribute));

            var enumerable = attributes ?? attributes.ToArray();
            if (enumerable.Length == 0) return null;
            if (enumerable.Length == 1) return ((DescriptionAttribute) enumerable[0]).Description;

            throw new Exception(string.Format(
                "Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.",
                enumerable.Length));
        }

        /// <summary>An object extension method that gets description attribute.</summary>
        /// <param name="value">The value to act on.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>The description attribute.</returns>
        public static string GetCustomAttributeDescription(this MemberInfo value, bool inherit)
        {
            var attributes = value.GetCustomAttributes(typeof(DescriptionAttribute), inherit);

            if (attributes.Length == 0) return null;
            if (attributes.Length == 1) return ((DescriptionAttribute) attributes[0]).Description;

            throw new Exception(string.Format(
                "Ambiguous attribute. Multiple custom attributes of the same type found: {0} attributes found.",
                attributes.Length));
        }

        /// <summary>An object extension method that gets custom attributes.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>An array of object.</returns>
        public static Attribute[] GetCustomAttributes(this object @this)
        {
            var type = @this.GetType();

            return type.IsEnum ? type.GetField(@this.ToString()).GetCustomAttributes() : type.GetCustomAttributes();
        }

        /// <summary>
        ///     An object extension method that gets custom attributes.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>An array of object.</returns>
        public static object[] GetCustomAttributes(this object @this, bool inherit)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes(inherit)
                : type.GetCustomAttributes(inherit);
        }

        /// <summary>An object extension method that gets custom attributes.</summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>An array of object.</returns>
        public static T[] GetCustomAttributes<T>(this object @this) where T : Attribute
        {
            var type = @this.GetType();

            return (T[]) (type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes(typeof(T))
                : type.GetCustomAttributes(typeof(T)));
        }

        /// <summary>
        ///     An object extension method that gets custom attributes.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>An array of object.</returns>
        public static T[] GetCustomAttributes<T>(this object @this, bool inherit) where T : Attribute
        {
            var type = @this.GetType();

            return (T[]) (type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes(typeof(T), inherit)
                : type.GetCustomAttributes(typeof(T), inherit));
        }

        /// <summary>An object extension method that gets custom attributes.</summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>An array of object.</returns>
        public static T[] GetCustomAttributes<T>(this MemberInfo @this) where T : Attribute
        {
            return (T[]) @this.GetCustomAttributes(typeof(T));
        }

        /// <summary>An object extension method that gets custom attributes.</summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>An array of object.</returns>
        public static T[] GetCustomAttributes<T>(this MemberInfo @this, bool inherit) where T : Attribute
        {
            return (T[]) @this.GetCustomAttributes(typeof(T), inherit);
        }

        /// <summary>An object extension method that gets custom attributes by full name.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="fullName">Name of the full.</param>
        /// <returns>An array of attribute.</returns>
        public static Attribute[] GetCustomAttributesByFullName(this object @this, string fullName)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes().Where(x => x.GetType().FullName == fullName)
                    .ToArray()
                : type.GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray();
        }

        /// <summary>An object extension method that gets custom attributes by full name.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="fullName">Name of the full.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>An array of attribute.</returns>
        public static object[] GetCustomAttributesByFullName(this object @this, string fullName, bool inherit)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName)
                    .ToArray()
                : type.GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray();
        }

        /// <summary>An object extension method that gets custom attributes by full name.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="fullName">Name of the full.</param>
        /// <returns>An array of attribute.</returns>
        public static Attribute[] GetCustomAttributesByFullName(this MemberInfo @this, string fullName)
        {
            return @this.GetCustomAttributes().Where(x => x.GetType().FullName == fullName).ToArray();
        }

        /// <summary>An object extension method that gets custom attributes by full name.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="fullName">Name of the full.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>An array of attribute.</returns>
        public static object[] GetCustomAttributesByFullName(this MemberInfo @this, string fullName, bool inherit)
        {
            return @this.GetCustomAttributes(inherit).Where(x => x.GetType().FullName == fullName).ToArray();
        }


        /// <summary>An object extension method that gets custom attributes by name.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The name.</param>
        /// <returns>An array of attribute.</returns>
        public static Attribute[] GetCustomAttributesByName(this object @this, string name)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray()
                : type.GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray();
        }

        /// <summary>An object extension method that gets custom attributes by name.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The name.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>An array of attribute.</returns>
        public static object[] GetCustomAttributesByName(this object @this, string name, bool inherit)
        {
            var type = @this.GetType();

            return type.IsEnum
                ? type.GetField(@this.ToString()).GetCustomAttributes(inherit).Where(x => x.GetType().Name == name)
                    .ToArray()
                : type.GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray();
        }

        /// <summary>An object extension method that gets custom attributes by name.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The name.</param>
        /// <returns>An array of attribute.</returns>
        public static Attribute[] GetCustomAttributesByName(this MemberInfo @this, string name)
        {
            return @this.GetCustomAttributes().Where(x => x.GetType().Name == name).ToArray();
        }

        /// <summary>An object extension method that gets custom attributes by name.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The name.</param>
        /// <param name="inherit">true to inherit.</param>
        /// <returns>An array of attribute.</returns>
        public static object[] GetCustomAttributesByName(this MemberInfo @this, string name, bool inherit)
        {
            return @this.GetCustomAttributes(inherit).Where(x => x.GetType().Name == name).ToArray();
        }

        #endregion
    }
}