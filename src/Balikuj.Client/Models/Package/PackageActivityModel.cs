using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Package
{
    public class PackageActivityModel
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Category { get; set; }

        public bool IsMaster { get; set; }

        public int? MasterId { get; set; }

        public string Name { get; set; }

        public string NameSystem { get; set; }

        public PackageTrackingStatusType Type { get; set; }

        public string Item { get; set; }

        public bool Delivered { get; set; } = false;

        public bool Canceled { get; set; } = false;

        public string CarrierCode { get; set; }

        public int PackageId { get; set; }

        public string PackageNumberCustom { get; set; }

        public string PackageNumberCarrier { get; set; }

        public string RecCompany { get; set; }

        public string RecName { get; set; }

        public string RecStreet { get; set; }

        public string RecCity { get; set; }

        public string RecZip { get; set; }
    }
}
