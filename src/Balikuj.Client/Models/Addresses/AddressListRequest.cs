namespace Balikuj.Client.Models.Addresses
{
    public class AddressListRequest
    {
        /// <summary>
        /// Searched string
        /// </summary>
        public string Search { get; set; }

        /// <summary>
        /// Address type
        /// </summary>
        public AddressType? AddressType { get; set; }

        /// <summary>
        /// Show disabled/delete addresses
        /// </summary>
        public bool? ShowDisabled { get; set; } = false;

        /// <summary>
        /// Name of the field to sort
        /// </summary>
        public string SortField { get; set; }

        /// <summary>
        /// Sort order
        /// </summary>
        public string SortOrder { get; set; }
    }
}
