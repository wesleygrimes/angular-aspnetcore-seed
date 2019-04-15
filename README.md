<a href="https://ultimatecourses.com/topic/angular/ref/wes.grimes/" title="Ultimate Courses"><img src="https://ultimatecourses.com/assets/img/banners/ultimate-angular-github.svg" alt="Ultimate Courses" /></a>

# angular-aspnetcore-seed

Angular 7.2.7 / ASP.NET Core 2.2 Seed Project with full VS Code debugging

## Installation

1.  Clone the project into the folder of your choice - `git clone https://github.com/wesleygrimes/angular-aspnetcore-seed.git`
2.  Remove the `.git` folder - `rm -rf .git`
3.  Initialize a new repository in the directory - `git init`
4.  Install NPM Packages - `(cd ClientApp && npm install)`
5.  Restore NuGet Packages - `dotnet restore`
6.  Launch Visual Studio Code - `code .`
7.  Debugging Server and Client code can be done by hitting `F5`

## Structure of the Project

### Back-End

The back-end is an ASP.NET Core 2.2 WebAPI application.

- `Controllers` - Add new endpoints by creating or updating Controllers in this directory
- `Models` - Add data models in this folder
- `Interfaces` - Add any interfaces that will be implemented in this directory
- `Services` - Add any services in this directory. Typically services will be making the direct HttpClient and Database interactions
- `Startup.cs` - Startup configuration exists here, as well as registration of any data services that will be injected into Controllers at runtime

### Front-End

You will find the front-end code in the `ClientApp` directory. This is a fully compatible Angular 7.2.0 CLI application. This means from within the `ClientApp` folder full `ng generate` capabilities are available and encouraged.

## Running the project

This is an ASP.NET Core 2.2 project with an Angular 6 front-end. The dotnet project is configured to automatically build the Angular project when `dotnet run` is executed. This means that you do not need to worry about running `ng serve -o` manually. It also runs in hot reload mode so any changes made to the dotnet code and/or the angular code will cause an automatic reload and refresh in the browser.

## Debugging from Visual Studio Code

Included with this project is a `.vscode/launch.json` file and a `.vscode/tasks.json` file. This means by default you can run `F5` and hit breakpoints in both server and client side code. Sweet!!

If you have issues when first running make sure that the `Full stack` debug target is chosen.

## Contributions Welcome

This is a very informal project and any and all pull requests with improvements will be accepted. I look forward to your feedback!

## Angular Training

If you are new or experienced with Angular I highly recommend that you head over to Ultimate Angular and signup for the Angular Framework courses. Follow the link in the banner to do so.

<div class="ultimate-courses-banner"><a href="https://ultimatecourses.com/angular?ref=76683_ttll_neb"><img src="https://ultimatecourses.com/assets/img/banners/ultimate-angular-leader.svg" style="width:100%;max-width:100%"></a></div>
