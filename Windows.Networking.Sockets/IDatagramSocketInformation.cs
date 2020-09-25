//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

namespace Windows.Networking.Sockets
{
    internal interface IDatagramSocketInformation
    {
        HostName LocalAddress { get; }

        string LocalPort { get; }

        HostName RemoteAddress { get; }

        string RemotePort { get; }
    }
}
