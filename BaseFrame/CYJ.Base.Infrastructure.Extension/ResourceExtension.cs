using System;
using System.IO;
using System.Text;
using Aquarium.Util.Extension.ByteArrayExtension;
using CYJ.Utils.Extension.IOExtension;

// ReSharper disable once CheckNamespace
namespace Aquarium.Util.Extension
{
    public static class ResourceExtension
    {
        public static string GetAssemblyResource(this Type type, string name, Encoding encoding = null)
        {
            var sm = type.Assembly.GetManifestResourceStream(name);
            return sm.ToByteArray().ToString(encoding);
        }

        public static Stream GetAssemblyResourceStream(this Type type, string name, Encoding encoding = null)
        {
            var sm = type.Assembly.GetManifestResourceStream(name);
            return sm;
        }
    }
}