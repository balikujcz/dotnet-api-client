using Balikuj.Client.Models.Addresses;

namespace Balikuj.Client.Example.Services;

public class AddressServiceExample
{
    private readonly BalikujClient _client;

    public AddressServiceExample(BalikujClient client)
    {
        _client = client;

        _client.SetApiKey(ApiRuntimeSettings.ApiKey);
    }

    public async Task RunAsync()
    {
        /////////////////////
        // Create new address
        /////////////////////
        /*
        var addressCreateRquest = new AddressCreateRequest
        {
            Name = "Josef Novák",
            Company = "Novák s.r.o.",
            Street = "Vavrečkova 7074",
            City = "Zlín",
            Zip = "76001",
            Phone = "+420777123456",
            Country = "CZ",
            Type = (int)AddressType.Recepient,
        };
        Console.WriteLine("Creating new address ...");
        var addressListResult = await _client.AddressCreate(addressCreateRquest);
        Console.WriteLine($"Adress StatusCode = {addressListResult.StatusCode}, id = {addressListResult?.Result?.Id}");
        */


        ////////////////////////
        // Get list of addresses
        ////////////////////////
        /*
        Console.WriteLine("Getting list of addresses ...");
        var addressListResult = await _client.AddressList(new AddressListRequest());
        Console.WriteLine($"AddressList StatusCode = {addressListResult.StatusCode}, items = {addressListResult?.Result?.Data?.Count}");
        */
    }
}
