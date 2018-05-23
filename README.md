# PCF with ASP .NET Core Example
This repository is used as an example to demo development of .NET Core projects with deployment to Pivotal Cloud Foundry

# Links
* [Pivotal Cloud Foundary](https://pivotal.io/platform)
* [.NET Build Pack](https://docs.run.pivotal.io/buildpacks/dotnet-core/index.html)
* [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/)
* [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-2.0)

# Deploy the App
* Login into pivotal
```
cf login -a api.run.pivotal.io
```
* Navigate to the root directory and use the manifest.yml to push the app to PCF
```
cf push my-web-app
```

# Apps Manager
* https://login.run.pivotal.io/login

# Download the CLI Tool
* Go to the Apps Manager -> Tools
* This will show you how to download the CLI Tool