using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CYJ.Utils.Extension.SerializationExtension
{
// ReSharper disable once CheckNamespace
    public enum ContractResolverType
    {
        Default = 0,
        CamelCase = 1
    }

    public static class JsonExtension
    {
        private static readonly IContractResolver CamelCasePropertyNamesContractResolver =
            new CamelCasePropertyNamesContractResolver();

        private static readonly IContractResolver DefaultContractResolver =
            new DefaultContractResolver();

        /// <summary>
        ///     获取IContractResolver
        /// </summary>
        /// <param name="contractResolverType"></param>
        /// <returns></returns>
        private static IContractResolver GetContractResolver(ContractResolverType contractResolverType)
        {
            switch (contractResolverType)
            {
                case ContractResolverType.Default:
                    return DefaultContractResolver;

                case ContractResolverType.CamelCase:
                    return CamelCasePropertyNamesContractResolver;

                default:
                    return DefaultContractResolver;
            }
        }


        #region Json转换

        /// <summary>
        ///     将对象转换为Json字符串
        /// </summary>
        /// <param name="jsonData"></param>
        /// <param name="contractResolverType"></param>
        /// <returns></returns>
        public static string ToJson(this object jsonData,
            ContractResolverType contractResolverType = ContractResolverType.CamelCase)
        {
            return JsonConvert.SerializeObject(jsonData, new JsonSerializerSettings
            {
                ContractResolver = GetContractResolver(contractResolverType),
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        /// <summary>
        ///     序列化JSON字符串不附带值为NULL的字符串
        /// </summary>
        /// <param name="jsonData"></param>
        /// <param name="contractResolverType"></param>
        /// <returns></returns>
        public static string ToJsonWithOutNull(this object jsonData,
            ContractResolverType contractResolverType = ContractResolverType.CamelCase)
        {
            return JsonConvert.SerializeObject(jsonData, new JsonSerializerSettings
            {
                ContractResolver = GetContractResolver(contractResolverType),
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        /// <summary>
        ///     将Json字符串转换为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public static T ToObjectFromJson<T>(this string jsonStr)
        {
            return JsonConvert.DeserializeObject<T>(jsonStr);
        }
        #endregion Json转换
    }
}