[![Build Status](https://travis-ci.org/JMunozLz/name-sorter.svg?branch=master)](https://travis-ci.org/JMunozLz/name-sorter)
# name-sorter

## Development

Before you can build this project, you must install and configure the following dependencies on your machine:

1. [.NET Core 2.0 SDK](https://www.microsoft.com/net/download/archives/): We use .NET Core to run and build the project. We also use .NET Core to manage NuGet dependencies.

Run the following command to run the application in development:

    dotnet run ./unsorted-names-list.txt

## Building application

To build the binaries and project executable, run:

    dotnet build --runtime <RUNTIME_IDENTIFIER>

The binaries created could be found in the folder **.\name-sorter\name-sorter\bin\Debug\netcoreapp2.0\**.

The list of specified runtime identifier could be found on [RID](https://docs.microsoft.com/en-us/dotnet/core/rid-catalog) catalog.

## Executing application

After building the aplication go to path **.\name-sorter\name-sorter\bin\Debug\netcoreapp2.0\<RUNTIME_IDENTIFIER>**.
Copy the file **unsorted-names-list.txt** to the folder **.\name-sorter\name-sorter\bin\Debug\netcoreapp2.0\<RUNTIME_IDENTIFIER>**.

To execute the application run:

    name-sorter ./unsorted-names-list.txt

This will create the file **sorted-names-list.txt** in the same folder with the list of names sorted by last name.

## Testing

To launch your application's tests, run:

    dotnet test

## Continuous Integration

To configure CI for your project, configure the file **.travis.yml** on the root project. The pipeline will execute the build and test steps, and could be checked on the link: [Travis Pipeline](https://travis-ci.org/JMunozLz/name-sorter/)

## Built With

* [.NET Core 2.0](https://docs.microsoft.com/en-us/dotnet/core/) - Developer platform
* [xUnit](https://xunit.github.io/#documentation/) - Unit testing
* [Travis](https://docs.travis-ci.com//) - Continuous integration

## Authors

* **Johann Munoz** - [JMunozLz](https://github.com/JMunozLz)
