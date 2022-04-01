# Animal Shelter API

#### By [Will W.](https://wjwat.com/)

#### 

## :computer: Technologies Used

* C#
* .NET 5.0
* ASP.NET Core
* Razor
* Entity Framework Core
* MySQL
* dotnet script REPL
* HTML
* CSS | [YACCK](https://github.com/sphars/yacck)
* JQuery

## :memo: Description


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
- Run `dotnet build Factory` in the top level directory of this repo.
- Once the project has been built run `dotnet ef database update --project Factory` to create the database necessary to run the app.
- Run `dotnet run --project Factory` to get the program running, and the site hosted locally.
- Visit `http://localhost:5000` to try the site out.

## :page_facing_up: Notes

- 

## :lady_beetle: Known Bugs

* If any are found please feel free to open an issue or email me at wjwat at
  onionslice dot org

## :warning: License

[MIT License](https://opensource.org/licenses/MIT)

Copyright (c) 2022 Will W. (ｙﾟ 益ﾟ;)ｙ
