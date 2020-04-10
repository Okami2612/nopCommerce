﻿using Nop.Core.Domain.Security;
using Nop.Services.Caching;

namespace Nop.Services.Security.CacheEventConsumers
{
    /// <summary>
    /// Represents a permission record cache event consumer
    /// </summary>
    public partial class PermissionRecordCacheEventConsumer : CacheEventConsumer<PermissionRecord>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(PermissionRecord entity)
        {
            var prefix = NopSecurityDefaults.PermissionsAllowedPrefixCacheKey.ToCacheKey(entity.SystemName);
            RemoveByPrefix(prefix);
            RemoveByPrefix(NopSecurityDefaults.PermissionsAllByCustomerRoleIdPrefixCacheKey);
        }
    }
}