# Days of the Week Console Application

This is a simple C# console application that prompts the user to enter their name and a number representing the day of the week (0-6). Based on the input, the application prints out the corresponding day name.

## Features

- Prompts the user for their name.
- Asks the user to input a number (0 to 6) representing the days of the week:
  - 0 = Sunday
  - 1 = Monday
  - 2 = Tuesday
  - 3 = Wednesday
  - 4 = Thursday
  - 5 = Friday
  - 6 = Saturday
- Returns the name of the day based on the input.
- If an invalid number is entered, the application returns "Invalid."

## How It Works

1. The user is asked to enter their name.
2. The program then prompts the user to input a number (0-6) that corresponds to the current day of the week.
3. The program uses a `switch` statement to match the number to the corresponding day name.
4. The day name is then displayed to the user, along with a personalized greeting.

## Sample Output

Hello, Kindly enter your name: Emmanuel

Welcome Emmanuel. Have you forgotten what day it's again? Well, I'm here to help you out. What day of the week is it (0-6)? 2 Hello Emmanuel, today is Tuesday.

## Requirements

- .NET Framework or .NET Core SDK
- Basic knowledge of C#

## How to Run

1. Clone or download this repository.
2. Open the project in an IDE like Visual Studio or use the .NET CLI.
3. Run the project by pressing `F5` or using the following command:

   ```bash
   dotnet run
Follow the prompts to interact with the program.

This README explains the purpose of the app, how it works, and how to run it. It also includes a sample output for clarity. Let me know if you'd like any changes!
