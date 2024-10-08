// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.Extensions.Configuration.Json;

/// <summary>
/// Represents a JSON file as an <see cref="IConfigurationSource"/>.
/// </summary>
public class TenantJsonConfigurationSource : FileConfigurationSource
{
    /// <summary>
    /// Builds the <see cref="TenantJsonConfigurationProvider"/> for this source.
    /// </summary>
    /// <param name="builder">The <see cref="IConfigurationBuilder"/>.</param>
    /// <returns>A <see cref="TenantJsonConfigurationProvider"/>.</returns>
    public override IConfigurationProvider Build(IConfigurationBuilder builder)
    {
        EnsureDefaults(builder);
        return new TenantJsonConfigurationProvider(this);
    }
}
