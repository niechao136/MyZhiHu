var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.MyZhiHu_ApiService>("apiservice");

builder.AddProject<Projects.MyZhiHu_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();