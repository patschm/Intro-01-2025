namespace FuncProcs;

// TODO 1a: Can you define a function here? (yes/no) 
// No

// TODO 2a: Can you call a function or procedure here? (yes/no)
// No

internal class Program
{
    // TODO 1b: Can you define a function here? (yes/no) 
    // Yes

    // TODO 2b: Can you call a function or procedure here? (yes/no)
    // No

    static void Main(string[] args)
    {
        // TODO 1c: Can you define a function here? (yes/no) 
        // Yes but not recommended

        // TODO 2c: Can you call a function or procedure here? (yes/no)
        // Yes

        {
            // TODO 1d: Can you define a function here? (yes/no) 
            // Yes but not recommended

            // TODO 2d: Can you call a function or procedure here? (yes/no)
            // Yes
        }

        ToonWelkomsScherm();
        ToonBericht("Hallo");
        int number = RandomInt();
        Console.WriteLine(number);

        number = RandomInt(10, 100);
        Console.WriteLine(number);

        DateTime st = DateTime.Now.AddYears(-23);
        ToonPersoonsData("Kees", 23, st, "Didam");

        DateTime datum = CreeerDatum(1999, 7, 23);
        Console.WriteLine(datum);

    }

    // TODO 3: Define a procedure that displays a welcome message (Console.WriteLine("Welcome"))
    // and call the procedure in the appropriate place.
    static void ToonWelkomsScherm()
    {
        Console.WriteLine("Welkom");
    }

    // TODO 4: Define a procedure that displays a generic message, specified by the caller (Console.WriteLine($"External data: {xxx}"))
    // and call the procedure in the appropriate place.
    static void ToonBericht(string message)
    {
        Console.WriteLine(message);
    }
    // TODO 5: Create a function that generates and returns a random number
    // and call the function in the appropriate place and show the result.

    static int RandomInt()
    {
        int rnd = Random.Shared.Next();
        return rnd;
    }
    // TODO 6: Create a function that generates and returns a random number between a certain range, specified by the caller
    // and call the function in the appropriate place and show the result.
    static int RandomInt(int start, int eind)
    {
        int rnd = Random.Shared.Next(start, eind);
        return rnd;
    }
    // TODO 7: Define a procedure that accept 4 inputs: a name, an age, a birthdate and a birth place.
    // Print the information to the screen.
    // Call the function in the appropriate place
    static void ToonPersoonsData(string naam, int leeftijd, DateTime geboorteDatum, string geboorteplaats)
    {
        Console.WriteLine($"{naam} {geboorteDatum} ({leeftijd}) {geboorteplaats}");
    }

    // TODO 8: Define a function that accept 3 inputs: year, month, day, that returns a DateTime.
    // Call the function in the appropriate place and show the result.
    static DateTime CreeerDatum(int year, int month, int day)
    {
        DateTime x =  new DateTime(year, month, day);
        return x;
    }


    static void DoSomething()
    {
        // TODO 2e: Can you define a function here? (yes/no) 
        // Yes but not recommended

        // TODO 2e: Can you call a function or procedure here? (yes/no)
        // Yes
    }

    // TODO 1f: Can you define a function here? (yes/no) 
    // Yes

    // TODO 2f: Can you call a function or procedure here? (yes/no)
    // No
}
// TODO 1g: Can you define a function here? (yes/no) 
// No

// TODO 2g: Can you call a function or procedure here? (yes/no)
// No
