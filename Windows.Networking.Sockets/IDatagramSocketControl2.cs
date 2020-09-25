﻿//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

namespace Windows.Networking.Sockets
{
    internal interface IDatagramSocketControl2
    {
        bool DontFragment { get; set; }

        uint InboundBufferSizeInBytes { get; set; }
    }
}