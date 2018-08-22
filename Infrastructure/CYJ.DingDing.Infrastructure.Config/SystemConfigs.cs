using System;
using System.Collections.Generic;
using System.Text;

namespace CYJ.DingDing.Infrastructure.Config
{
    public class SystemConfigs
    {
        private readonly IConfigHelper _configHelper;

        public SystemConfigs(IConfigHelper configHelper)
        {
            _configHelper = configHelper;
        }

        /// <summary>
        /// 获取CorpID
        /// </summary>
        /// <returns></returns>
        public String CorpId => _configHelper.Get("CorpID");

        /// <summary>
        /// 获取CorpSecret
        /// </summary>
        /// <returns></returns>
        public String CorpSecret => _configHelper.Get("CorpSecret");

    }
}
