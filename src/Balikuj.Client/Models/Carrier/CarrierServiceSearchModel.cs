using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Carrier
{
    public class CarrierServiceSearchModel
    {
        /// <summary>
        /// Code of the carrier for which we will search for transport services
		/// </summary>
        public string CarrierCode { get; set; }
    }
}
