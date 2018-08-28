ExternalService.MyServiceClient client = new ExternalService.MyServiceClient();
string result = client.DoWork(“John”, “Doe”);
Console.WriteLine(result); // Displays JohnDoe