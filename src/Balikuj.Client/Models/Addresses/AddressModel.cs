namespace Balikuj.Client.Models.Addresses
{
    public class AddressModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Company { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Zip { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public string CountryName { get; set; }

        public bool IsEnabled { get; set; }

        public int Type { get; set; }

        public string AdditionalInfo { get; set; }

        public string TaxNumber { get; set; }

        public string VatNumber { get; set; }

        public string TaxId { get; set; }

        public string ExternalCode { get; set; }
    }
}
