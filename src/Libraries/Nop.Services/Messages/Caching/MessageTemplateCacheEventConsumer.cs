﻿using Nop.Core.Domain.Messages;
using Nop.Services.Caching;

namespace Nop.Services.Messages.Caching
{
    /// <summary>
    /// Represents a message template cache event consumer
    /// </summary>
    public partial class MessageTemplateCacheEventConsumer : CacheEventConsumer<MessageTemplate>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(MessageTemplate entity)
        {
            RemoveByPrefix(NopMessageDefaults.MessageTemplatesAllPrefixCacheKey);
            var prefix = NopMessageDefaults.MessageTemplatesByNamePrefixCacheKey.ToCacheKey(entity.Name);
            RemoveByPrefix(prefix);
        }
    }
}
