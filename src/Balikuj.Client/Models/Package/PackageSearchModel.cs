using Balikuj.Client.Models.Base;
using System.ComponentModel;

namespace Balikuj.Client.Models.Package
{
    public class PackageSearchModel : BaseSearchModel
    {
        /// <summary>
        /// Additional parameters for further searching
        /// </summary>
        public string Search { get; set; }

        /// <summary>
        /// ID of the order to find packages for
        /// </summary>
        public int? OrderId { get; set; } = null;

        /// <summary>
        /// Search by carrier codes separated by comma
        /// </summary>
        /// <example>DPD,CP</example>
        public string CarrierCode { get; set; } = null;

        /// <summary>
        /// Search for packages with or without cash on delivery
        /// </summary>
        /// <example>true</example>
        public bool? Cod { get; set; } = null;

        /// <summary>
        /// Search for packages with created pickup/batch
        /// </summary>
        /// <example>true</example>
        public bool? Pickup { get; set; } = null;

        /// <summary>
        /// Date of package creation from in format YYYY-MM-DD
        /// </summary>
        public string CreatedFrom { get; set; }

        /// <summary>
        /// Date of package creation to in format YYYY-MM-DD
        /// </summary>
        public string CreatedTo { get; set; }

        /// <summary>
        /// User-defined package number
        /// </summary>
        public string PackageNumberCustom { get; set; }

        /// <summary>
        /// Carrier package number
        /// </summary>
        public string PackageNumberCarrier { get; set; }

        /// <summary>
        /// Package reference
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Search by recipient information
        /// </summary>
        public string Recepient { get; set; }

        /// <summary>
        /// Package status
        /// </summary>
        public PackageStatusEnum? Status { get; set; }

        /// <summary>
        /// Column name for sorting
        /// </summary>
        public string SortField { get; set; }

        /// <summary>
        /// Display order
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// Set whether to return only main packages or sub-packages in the result
        /// </summary>
        /// <example>true</example>
        [DefaultValue(true)]
        public bool? OnlyMaster { get; set; } = true;
    }
}
