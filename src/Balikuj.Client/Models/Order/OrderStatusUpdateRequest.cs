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

using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Order
{
    public class OrderStatusUpdateRequest
    {
        /// <summary>
        /// Code of the status from the source system. It can be a number or text. The value is then adjusted according to the target system.
		/// </summary>
		public string[] SourceId { get; set; }

        /// <summary>
        /// Name of the order status
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Color of the text of the selected order status
        /// </summary>
        public string TextColor { get; set; } = null;

        /// <summary>
        /// Color of the background of the selected order status
        /// </summary>
        public string BackgroundColor { get; set; } = null;

        /// <summary>
        /// Informations, whether it is a system status. System statuses cannot be deleted, only external status codes can be mapped.
        /// </summary>
        public bool IsSystem { get; set; }

        /// <summary>
        /// Pořadí výpisu tohoto stavového kódu
        /// Order of display of this status code
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
