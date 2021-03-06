﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Microsoft.Azure.SignalR
{
    internal class ServiceOptionsSetup : IConfigureOptions<ServiceOptions>
    {
        private readonly string _connectionString;

        public ServiceOptionsSetup(IConfiguration configuration)
        {
            _connectionString = configuration.GetSection(ServiceOptions.ConnectionStringDefaultKey).Value;
        }

        public void Configure(ServiceOptions options)
        {
            if (options.ConnectionString == null)
            {
                options.ConnectionString = _connectionString;
            }
        }
    }
}
