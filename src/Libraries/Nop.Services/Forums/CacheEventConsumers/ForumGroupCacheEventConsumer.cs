﻿using Nop.Core.Domain.Forums;
using Nop.Services.Caching;

namespace Nop.Services.Forums.CacheEventConsumers
{
    /// <summary>
    /// Represents a forum group cache event consumer
    /// </summary>
    public partial class ForumGroupCacheEventConsumer : CacheEventConsumer<ForumGroup>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(ForumGroup entity)
        {
            Remove(NopForumDefaults.ForumGroupAllCacheKey);
            var cacheKey = NopForumDefaults.ForumAllByForumGroupIdCacheKey.FillCacheKey(entity);
            Remove(cacheKey);
        }
    }
}