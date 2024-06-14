using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Carrier
{
    public class PackageTrackingStatusRequestModel
    {
        /// <summary>
        /// List of package numbers of the carrier (PackageNumberCarrier)
		/// </summary>
		/// <example>["DR28103873681"]</example>
		public IList<string> Packages { get; set; }
    }
}
