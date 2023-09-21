# WeatherMonitoringApp :sunny:	:partly_sunny:	:sun_behind_rain_cloud:	
This is a console [C#](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/) project that I have completed while on an internship with FootHill Technologies.

The project acts as a backend for an actual app that takes in weather data and then provides clearer information about the weather via console.

## Introduction

The purpose of this app is to convert raw weather data provided by a file (which acts as an API) to actual infromation about the state of the weather.

The infromation is provided by a bunch of bots that assess the data and print a message to the console corresponding to the data.

I have developed this project using `Visual Studio`.


## Getting Started

Before you begin, please make sure you have the following prerequisites:

- [.NET SDK](https://dotnet.microsoft.com/download/dotnet) (version 6.0)
- [Visual Studio](https://visualstudio.microsoft.com/) (optional)
- [NewtonSoft](https://www.newtonsoft.com/json/help/html/serializingjson.htm)

Then, Clone the repository to your local machine

```

git clone https://github.com/tariq-zaghal/WeatherMonitoringApp.git

```

After that, you can navigate to the project in your own device (I don't know any better but I think it would be safer to use Visual Studio since I developed the project using it).

If you, however, want to run it without an IDE, you can do so by:

  1- Navigate to the project directory
  
```

cd WeatherMonitoringApp

```
  2- Build and Run Project

```

dotnet build
dotnet run

```
## How to use Weather Monitoring App?

After you run the program, it will prompt you to enter the path of the data file. The file format supported in the app are either `JSON` or `XML`. 

A file must contain the data for one location (a city, for instance).

Note that you can add any file format you like by implementing the `IWeatherDataFile` interface, Provide checking in `DataFileFormatChecker` class,
and adding an option to the `WeatherDataFileFactory` class.

Use one of these two templates to provide data file.

#### For Json file:

```JSON


{
  "Location": "City Name",
  "Temperature": 23.0,
  "Humidity": 85.0
}

```

#### For Json file:

```XML


{
  "Location": "City Name",
  "Temperature": 23.0,
  "Humidity": 85.0
}

```

After that the program will parse the file into a `WeathData` object which contains the fields in the example file.

After that, the object will be passed to the weather bots which will print the weather information message based on the data provided and the theresholds in the 
weather bots.

each weather bot is present in an internal JSON file which loads at the beginning of the program. it looks like this:

```JSON

{
  "RainBot": {
    "enabled": true,
    "humidityThreshold": 70,
    "message": "It looks like it's about to pour down!"
  },
  "SunBot": {
    "enabled": true,
    "temperatureThreshold": 30,
    "message": "Wow, it's a scorcher out there!"
  },
  "SnowBot": {
    "enabled": false,
    "temperatureThreshold": 0,
    "message": "Brrr, it's getting chilly!"
  }
}

```

You can configure this data how you like and add extra bots too!! Providing you add to the implementation of the other related classes in the same folder.

Thank you!

Hope you will find it useful 😄 !
