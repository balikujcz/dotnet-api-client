using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Carrier.Cp
{
    public class CpActivateModel
    {
        [JsonExtensionData]
        public Dictionary<string, object> AdditionalProperties { get; set; } = new Dictionary<string, object>();

        public bool ApiDebug { get; set; }

        /// <summary>
        /// API token generated in the administration of the ČP carrier
        /// </summary>
        /// <example>b79b16c2-2f77-450f-91a5-868c3c698a82</example>
        public string ApiToken { get; set; }

        /// <summary>
        /// Secret key generated in the administration of the ČP carrier
        /// </summary>
        /// <example>dOJWwjp+BWqUcof3K+3OW6XGTnEpmWerx64TCNk0+0pZnonHdN99NFRIGaJSX0/HTtiu6AGYpKp0mjguzqp+wg==</example>
        public string SecretKey { get; set; }

        /// <summary>
        /// Technological number of the sender - according to the contract with the ČP carrier
        /// </summary>
        /// <example>C0929</example>
        public string TechNumber { get; set; }

        /// <summary>
        /// Postal code of the sending post office
        /// </summary>
        /// <example>28002</example>
        public string PostCode { get; set; }

        /// <summary>
        /// Number of the sending location
        /// </summary>
        /// <example>1</example>
        public int LocationNumber { get; set; } = 1;

        /// <summary>
        /// ID of the CČK folder - according to the contract with the ČP carrier
        /// </summary>
        /// <example>256712001</example>
        public string IdCck { get; set; }


        public string SenderCompany { get; set; }
        public string SenderName { get; set; }
        public string SenderStreet { get; set; }
        public string SenderCity { get; set; }
        public string SenderZip { get; set; }
        public string SenderCountry { get; set; }
        public string SenderPhone { get; set; }
        public string SenderEmail { get; set; }

        /// <summary>
        /// Default number of shipments to be created
        /// </summary>
        /// <example>1</example>
        public int DefaultPieceCount { get; set; }

        /// <summary>
        /// Default weight of the shipment in kg
        /// </summary>
        /// <example>2</example>
        public int DefaultWeight { get; set; }

        /// <summary>
        /// Default service type (code)
        /// </summary>
        /// <example>DR</example>
        public string DefaultService { get; set; }

        /// <summary>
        /// Default label format (0 = A6, 1 = A4)
        /// </summary>
        /// <example>0</example>
        public int DefaultLabelFormat { get; set; }

        /// <summary>
        /// Default size of the shipment (S/M/L/XL)
        /// </summary>
        /// <example>M</example>
        public string DefaultSize { get; set; }

        /// <summary>
        /// Default width of the shipment in cm
        /// </summary>
        public decimal DefaultWidth { get; set; }

        /// <summary>
        /// Default height of the shipment in cm
        /// </summary>
        public decimal DefaultHeight { get; set; }

        /// <summary>
        /// Default length of the shipment in cm
        /// </summary>
        public decimal DefaultLength { get; set; }

        public int DefaultNoteType { get; set; } = 0;

        public string DefaultNoteValue { get; set; } = null;
    }
}
