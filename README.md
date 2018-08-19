### dotnet-console-tips
https://odetocode.com/blogs/scott/archive/2018/08/16/three-tips-for-console-applications-in-net-core.aspx

# Package
```
McMaster.Extensions.CommandLineUtils
```
https://natemcmaster.github.io/CommandLineUtils/docs/intro.html

# Some Example
```
[Option(Description = "Path to the conversion folder ", ShortName = "p")]
[DirectoryExists]
public string Path { get; protected set; }
 
[Argument(0, Description ="convert | publish | clean")]
[AllowedValues("convert", "publish", "clean")]
public string Action { get; set; }
```
