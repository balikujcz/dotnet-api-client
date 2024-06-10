namespace Balikuj.Client.Errors
{
    public class ApiCarrierError
    {
        public ApiCarrierError() { }

        public ApiCarrierError(string errorCode, string message, string reference)
        {
            this.ErrorCode = errorCode;
            this.Message = message;
            this.Reference = reference;
        }

        /// <summary>
        /// Kód chyby
        /// </summary>
        /// <example>InvalidUserInputError</example>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Text chybového hlášení
        /// </summary>
        /// <example>String must contain at least 3 character(s)</example>
        public string Message { get; set; }

        /// <summary>
        /// ID referencované entity
        /// </summary>
        /// <example>0 -> receiver -> address -> postalCode</example>
        public string Reference { get; set; }
    }
}
