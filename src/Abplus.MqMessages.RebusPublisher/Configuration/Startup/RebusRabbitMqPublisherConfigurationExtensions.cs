﻿using Abp.MqMessages.Publishers;

namespace Abp.Configuration.Startup
{
    public static class RebusRabbitMqPublisherConfigurationExtensions
    {
        public static IRebusRabbitMqPublisherModuleConfig  UseAbplusRebusRabbitMqPublisher(this IModuleConfigurations configurations)
        {
            return configurations.AbpConfiguration.GetOrCreate("Modules.Abp.RebusRabbitMqPublisher", () => configurations.AbpConfiguration.IocManager.Resolve<IRebusRabbitMqPublisherModuleConfig>());
        }
    }
}
