## A Diamond Kata solution using .NET 6 and a TDD approach

## Running the solution
- The solution contains a .NET 6 console app defining and consuming the GenerateDiamond function.
- Within the same solution folder, there is a unit testing project that covers the functionality of GenerateDiamond function
- To run the console app call **dotnet run** in the terminal
- To run the unit tests, call **dotnet test** by opening a terminal in the testing folder
- Beware, that you need the .NET 6 SDK installed on your local machine to be able to run this code


# The Diamond Kata

Given a character from the alphabet, print a diamond of its output with that character being the midpoint of the diamond.

Examples

    > diamond.exe A
      A

    > diamond.exe B
       A
      B B
       A

    > diamond.exe C
        A
       B B
      C   C
       B B
        A

## Hints

It may be helpful visualise the whitespace in your rendering like this:

    > diamond.exe C
    _ _ A _ _
    _ B _ B _
    C _ _ _ C
    _ B _ B _
    _ _ A _ _
