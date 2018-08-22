using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Aquarium.Util.Extension.StringExtension;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.ReflectionExtension
{
    public static class AssemblyExtension
    {
        /// <summary>
        ///    判断是否将任何自定义特性应用于程序集
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
        public static bool IsDefined(this Assembly element, Type attributeType)
        {
            return Attribute.IsDefined(element, attributeType);
        }

        /// <summary>
        ///    判断是否将任何自定义特性应用于程序集
        /// </summary>
        /// <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
        /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
        /// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
        /// <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
        public static bool IsDefined(this Assembly element, Type attributeType, bool inherit)
        {
            return Attribute.IsDefined(element, attributeType, inherit);
        }
        /// <summary>
        /// 获取assembly名称
        /// </summary>
        /// <param name="assembly"></param>
        /// <returns></returns>
        public static string GetAssemblyTitle(this Assembly assembly)
        {
            var attributes = assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            if (attributes.Length <= 0)
                return Path.GetFileNameWithoutExtension(assembly.CodeBase);
            var titleAttribute = (AssemblyTitleAttribute) attributes[0];
            return titleAttribute.Title.IsNullOrWhiteSpace()
                ? titleAttribute.Title
                : Path.GetFileNameWithoutExtension(assembly.CodeBase);
        }
        /// <summary>
        /// 获取程序集中的类型
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="all"></param>
        /// <param name="isSubclassOf"></param>
        /// <returns></returns>
        public static Type[] GetTypes(this Assembly assembly, bool all = false, Type isSubclassOf = null)
        {
            if (all)
                return assembly.GetTypes();
            var types = assembly.GetTypes().Where(x => x.IsClass && x.IsPublic).ToArray();
            return isSubclassOf == null ? types : types.Where(x => x.IsSubclassOf(isSubclassOf)).ToArray();
        }
    }
}