// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void ExemploGet()
{
    Console.WriteLine("Utilização de Http Client - verbo Get - WebSiteCarbon API");
    Console.WriteLine("Aguarde alguns segundos, é um pouco demorado mesmo..");

    using var client =  new HttpClient();

    var request = new HttpRequestMessage(
      HttpMethod.Get,
      "https://api.websitecarbon.com/site?url=www.whiplash.net/"  
    );

using var response = client.Send(request);

    Console.WriteLine($"Retorno: ");
    Console.WriteLine($"Status Code: {response.StatusCode}");
    Console.WriteLine($"Corpo: {response.Content.ReadAsStringAsync().Result}");
    Console.WriteLine($"Headers: {string.Join(',', response.Headers.Select(h => $"{h.Key}={string.Join(',', h.Value)}"))}");
}

ExemploGet();