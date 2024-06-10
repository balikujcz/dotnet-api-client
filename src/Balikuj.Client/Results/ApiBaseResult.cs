namespace Balikuj.Client.Results
{
    public class ApiBaseResult
    {
        /// <summary>
        /// Unikátní identifikátor požadavku ve formátu GUID. Slouží ke snadnějšímu trasování případných problémových požadavků. Pokud se naskytne chyba v požadavku, pošlete nám tento identifikátor pro snadnější identifikaci problému v rámci platformy Balíkuj. 
        /// </summary>
        /// <example>d22127f9-6f76-4e1f-a15b-47ba32e899d0</example>
        public string CorrelationId { get; set; }

        /// <summary>
        /// Status code of the request
        /// </summary>
        public int StatusCode { get; set; }
    }
}
