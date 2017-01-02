# DotVVM + ASP.NET Web Forms in one application

This repo is a demo of how to combine DotVVM with existing ASP.NET Web Forms application.



## Steps Required to Add DotVVM in Existing Web Forms App

1. Install the `DotVVM.Owin` NuGet package.

2. Install the `Microsoft.Owin.Host.SystemWeb` package if you already don't have it in your project.

3. Add the [OWIN Startup class](src/WebFormsDotVVMCombo/Startup.cs) and call `app.UseDotVVM...`.

4. Unload the project, edit the `.csproj` file and add the DotVVM Project guid (`94EE71E2-EE2A-480B-8704-AF46D2E58D94`) 
as a first one in the `<ProjectTypeGuids>` element.
It should look like this:

    ```
    <ProjectTypeGuids>{94EE71E2-EE2A-480B-8704-AF46D2E58D94};{349c5851-65df-11da-9384-00065b846f21};{fae04ec0-301f-11d3-bf4b-00c04f79efbc}</ProjectTypeGuids>
    ```

5. Make sure you have told the IIS to run all managed modules for all HTTP requests in the `web.config`:

    ```
      <system.webServer>
        <modules runAllManagedModulesForAllRequests="true" />
        <validation validateIntegratedModeConfiguration="false" />
      </system.webServer>
    ```

6. Create your [DotvvmStartup](src/WebFormsDotVVMCombo/DotvvmStartup.cs) file and register your DotVVM routes.
Any request that doesn't match any DotVVM route, will be passed to the ASP.NET Web Forms handlers.
