# Accessing SQL using blazor server

*WARNING: You will need to create your SQL Server/DB/Stored Procedure for this to work, this project is just a usage example*

### NuGet Packages installed:
* Dapper (https://github.com/DapperLib/Dapper)
* System.Data.SqlClient 

*How to install these NuGet Packages: https://github.com/CodeGlitch/NuGet_Packages_VS2019*

### Files changed/created:
* Model -> MyDataStructure.cs (Created new item of type Class as an example)
* appsettings.json (added connection string as an example)
* Data -> SQLAccess.cs (Created new item of type Class)
* Data -> ISQLAccess.cs (Extracted Interface of SQLAccess.cs see: https://github.com/CodeGlitch/ExtractingInterfaceCS)
* Startup.cs (add extracted interface so that it can be injected for usage on index.razor)
* Pages -> Index.razor
