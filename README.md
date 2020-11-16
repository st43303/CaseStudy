# Case Study
This web application was created as a homework within the tender for the company Alza.cz.\
The application contains a total of 5 projects:
* CaseStudy.API
  * ASP.NET Core Web Application
  * Startup project
  * REST API service
* CaseStudy.Domain
  * Class Library (.NET Core)
  * Contains a model classes for CaseStudy.API
* CaseStudy.Data
  * Class Library (.NET Core)
  * Provides an access to the database using the Entity Framework
  * A migrations are performed here
* CaseStudy.Common
  * Class Library (.NET Core)
  * Interlayer between CaseStudy.API and CaseStudy.Data
  * CaseStudy.Data needs some access to connection string which is located in CaseStudy.API
* CaseStudy.Test
  * xUnit Test Project (.NET Core)
## Setup
The technical requirement for using this application is the installed Visual Studio 2019 with .NET Core 3.1.\
The following text describes the settings of the application before the first start:
1.  Find the connection string 
    * The connection string is located in CaseStudy.API project in the appsettings.json file
    * The connection string is called „CaseStudyConnection“
2.  Rewrite the connection string to a location of your server. The database may not exist. The important things are server name and login information
3.  Remove migrations folder
    * The migrations folder is located in CaseStudy.Data project
4.  Find the Package Manager Console which is a part of Visual Studio
    * If you can´t find it go to View -> Other Windows and click on Package Manager Console
5.  Create a new database
    * Be sure that as a default project in this console is set CaseStudy.Data
    * Type the following codes to Package Manager Console\
    *Add-Migration init*\
    *Update-Database*

And that´s it. A database containing 50 test products should now be created on your server.\
You can now run an application. The default address link should be http://localhost/swagger. The swagger contains two versions of API.

## Testing
The project for testing is called CaseStudy.Test. There are a methods which calls REST API and works with data from a database. **It´s important to first create a database and  then try to testing!**

