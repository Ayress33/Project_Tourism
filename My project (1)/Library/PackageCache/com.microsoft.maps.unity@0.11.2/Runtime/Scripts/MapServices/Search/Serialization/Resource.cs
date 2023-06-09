﻿// Copyright(c) Microsoft Corporation.All rights reserved.
// Licensed under the MIT License.

using System;

namespace Microsoft.Maps.Unity.Search
{
    [Serializable]
    internal class Resource
    {
        public string __type = null;

        public string name = null;

        public Point point = null;

        public Address address = null;

        public string confidence = null;

        public string entityType = null;

        public string[] matchCodes = null;
    }
}
