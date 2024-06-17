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

namespace Balikuj.Client.Models.Package
{
    public class PackageActivityModel
    {
        /// <summary>
        /// Gets or sets the ID of the package activity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the date of the package activity.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the category of the package activity.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the package activity is a master activity.
        /// </summary>
        public bool IsMaster { get; set; }

        /// <summary>
        /// Gets or sets the ID of the master activity.
        /// </summary>
        public int? MasterId { get; set; }

        /// <summary>
        /// Gets or sets the name of the package activity.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the system name of the package activity.
        /// </summary>
        public string NameSystem { get; set; }

        /// <summary>
        /// Gets or sets the type of the package tracking status.
        /// </summary>
        public PackageTrackingStatusType Type { get; set; }

        /// <summary>
        /// Gets or sets the item associated with the package activity.
        /// </summary>
        public string Item { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the package has been delivered.
        /// </summary>
        public bool Delivered { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether the package has been canceled.
        /// </summary>
        public bool Canceled { get; set; } = false;

        /// <summary>
        /// Gets or sets the carrier code associated with the package activity.
        /// </summary>
        public string CarrierCode { get; set; }

        /// <summary>
        /// Gets or sets the ID of the package.
        /// </summary>
        public int PackageId { get; set; }

        /// <summary>
        /// Gets or sets the custom package number.
        /// </summary>
        public string PackageNumberCustom { get; set; }

        /// <summary>
        /// Gets or sets the carrier package number.
        /// </summary>
        public string PackageNumberCarrier { get; set; }

        /// <summary>
        /// Gets or sets the recipient company name.
        /// </summary>
        public string RecCompany { get; set; }

        /// <summary>
        /// Gets or sets the recipient name.
        /// </summary>
        public string RecName { get; set; }

        /// <summary>
        /// Gets or sets the recipient street.
        /// </summary>
        public string RecStreet { get; set; }

        /// <summary>
        /// Gets or sets the recipient city.
        /// </summary>
        public string RecCity { get; set; }

        /// <summary>
        /// Gets or sets the recipient ZIP code.
        /// </summary>
        public string RecZip { get; set; }
    }
}
