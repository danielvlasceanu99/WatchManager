# WatchManager
## Minunatia de proiect de la retele

### Tutporial: [Get started with ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-3.1&tabs=visual-studio)

### Prerequisites:
- [Visual Studio 2019 16.4 or later](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019) with the ASP .NET and web development workload
- [.NET Core 3.1 SDK or later](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019)
- [Visual Studio 2019 Comunity Edition](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=16#) to run and edit the app

### How to start the app
Open the Package Manager Console and run the following commands
```sh
Install-Package Microsoft.EntityFrameworkCore.SqlServer
```
```sh
Add-Migration InitialCreate
```
``` sh 
Update-Database
```
Run the app using F5 for debug mode or CTRL+F5 to run without debuging

##### To add a new migration run 
```sh 
Add-Migration migratio_name
```
```sh 
Update-Database
```
