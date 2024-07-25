using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<BlazorSignalRApp>("server");

builder.Build().Run();
