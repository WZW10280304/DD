using System.Linq;
using System.Reflection;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.ReflectionExtension
{
    public static class MethodExtension
    {
        /// <summary>
        ///     A T extension method that searches for the public method with the specified name.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The string containing the name of the public method to get.</param>
        /// <returns>
        ///     An object that represents the public method with the specified name, if found; otherwise, null.
        /// </returns>
        public static MethodInfo GetMethod<T>(this T @this, string name)
        {
            return @this.GetType().GetMethod(name);
        }

        /// <summary>
        ///     A T extension method that searches for the specified method whose parameters match the specified argument
        ///     types and modifiers, using the specified binding constraints.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="name">The string containing the name of the public method to get.</param>
        /// <param name="bindingAttr">A bitmask comprised of one or more BindingFlags that specify how the search is conducted.</param>
        /// <returns>
        ///     An object that represents the public method with the specified name, if found; otherwise, null.
        /// </returns>
        public static MethodInfo GetMethod<T>(this T @this, string name, BindingFlags bindingAttr)
        {
            return @this.GetType().GetMethod(name, bindingAttr);
        }

        /// <summary>
        ///     A T extension method that returns all the public methods of the current Type.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>
        ///     An array of MethodInfo objects representing all the public methods defined for the current Type. or An empty
        ///     array of type MethodInfo, if no public methods are defined for the current Type.
        /// </returns>
        public static MethodInfo[] GetMethods<T>(this T @this)
        {
            return @this.GetType().GetMethods();
        }

        /// <summary>
        ///     A T extension method that searches for the methods defined for the current Type, using the specified binding
        ///     constraints.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="bindingAttr">A bitmask comprised of one or more BindingFlags that specify how the search is conducted.</param>
        /// <returns>
        ///     An array of MethodInfo objects representing all methods defined for the current Type that match the specified
        ///     binding constraints. or An empty array of type MethodInfo, if no methods are defined for the current Type, or
        ///     if none of the defined methods match the binding constraints.
        /// </returns>
        public static MethodInfo[] GetMethods<T>(this T @this, BindingFlags bindingAttr)
        {
            return GetMethods(@this.GetType(), bindingAttr);
        }


        /// <summary>
        ///     An object extension method that executes the method on a different thread, and waits for the result.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="obj">The obj to act on.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="parameters">Options for controlling the operation.</param>
        /// <returns>An object.</returns>
        public static object InvokeMethod<T>(this T obj, string methodName, params object[] parameters)
        {
            var type = obj.GetType();
            var method = type.GetMethod(methodName, parameters.Select(o => o.GetType()).ToArray());

            return method.Invoke(obj, parameters);
        }

        /// <summary>
        ///     An object extension method that executes the method on a different thread, and waits for the result.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="obj">The obj to act on.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="parameters">Options for controlling the operation.</param>
        /// <returns>A T.</returns>
        public static T InvokeMethod<T>(this object obj, string methodName, params object[] parameters)
        {
            var type = obj.GetType();
            var method = type.GetMethod(methodName, parameters.Select(o => o.GetType()).ToArray());

            var value = method.Invoke(obj, parameters);
            return value is T ? (T) value : default(T);
        }
    }
}