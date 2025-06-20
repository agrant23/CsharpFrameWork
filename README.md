# CsharpFrameWork

This is currently a bare bones framework. Very soon I will be filling out this repository with more testing.

To run this repository, you need to: 
1. Download Visual Studio Code or the IDE of your preference and follow the steps in this
   site. 
    https://code.visualstudio.com/docs/csharp/get-started
    you can use the C# Dev Kit. If that is problematic you can download the .NET Framework and SDK yourself https://dotnet.microsoft.com/en-us/download/dotnet/9.0 and set up the path. The .NET version used for this repository is 9.0.200
2. Pull this repository onto your PC from the remote URL 
    https://github.com/agrant23/CsharpFrameWork using GIT Bash or GIT Desktop. 
   For GIT Bash perform the following:

        git remote add origin https://github.com/agrant23/CsharpFrameWork
        git branch --set-upstream-to=origin/main
        git pull origin main
            the git command
                git pull origin <remote branch> --allow -unrelated-histories
            may be needed to pull the repository, but be careful doing this
4. Update the path for the Chrome Driver in the Driver.cs File.
        In the near future I will update this repository so this step is not necessary.
5. With your Operating System's command console navigate to the directory where the 
    MyTestFrameWork.csproj lives and enter the commands:

        dotnet new nunit
        dotnet add package selenium.webdriver
6. Open the Repository in VS Code and check for errors. If there are no errors then run the
     commands.

        dotnet build
        dotnet test


I created this framework from scratch. Some changes/additions to come:

    I am exploring implementing the xUnit Framework instead of NUnit.
    Cross Browser testing
    Cross Platform testing
