﻿/*
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

namespace Balikuj.Client.Errors
{
    public class ApiCarrierError
    {
        public ApiCarrierError() { }

        public ApiCarrierError(string errorCode, string message, string reference)
        {
            this.ErrorCode = errorCode;
            this.Message = message;
            this.Reference = reference;
        }

        /// <summary>
        /// Error code
        /// </summary>
        /// <example>InvalidUserInputError</example>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error message text
        /// </summary>
        /// <example>String must contain at least 3 character(s)</example>
        public string Message { get; set; }

        /// <summary>
        /// ID of the referenced entity
        /// </summary>
        /// <example>0 -> receiver -> address -> postalCode</example>
        public string Reference { get; set; }
    }
}
