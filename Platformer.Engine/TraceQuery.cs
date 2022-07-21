﻿/*
 *  Copyright (c) 2016 Rob Harwood <rob@codemlia.com>
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 *  and associated documentation files (the "Software"), to deal in the Software without
 *  restriction, including without limitation the rights to use, copy, modify, merge, publish,
 *  distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the
 *  Software is furnished to do so, subject to the following conditions:
 *
 *  The above copyright notice and this permission notice shall be included in all copies or
 *  substantial portions of the Software.
 *
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING
 *  BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 *  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 *  DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
namespace Platformer.Engine
{
    using System;
    using Entities;

    /// <summary>
    /// Data strcuture that holds data required to perform a traceline.
    /// </summary>
    public struct TraceQuery
    {
        /// <summary>
        /// Gets or sets the line that will be traced.
        /// </summary>
        public Line Line { get; set; }

        /// <summary>
        /// Gets or sets a specfic entity the traceline will ignore.
        /// </summary>
        public GameEntity Ignore { get; set; }

        /// <summary>
        /// Gets or sets a value which if specified, limits the type of entity that can be hit by the trace line.
        /// </summary>
        public Type EntityType { get; set; }

        /// <summary>
        /// Gets or sets the trace options.
        /// </summary>
        public TraceLineOptions Options { get; set; }

        /// <summary>
        /// If specified, gets or sets the collision path that will be tested.
        /// </summary>
        public int? CollisionPath { get; set; }
    }
}
