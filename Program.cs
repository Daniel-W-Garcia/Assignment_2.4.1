Console.WriteLine("""
                  Hello, and welcome. We're going to build an array!
                  First we need to know how many elements we want in our array.
                  Please enter the number of elements in your array:
                  """);

string userInput = Console.ReadLine();

if (int.TryParse(userInput, out int arraySize))
{
    int[] array = new int[arraySize];
    
    Console.WriteLine($"""
                       You have entered {arraySize} elements.
                       Please enter the {arraySize} values of your array:
                       Use commas to separate values (e.g. 1,2,3,4,5)
                       """);
    
    string userInputLine = Console.ReadLine();
    string[] userInputValues = userInputLine.Split(",");
    int[] userInputValuesArray = Array.ConvertAll(userInputValues, int.Parse);
    int sum = 0;
    
    for (int i = 0; i < userInputValuesArray.Length; i++)
    {
        sum += userInputValuesArray[i];
    }
    Console.WriteLine($"""
                       The sum of your array ({userInputLine}) is {sum}.
                       """);
}








