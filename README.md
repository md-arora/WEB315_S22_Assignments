# WEB315_S22_Assignments
Assignments of WEB 315 - Introduction to ASP.NET

## Super Bikes
This theme is all about Motorcycles(Bikes) like: Sport bikes, naked bikes, adventure bikes, cruizer bikes, super sport bikes

## Commands used to install the EF Tools and NuGet packages

    ```powershell
        dotnet tool install --global dotnet-ef
        dotnet tool install --global dotnet-aspnet-codegenerator
        dotnet add package Microsoft.EntityFrameworkCore.Design
        dotnet add package Microsoft.EntityFrameworkCore.SQLite
        dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
        dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    ```

## scaffolding terminal commands
    The terminal command to build CRUD pages for the model. 

    ```powershell
        dotnet-aspnet-codegenerator razorpage -m Bike -dc RazorPagesBikeContext -udl -outDir Pages/Bikes --referenceScriptLibraries -sqlite
    ```

## EFs migration commands
    The terminal command to create initial database schemea using Entity Framework Migration feature

    ```powershell
        dotnet ef migrations add InitialCreate
        dotnet ef database updat
    ```

## Migration commands to add new fields of data

    ```powershell
        dotnet ef migration add Torque
        dotnet ef migration add TopSpeed
        dotnet ef database update
    ```

## commands to add new validation in maigration

    ```powershell
        dotnet ef migrations add New_DataAnnotations
        dotnet ef database update
    ```