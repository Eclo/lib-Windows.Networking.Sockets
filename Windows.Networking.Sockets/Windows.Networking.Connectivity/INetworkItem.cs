//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Networking.Connectivity
{
    internal interface INetworkItem
    {
        NetworkTypes GetNetworkTypes();

        Guid NetworkId { get; }
    }
}
