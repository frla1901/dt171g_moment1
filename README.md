# dt171g_moment1


## Installera utvecklingsmiljön C#

### Delmoment i kursen DT071G Programmering i C#.NET

#### Syfte
* Kunna installera C# utvecklingmiljö
* Kunna skapa ett första program skrivet i C#

De nya kunskaperna kommer jag sedan att kunna använda och applicera i resterande laborationer och projektuppgift i kursen.

#### Förberedelser
Innan jag ens började med utvecklingsmiljön så gick jag igenom
[Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/hello-world-your-first-program?tabs=windows) instroduktionen och läste kapitel 1 i kursboken _"C# 8.0 and .NET Core 3.0 Modern Cross-plattform Development (Fourth edition)"_ av Mark J Price. 

#### Utvecklingsmiljö

Visual studio code (VSC) har jag installerat på min MacBook pro (2017) sen länge så valde det i detta moment. 

Jag hade skapat en mapp för momentet så när jag öppnade mappen och skapade en fil som hette program.cs i VSC fick jag upp att jag behövde en extension. Installerade [C# for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) och behövde även installera [.NET 5.0 SDK för Mac](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.402-macos-x64-installer?journey=vs-code). 

![Skärmdump som visar nedladdning av .NET 5.0 SDK](https://github.com/frla1901/dt171g_moment1/blob/master/images/Sk%C3%A4rmavbild%20Installation.png)

Stötte på lite problem med C# extension då den inte hittade min .NET SDK så felsökte via [Omnisharp](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.402-macos-x64-installer?journey=vs-code). Hittade path till min dotnet med kommandot _which dotnet_ i terminalen. Jag kunde sen justera och köra debug VSC med funktionen _getUnixShellEnvironment_. Körde därefter _dotnet new console --framework net5.0_ och fick info om att jag behövde lägga till _--force_ för att skapa dem nya Applikationsmallen. 

Se nedan bild som visar hur min miljö ser ut. 

![Skärmdump som visar min VSC](https://github.com/frla1901/dt171g_moment1/blob/master/images/Sk%C3%A4rmavbild%20VSC.png)

#### Mitt första exempelprogram
När jag hade fått igång Applikationsmallen så genererade den en enkel "Hello World"-applikation. Den anropar metoden _Console.WriteLine (String)_ för att visa _"Hello World!"_ i konsolfönstret. Mallkoden definierar även en klass, _Program_, med en enda metod, _Main_, som tar en _String-array_ som ett argument. 
För att testköra denna applikation skrev jag _dotnet run_ i teminalen. Se nedan resultat: 

**frida@MacBook-Pro dt171g_moment1 % dotnet run**

**Hello World**

**frida@MacBook-Pro dt171g_moment1 %**

Jag valde att testa vidare och ändrade innehållet i metoden _Main_ som i exemplet [Microsoft Docs](https://docs.microsoft.com/sv-se/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-5-0). Se nedan resultat som efter att kommandot _dotnet run_ körst i terminalen. 

**frida@MacBook-Pro dt171g_moment1 % dotnet run**

**What is your name?**

**Frida**

**Hello, Frida, on 2021-11-02 at 17:04!**

**Press any key to exit...**

Jag hade glömt att starta Git lokalt men hade skapat detta remote repo i förväg så gjorde Commit och Pushade det. 
Fortsätter att testa mig vidare under den närmaste veckan! 

Har under veckan påbörjat att följa bokens instruktioner i kapitel 2 och skapat nya projekt med kommandot _dotnet new console_ vilket varit lärorikt. 
Exempelvis fann jag följande...

**frida@MacBook-Pro C#_test % csc -langversion:?**

**zsh: no matches found: -langversion:?**

**frida@MacBook-Pro C#_test %**

Undersökte vilket C# compiler version som var kompatibel med den version av .NET Core SDK jag har installerat (5.0.402) och det var version 9.0 vilket jag inkluderat i .csproj filen på följande sätt:


<LangVersion>9.0</LangVersion>


