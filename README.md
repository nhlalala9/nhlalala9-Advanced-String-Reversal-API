# StringManipulationApi

# Palindrome API

This API takes a string as input and returns the reversed string while checking if the input string is a palindrome.

## Dependencies

*.NET Core 3.1 or later
* ASP.NET Core 3.1 or later

## Setup

1. Clone the repository: `git clone https://github.com/yourusername/StringManipulationApi.git`
2. Open the project in Visual Studio or your preferred IDE.
3. Restore NuGet packages: `dotnet restore`
4. Run the project: `dotnet run`

## Usage

1. Send a GET request to `https://localhost:5001/api/palindrome?input=<your_string_here>`
2. Replace `<your_string_here>` with the input string you want to check.
3. The API will return a JSON response containing the reversed string and a boolean indicating whether the original string is a palindrome.

Example:

`GET https://localhost:5001/api/palindrome?input=racecar`

Response:
```json
{
  "ReversedString": "racecar",
  "IsPalindrome": true
}

  

