﻿/*
* Copyright (c) 2024 Balíkuj.cz
* http://www.balikuj.cz
* Ing. Petr Rympler
*
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

using System;

namespace Balikuj.Client.Exceptions
{
    public class BalikujException : Exception
    {
        /// <summary>
        /// Balíkuj exception
        /// </summary>
        public BalikujException()
        {
        }

        /// <summary>
        /// Create a new Balikuj exception
        /// </summary>
        /// <param name="message"></param>
        public BalikujException(string message) : base(message)
        {
        }

        /// <summary>
        /// Balikuj exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public BalikujException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}