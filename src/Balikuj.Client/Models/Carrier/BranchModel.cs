using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Balikuj.Client.Models.Carrier
{
    public class BranchModel
    {

        /// <summary>
        /// Country of the branch
        /// </summary>
        /// <example>CZ</example>
        public string Country { get; set; }

        /// <summary>
        /// Branch code
        /// </summary>
        /// <example>CZ10037</example>
        public string Code { get; set; }

        /// <summary>
        /// System ID or external ID of the branch
        /// </summary>
        /// <example>CZ10037</example>
        public string SystemId { get; set; }

        /// <summary>
        /// Branch name
        /// </summary>
        /// <example>Test Elektro</example>
        public string Name { get; set; }

        /// <summary>
        /// Second branch name
        /// </summary>
        /// <example>null</example>
        public string Name2 { get; set; }

        /// <summary>
        /// Branch street
        /// </summary>
        /// <example>Pražská 17</example>
        public string Street { get; set; }

        /// <summary>
        /// Branch city
        /// </summary>
        /// <example>Brandýs Nad Labem</example>
        public string City { get; set; }

        /// <summary>
        /// Branch ZIP code
        /// </summary>
        /// <example>25001</example>
        public string Zip { get; set; }

        private int BranchTypeId { get; set; }

        /// <summary>
        /// Branch type
        /// </summary>
        /// <example>Box</example>
        public CarrierBranchType BranchType
        {
            get => (CarrierBranchType)BranchTypeId;
            set => BranchTypeId = (int)value;
        }

        /// <summary>
        /// Note about the branch
        /// </summary>
        /// <example>null</example>
        public string Note { get; set; }

        /// <summary>
        /// Contact email of the branch
        /// </summary>
        /// <example>example@email.cz</example>
        public string Email { get; set; }

        /// <summary>
        /// Contact phone of the branch
        /// </summary>
        /// <example>225373373</example>
        public string Phone { get; set; }

        /// <summary>
        /// Contact fax of the branch
        /// </summary>
        /// <example>null</example>
        public string Fax { get; set; }

        /// <summary>
        /// GPS longitude
        /// </summary>
        /// <example>14.6596</example>
        public decimal? GpsLongitude { get; set; }

        /// <summary>
        /// GPS latitude
        /// </summary>
        /// <example>50.1850</example>
        public decimal? GpsLatitude { get; set; }

        /// <summary>
        /// Opening hours on Monday
        /// </summary>
        /// <example>08:30 - 12:00 12:00 - 17:00</example>
        public string OpeningMonday { get; set; }

        /// <summary>
        /// Opening hours on Tuesday
        /// </summary>
        /// <example>08:30 - 12:00 12:00 - 17:00</example>
        public string OpeningTuesday { get; set; }

        /// <summary>
        /// Opening hours on Wednesday
        /// </summary>
        /// <example>08:30 - 12:00 12:00 - 17:00</example>
        public string OpeningWednesday { get; set; }

        /// <summary>
        /// Opening hours on Thursday
        /// </summary>
        /// <example>08:30 - 12:00 12:00 - 17:00</example>
        public string OpeningThursday { get; set; }

        /// <summary>
        /// Opening hours on Friday
        /// </summary>
        /// <example>08:30 - 12:00 12:00 - 17:00</example>
        public string OpeningFriday { get; set; }

        /// <summary>
        /// Opening hours on Saturday
        /// </summary>
        /// <example>08:30 - 11:00</example>
        public string OpeningSaturday { get; set; }

        /// <summary>
        /// Opening hours on Sunday
        /// </summary>
        /// <example>null</example>
        public string OpeningSunday { get; set; }

        /// <summary>
        /// Branch small photo
        /// </summary>
        /// <example>https://www.domena.cz/obrazek.jpg</example>
        public string PhotoSmall { get; set; }

        /// <summary>
        /// Branch large photo
        /// </summary>
        /// <example>https://www.domena.cz/obrazek.jpg</example>
        public string PhotoLarge { get; set; }

        /// <summary>
        /// Information if cash payment is possible at the branch
        /// </summary>
        /// <example>true</example>
        public bool? PaymentCash { get; set; }

        /// <summary>
        /// Information if card payment is possible at the branch
        /// </summary>
        /// <example>false</example>
        public bool? PaymentCard { get; set; }

        /// <summary>
        /// Date of branch creation
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Date of last branch update
        /// </summary>
        public DateTime Updated { get; set; }
    }
}
