using System.Collections.Generic;
using System.Reflection;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension.ReflectionExtension
{
    public static class MemberExtension
    {
        /// <summary>A T extension method that gets member paths.</summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="path">Full pathname of the file.</param>
        /// <returns>An array of member information.</returns>
        public static MemberInfo[] GetMemberPaths<T>(this T @this, string path)
        {
            var lastType = @this.GetType();
            var paths = path.Split('.');

            var memberPaths = new List<MemberInfo>();

            foreach (var item in paths)
            {
                var propertyInfo = lastType.GetProperty(item);
                var fieldInfo = lastType.GetField(item);

                if (propertyInfo != null)
                {
                    memberPaths.Add(propertyInfo);
                    lastType = propertyInfo.PropertyType;
                }

                if (fieldInfo != null)
                {
                    memberPaths.Add(fieldInfo);
                    lastType = fieldInfo.FieldType;
                }
            }

            return memberPaths.ToArray();
        }
    }
}