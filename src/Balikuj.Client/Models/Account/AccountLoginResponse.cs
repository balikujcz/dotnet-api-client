/*
* Copyright (c) 2024 Balíkuj.cz
* http://balikuj.cz
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

namespace Balikuj.Client.Models.Account
{
    public class AccountLoginResponse
    {
        /// <summary>
        /// Auth token for further requests
        /// </summary>
        /// <example>285A1DAE198E75771BD78A7DAF1782DD47BFB7E968A5983A3585B9CFC2914F0507A3DE257CDC87CDCAD808CB34CD05DA47D9EB7C9D8B987550B11921DECC66D4</example>
        public string AuthToken { get; set; }

        /// <summary>
        /// Datetime when the token expires
        /// </summary>
        /// <example>2023-12-12T13:01:13.5878022+01:00</example>
        public DateTime ExpiresIn { get; set; }
    }
}
