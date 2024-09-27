var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Evently_API>("evently-api");

builder.Build().Run();
