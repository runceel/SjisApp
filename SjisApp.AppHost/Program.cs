var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorApp1>("blazorapp1")
    .WithExternalHttpEndpoints();

builder.Build().Run();
