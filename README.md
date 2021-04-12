# Students Data

This this is set up as a visual studio solution containing 4 projcts 

- StudentDataModels
- StudentDataModelTests
- StudentDataLoader
- StudentDataView

Each are as follows:

## StudentDataModels 

This is a .NET Core class library that defines the base domain models 
to be used in the rest of the application, as well as defining 
custom importers and exporters that will convert the base domain model 
between custom JSON models; both the importers and exporters inherit 
from the IImporter and IExporter interfaces, exporters will have a 
static method that will accept the base class and return a JSON string,
importers will accept a valid JSON string and return a base class. 

This has an external dependency; `Microsoft.EntityFrameworkCore.Design`
this is used purely for using EF Core database automatic migrations, 
if being used with an existing database with a correct schema, then 
this dependency isn't needed, it can be installed via;

(Top menu) Tools -> NuGet Packet Manager -> Manage NuGet Packages for Solution 

In `Browse` search for the dependancy and select it, and install it for
StudentDataModels project.

This project is top of the dependancy tree for the solution and so has 
no other references to other projects.

## StudentDataModelTests

This is used as the tests for the StudentDataModels importers and exporters,
this contains tests for the students model importer/exporter and contacts model
importer, these can be ran via accessing the Test Explorer or through the 
test exporer through; Test -> Test Explorer, and clicking run all or
invoking them individually; the test are set up to call the importers on
json strings (stored in ./TestData), and checking the result against example
objects (provided by methods of ExampleModelGenerator in ExampleModelGenerator.cs)
or by converting the exporters on the example objects and checking againts 
the JSON in ./TestData, when testing ensure that the full path to the test 
project (with a / at the end) is in the return string of `GetPath()` method 
on the class `DataPath`, e.g.:

`public static string GetPath() => "C:\Dev";`

This project must refernce the StudentDataModels project and have the latest 
following NuGet packages installed:

- coverlet.collector 
- Microsoft.NET.Test.Sdk
- MSTest.TestAdapter
- MSTest.TestFramework

## StudentDataLoader 

This project is a .NET Core command line application ETL wrapper for the 
MainStudentsImporter and MainStudentsExporter in the StudentDataModels 
project, this has no external NuGet dependencies that need to be installed,
it just needs a refernce to StudentDataModels. This project will accept 2 
command line arguments (expected them to be paths), check them, and read
a JSON file to the MainStudentImporter importer and then pass the object 
to the MainStudentExporter, and then write the subsequent JSON string
to the file specified by the command line, performing all relevant checks 
that the files exist and polling the user if they wish to overwrite the
output file should it already exist.

When debugging make sure that under;
Project Properties (right-click -> properties) -> Debug -> Application arguments  
there are 2 paths, the first to a JSON file to be used and the second to be
written to. This the order it will be submitted when running directly from the
console.

## StudentDataView

This is a ASP.NET Core API with React project; this uses a react front end 
with API routes to display user data using the domain specifed by 
StudentDataModels in a SQL Server database, it further uses EntityFramework 
Core to manage database access. 

### Client App

The react page is stored under "ClientApp" and uses Material-UI, this can 
be added by going to the terminal and to the ClientApp directory and 
using the npm command: 
`npm install @material-ui/core`
And also ensuring that the following is in the head tags of ClientApp/Public/Index.html
`<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap" />`

For debugging purposes, under ClientApp/src/Helper.js there is a `const` named 
`baseURL`, here you can specify an alternate URL address for the api access,
useful if the front end work is being done separately from the backend. 

##### App Usage

The app should load up a page titled "Students Data View", with an option
to filter students by name or year group, below that a series of vertically
stacked white pannels containing 4 fields each (Name, Gender, Year group, and ULN).

Each pannel will have 2 buttons, "Show More" that will expand the student record
to display the other fields, as well as a red button to add a point to a student,
the total number of points a student has will be displayed next to that.

When the student is fully expanded, at the bottom will be a section named "Contacts"
that will have a drop down select box and 3 fields, the name of the linked contact
for that student can be selected and the details (Relationship, Next of Kin Y/N
and Description) for that contact will show in those fields, pressing the show button
again will hide the expanded record. 

To filter a student just start typing in the "Filter" text box at the top and 
it will dynamically filter based on name or year, (depending on what's selected 
in the select box to the left of it). 

### Back end

The backend servs to provide API routes and static file hosting for the client app.
It is set up to use EntityFramework Core for SQL Server, the server connection is 
under appsettings.json -> ConnectionStrings -> StudentDataContext, this is where 
you should specify your database connection string prior to startup. Prior to start
up, make sure the database schema is up to date, this can be done easily by (after
installing the dependencies - see below), by entering the package management console
via Tools -> NuGet Package Manager -> Package Manager Console, and typig the following;
`Add-Migration [relevant name here - i.e. InitialCreate]`
and;
`Update-Database`
that will ensure that the schema is updated. 

When the app starts (including debug mode), it will check the database for any students,
if none it will read all the files under the directory; `{project dir}/TestData/Students`
and pass that over to the MainStudentImporter and MainContactsImporter defined in 
StudentDataModels, it will then cast the resultant objects to ContactDataModel and 
StudentDataModel which are extensions of the base models defined in StudentDataModels 
that add addtional information useful to EF Core and the end user, these will then be 
added to the database, thus seeding it. 

The StudentDataView project will require a refernce to StudentDataModels, 
and requires the following NuGet packages:
- Microsoft.AspNetCore.SpaServices.Extensions
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.VisualStudio.Web.CodeGeneration.Design

