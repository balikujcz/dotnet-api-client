using Balikuj.Client.Models.Carrier.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Carrier.Geis
{
    public class AddPackageGeisModel : AddPackageBaseModel, IAddPackageModel
    {
        /// <summary>
        /// Customer reference of the shipment
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Custom note when inserting a package into the database
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Note for the recipient
        /// </summary>
        public string NoteRec { get; set; }

        /// <summary>
        /// Note for the driver
        /// </summary>
        public string NoteDriver { get; set; }

        /// <summary>
        /// Custom naming of the shipment (order number, etc.)
        /// Only numbers (0-9), letters (a-z, A-Z), hyphen (-), slash (/), underscore (_) are allowed
        /// Maximum length of 30 characters
        /// </summary>
        public string PackageNumberCustom { get; set; }

        /// <summary>
        /// Package number (for multi-package shipments)
        /// </summary>
        public int? PackageNumberOrder { get; set; }

        /// <summary>
        /// Declared value of the shipment
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Cash on delivery value
        /// </summary>
        public decimal? CodPrice { get; set; }

        /// <summary>
        /// Cash on delivery currency
        /// </summary>
        public string CodCurrency { get; set; }

        /// <summary>
        /// Insurance, send only for shipments over 500,000 CZK. Also specify the total price using the Price value.
        /// The currency will be the value from CodCurrency. If not specified, CZK will be used.
        /// </summary>
        public decimal? InsurancePrice { get; set; }

        /// <summary>
        /// Variable symbol of the cash on delivery
        /// </summary>
        public string Vs { get; set; }

        /// <summary>
        /// Volume in m3
        /// </summary>
        public decimal? Volume { get; set; }

        /// <summary>
        /// Width in meters
        /// </summary>
        public decimal? Width { get; set; }

        /// <summary>
        /// Height in meters
        /// </summary>
        public decimal? Height { get; set; }

        /// <summary>
        /// Length in meters
        /// </summary>
        public decimal? Length { get; set; }

        /// <summary>
        /// Weight in kg
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// Manipulation unit code
        /// </summary>
        public string ManipulationUnit { get; set; }

        /// <summary>
        /// Number of pallet spaces
        /// </summary>
        public int PieceCount { get; set; }

        /// <summary>
        /// Bank account number (IBAN) for sending cash on delivery. Do not enter if it is the same as the carrier's settings.
        /// </summary>
        public string Iban { get; set; }

        /// <summary>
        /// SMS notification - send SMS to the recipient
        /// </summary>
        public bool? SmsNotification { get; set; }

        /// <summary>
        /// Phone notification - call the recipient
        /// </summary>
        public bool? PhoneNotification { get; set; }

        /// <summary>
        /// Shipment pickup date in the format YYYY-MM-DD. You can create an expedition (HomeExpedition) for the current day, an order (HomeOrder) can be created no earlier than the next day.
        /// </summary>
        public string PickupDate { get; set; }
    }
}
