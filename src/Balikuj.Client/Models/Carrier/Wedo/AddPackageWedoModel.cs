using Balikuj.Client.Models.Carrier.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Balikuj.Client.Models.Carrier.Wedo
{
    public class AddPackageWedoModel : AddPackageBaseModel, IAddPackageModel
    {
        /// <summary>
        /// Reference number/ID of the shipment
        /// </summary>
        public string Reference { get; set; } // WEDO: reference_number

        /// <summary>
        /// Second reference number/ID of the shipment
        /// </summary>
        public string Reference2 { get; set; } // WEDO: reference_number2

        /// <summary>
        /// Number of packages in the shipment
        /// </summary>
        public int PieceCount { get; set; } // WEDO: package_count

        /// <summary>
        /// Total weight of the shipment in kg
        /// </summary>
        public decimal Weight { get; set; } // WEDO: weight

        /// <summary>
        /// Custom note when adding a package to the database
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Declared value of the shipment
        /// </summary>
        public decimal Price { get; set; } // WEDO: value

        /// <summary>
        /// Branch ID. The list of branches can be obtained through the method {{carrier}}/Branches
        /// </summary>
        public string BranchId { get; set; }

        /// <summary>
        /// Cash on delivery value. Set the total value for the entire shipment and only for the first item
        /// </summary>
        public decimal? CodPrice { get; set; } // WEDO: cash_on_delivery

        ///// <summary>
        ///// Cash on delivery currency
        ///// </summary>
        //public string CodCurrency { get; set; }

        /// <summary>
        /// Request for "return shipment" service. The sender will arrange for the pickup of the shipment anywhere in the selected EU countries and arrange for its return to the collection point.
        /// </summary>
        public bool? ReverseOrder { get; set; } // WEDO: reverse_order

        /// <summary>
        /// Request for "direct shipment" service. The sender will arrange for the pickup of the shipment at an address outside the regular collection point (e.g. directly from the supplier) and its delivery to the recipient. This additional service is provided only in the Czech Republic and Slovakia.
        /// </summary>
        public bool? DirectOrder { get; set; } // WEDO: direct_order

        /// <summary>
        /// Request for "exchange shipment" service. At the same time as delivering the shipment to the recipient, the sender will arrange for the pickup of another shipment from the recipient and deliver it to the consignor. The shipment addressed to the consignor will not be handed over to the recipient without picking up the shipment addressed to the consignor 
        /// (suitable for complaints or borrowed goods). This additional service is provided only in the Czech Republic. The shipment can consist of only one cargo item.
        /// </summary>
        public bool? ExchangeOrder { get; set; } // WEDO: exchange_order

        /// <summary>
        /// Note for the "exchange shipment" service
        /// </summary>
        public string ExchangeOrderNote { get; set; } // WEDO: exchange_order_note

        /// <summary>
        /// Request for "documents back" service. The sender will arrange for the return of documents that were part of the shipment after they have been confirmed by the recipient (all documents that must be signed by the recipient are subsequently sent 
        /// to the consignor's address). This additional service is suitable, for example, for contracts.
        /// </summary>
        public bool? DocumentBack { get; set; } // WEDO: document_back

        /// <summary>
        /// Note for the "documents back" service
        /// </summary>
        public string DocumentBackNote { get; set; } // WEDO: dokument_back_note

        /// <summary>
        /// Request for "phone notification of delivery confirmation". If not filled in, the sender's phone number will be used. The recipient will be contacted by the courier by phone to confirm the place and date of delivery.
        /// The consignor can specify a phone number for contact and a note with additional information for the courier.
        /// </summary>
        public bool? PhoneNotification { get; set; } // WEDO: phone_notification

        /// <summary>
        /// Phone number for "phone notification of delivery confirmation" to the recipient in international format (e.g. 00420123456789)
        /// </summary>
        public string PhoneNotificationNumber { get; set; } // WEDO: phone_notification_number

        /// <summary>
        /// Note for phone notification of delivery confirmation
        /// </summary>
        public string PhoneNotificationNote { get; set; } // WEDO: phone_notification_note

        /// <summary>
        /// Request for "SMS notification of delivery confirmation". If not filled in, the sender's phone number will be used.
        /// </summary>
        public bool? SmsNotification { get; set; } // WEDO: sms_notification

        /// <summary>
        /// Phone number for "SMS notification of delivery confirmation" to the recipient in international format (e.g. 00420123456789). The recipient will be contacted by the courier via SMS to confirm the place and date of delivery.
        /// The consignor can specify a phone number for contact and a note with additional information for the courier.
        /// </summary>
        public string SmsNotificationNumber { get; set; } // WEDO: sms_notification_number

        /// <summary>
        /// Request for "email notification of delivery confirmation". The recipient will be contacted by the courier by email to confirm the place and date of delivery.
        /// The consignor can specify an email for contact and a note with additional information for the courier.
        /// </summary>
        public bool? EmailNotification { get; set; } // WEDO: email_notification

        /// <summary>
        /// Address for "email notification of delivery confirmation" to the recipient. If not filled in, the sender's email address will be used.
        /// </summary>
        public string EmailNotificationAddress { get; set; } // WEDO: email_notification_address

        /// <summary>
        /// Verification of the recipient's identity age. The shipment will be delivered to the recipient only after presenting the original proof of identity - ID card, driver's license, passport, or other identification document agreed upon in the Contract. 
        /// The customer may also request verification of age or correctness of other data according to the instructions of the consignor, such as name or address. The Identity Verification service can be combined with the "Documents Back" service.
        /// </summary>
        public bool? Authentication { get; set; } // WEDO: authentication

        /// <summary>
        /// Note for recipient's identity verification
        /// </summary>
        public string AuthenticationNote { get; set; } // WEDO: authentication_note

        /// <summary>
        /// Insurance, send only for shipments over 500,000 CZK. The total price must also be specified using the Price value.
        /// The currency will be the value from CodCurrency. If not specified, CZK will be used.
        /// </summary>
        public bool? Insurance { get; set; } // WEDO: insurance

        /// <summary>
        /// Request for "carry" service. The sender will arrange for the delivery of the shipment to the recipient at a specific department, office, or apartment door.
        /// </summary>
        public bool? Carry { get; set; } // WEDO: carry

        /// <summary>
        /// Request for "loss" service
        /// </summary>
        public bool? Loss { get; set; } // WEDO: loss

        /// <summary>
        /// Request for "pay by receiver" service
        /// </summary>
        public bool? PayByReceiver { get; set; } // WEDO: pay_by_receiver


        /// <summary>
        /// Custom name of the shipment (order number, etc.)
        /// Only numbers (0-9), letters (a-z, A-Z), hyphen (-), slash (/), underscore (_) are allowed
        /// Maximum length of 30 characters
        /// </summary>
        public string PackageNumberCustom { get; set; }

        /// <summary>
        /// Sequential number of the package (for multi-package shipments)
        /// </summary>
        public int? PackageNumberOrder { get; set; }
    }
}
