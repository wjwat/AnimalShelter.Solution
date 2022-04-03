# Animal Shelter API

#### By [Will W.](https://wjwat.com/)

#### Build an API using C#/.NET

## :computer: Technologies Used

* C#
* .NET 5.0
* Linq
* Swagger
* ASP.NET Core
* Razor
* Entity Framework Core
* MySQL
* dotnet script REPL

## :memo: Description

The objective of this project was to create an API with full CRUD capabilities using C#/.NET WebApi. Along with the API we were tasked with further exploration in any number of topics in order to give us a chance to push ourselves. You will find the API & my further explorations listed below.

## Pagination

Currently we return paginated values our API. By default we set a max page size of 10.

<dl>
  <dt>pageSize={int}</dt>
  <dd>Sets page size for returned values, only applicable to
  `/api/Animals` as it returns a list.</dd>
  <dd>Defaults to 10, with a maximum value of 10.</dd>
</dl>
<dl>
  <dt>pageNumber={int}</dt>
  <dd>Returns the values located in that page.</dd>
  <dd>EX: 100 total animals, a pageNumber of 2 will return
  the animals located in rows 11 to 20.</dd>
  <dd>Defaults to 1.</dd>
</dl>

## Versioning

This API implements versioning in order to provide backwards compatibility as changes are made to extend functionality.

## Endpoints

Our API implements two versions. All functionality from V1.0 is present in V2.0 unless noted otherwise. The URLs for each version of the API are versioned as well, but if you choose to not use a version string in them it will default to using v2.0.

```
/api/v1.0/Animals   # Version 1.0
/api/v2.0/Animals   # Version 2.0
/api/Animals        # Version 2.0
```

## V1.0

### /api/v1.0/Animals

<dl>
 <dt>GET /api/v1.0/Animals</dt>
 <dd>Returns an unfiltered, paginated list of animals.</dd>
 <dd>Takes no parameters besides those used for pagination (pageNumber and pageSize).</dd>
 <dd><b>Parameters</b>
  <ul>
   <li><b>pageNumber</b>: The page you would like to visit.</li>
   <li><b>pageSize</b>: The size of each page.</li>
  </ul>
 </dd>

 <dt>POST /api/v1.0/Animals</dt>
 <dd>Adds an animal to the database. The following values should be provided to create the animal:</dd>
 <dd>
  <ul>
    <li><b>Name</b>: Required, Max of 40 characters.</li>
    <li><b>Breed</b>: Required, Max of 40 characters.</li>
    <li><b>Species</b>: Required, Max of 40 characters.</li>
    <li><b>Description</b>: Required.</li>
    <li><b>Status</b>: Required, one of ["Available", "Adopted"], may also be 0 or 1.</li>
  </ul>
 </dd>
 <dd>EX:
<codeblock>
<pre>{
  "Name": "This is a name",
  "Breed": "This is a breed",
  "Species": "This is a species",
  "Description": "This is a description",
  "Status": 1
}</pre></codeblock>
  </dd>
  <dd>An <b>AnimalId</b> is not required to add an animal to the database as an ID will be generated for it.</dd>
</dl>

### /api/v1.0/Animals/{id}

<dl>
  <dt>GET /api/v1.0/Animals/{id}</dt>
  <dd>Returns a listing for an animal with an ID of {id}.</dd>
  <dd>Example return body of an Animal where {id} is 6:
<codeblock><pre>{
  "AnimalId": 6,
  "Name": "Maximum Red Purple",
  "Breed": "Jungle Green",
  "Species": "Maximum Yellow Red",
  "Description": "Mulberry Sky Blue Madder ...",
  "Status": 1
}</pre></codeblock>
  </dd>

  <dt>PUT /api/v1.0/Animals/{id}</dt>
  <dd>Modify an animal with an ID of {id}.</dd>
  <dd><b>The body of the Animal object must contain an `AnimalId` field with a value matching {id}.</b> Other than the AnimalId you only have to include the fields that you are updating.</dd>
  <dd>Example body content where {id} is equal to 6
<codeblock><pre>{
  "AnimalId": 6,
  "Name": "New Name",
  "Breed": "New Description",
  "Species": "Bar",
  "Description": "Foo",
  "Status": 0
}</pre></codeblock>
  </dd>

  <dt>DELETE /api/v1.0/Animals/{id}</dt>
  <dd>Permanently deletes an animal from the database if there is an Animal with an AnimalId equal to {id}.</dd>
</dl>

## V2.0

### /api/v2.0/Animals

<dl>
 <dt>GET /api/v2.0/Animals</dt>
 <dd>Returns a filtered, paginated list of animals.</dd>
 <dd>No parameters are required, but available parameters are listed below.</dd>
 <dd><b>Parameters</b>
  <ul>
    <li><b>pageNumber</b>: The page you would like to visit.</li>
    <li><b>pageSize</b>: The size of each page.</li>
    <li><b>name</b>: The exact name of the animal you would like to find listed.</li>
    <li><b>breed</b>: The exact breed of the animal you would like to find listed.</li>
    <li><b>species</b>: The exact species of the animal you would like to find listed.</li>
    <li><b>description</b>: A substring you would like to find contained in the description of an animal.</li>
    <li><b>status</b>: Required, one of ["Available", "Adopted"], may also be 0 or 1.</li>
  </ul>
 </dd>
</dl>

### /api/v2.0/Animals/Random

<dl>
 <dt>GET /api/v2.0/Animals</dt>
 <dd>Returns a single random animal from the database.</dd>
</dl>

## Swagger

This project uses [Swashbuckle](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-6.0&tabs=visual-studio) to generate Swagger documentation for the API. After building and running the API you can view that documentation by visiting `http://localhost:5000/swagger`.

**Please note** that there are two versions of the API available, and to view the documentation for v2.0 please select it from the drop down list in the top right corner.

## :gear: Setup/Installation & Usage Instructions

- [Install the MySQL Community Server & MySQL Workbench](https://dev.mysql.com/downloads/mysql/)
- [Install the .NET 5 SDK](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net)
- Install the [dotnet-ef](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) tool with this command: `dotnet tool install --global dotnet-ef`
- [Clone this
  repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)
  to your device
- Create `appsettings.json` in the top level of this repo
  - Copy the contents of the code below into this file. *Make sure to change the password to the password you used to setup your MySQL server*
  ```JSON
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=will_watkins;uid=root;pwd=<PASSWORD>;"
    }
  }
  ```
- [Using your
  terminal](https://www.freecodecamp.org/news/how-you-can-be-more-productive-right-now-using-bash-29a976fb1ab4/)
  navigate to the directory where you have cloned this repo.
- Run `dotnet build AnimalShelter.Api` in the top level directory of this repo.
- Once the project has been built run `dotnet ef database update --project AnimalShelter.Api` to create the database necessary to run the app.
- Run `dotnet run --project AnimalShelter.Api` to get the program running, and the site hosted locally.
- Open your browser and visit `http://localhost:5000/` and it will redirect you to the Swagger documentation.
- Access the API endpoints directly by using [Postman](https://www.geeksforgeeks.org/basics-of-api-testing-using-postman/) or by using [cURL](https://www.codepedia.org/ama/how-to-test-a-rest-api-from-command-line-with-curl/).

## :page_facing_up: Notes

- There is quite a bit of sprawl here that should be refactored. Specifically `Startup.cs` can be a bit hard to follow.

## :lady_beetle: Known Bugs

* If any are found please feel free to open an issue or email me at wjwat at
  onionslice dot org

## :warning: License

[MIT License](https://opensource.org/licenses/MIT)

Copyright (c) 2022 Will W. ╮(￣ω￣;)╭
