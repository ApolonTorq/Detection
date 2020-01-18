// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System;

using Wangkanai.Detection.Models;

namespace Wangkanai.Detection
{
    [Obsolete]
    public interface ICrawlerFactory
    {
        string? Name { get; set; }
        Crawler Type { get; set; }
        Version? Version { get; set; }
    }
}