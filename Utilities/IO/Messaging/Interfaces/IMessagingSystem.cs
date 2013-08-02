﻿/*
Copyright (c) 2013 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

#region Usings
using System;
using System.Threading.Tasks;


#endregion

namespace Utilities.IO.Messaging.Interfaces
{
    /// <summary>
    /// Messaging system interface
    /// </summary>
    public interface IMessagingSystem
    {
        /// <summary>
        /// Name of the communicator
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Message type used by the communicator
        /// </summary>
        Type MessageType { get; }

        /// <summary>
        /// Sends a message asynchronously
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="Message">Message to send</param>
        /// <param name="Model">Model object</param>
        /// <returns>The async task</returns>
        Task Send<T>(IMessage Message, T Model = default(T))
            where T : class;
    }
}
