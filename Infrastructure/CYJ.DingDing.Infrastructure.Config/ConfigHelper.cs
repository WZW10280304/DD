using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CYJ.DingDing.Infrastructure.Config
{
    public class ConfigHelper : IConfigHelper
    {
        private readonly IConfiguration _configuration;

        public ConfigHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public String Get(String key)
        {
            String value = _configuration[key];
            if (value == null)
            {
                throw new Exception($"{key} is null.请确认配置文件中是否已配置.");
            }
            return value;
        }
    }
}
