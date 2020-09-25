﻿//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

namespace Windows.Networking.Connectivity
{
    internal interface IIPInformation
    {
        NetworkAdapter NetworkAdapter { get; }

        byte PrefixLength { get; }
    }
}
