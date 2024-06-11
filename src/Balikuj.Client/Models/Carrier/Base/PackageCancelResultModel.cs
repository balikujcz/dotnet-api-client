using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Carrier.Base
{
    public class PackageCancelResultModel
    {
        public string PackageNumberCarrier { get; set; }

        public bool Successfull { get; set; }

        public string Message { get; set; }
    }
}
