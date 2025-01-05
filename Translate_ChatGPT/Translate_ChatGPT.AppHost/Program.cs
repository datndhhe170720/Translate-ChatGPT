var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Translate_ChatGPT_ApiService>("apiservice");

builder.AddProject<Projects.Translate_ChatGPT_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
