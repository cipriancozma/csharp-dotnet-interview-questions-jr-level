
 static int? DivideNumbers(int a, int b)
{

    try
    {
        return a / b;
    } 
    catch (DivideByZeroException ex) 
    {
        Console.WriteLine($"Attempt to divide by zero." + $"Exception message: {ex.Message}");
        return null;
    }
    finally
    {
        Console.WriteLine("Executing finally block");
    }

}

DivideNumbers(2, 2);

static int? ElementAtIndex(int[] numbers, int index)
{
    try
    {
        return numbers[index];
    }
    catch (NullReferenceException)
    {
        Console.WriteLine($"Input array is null");
        return null;
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine($"Index {index} does not exist in input array");
        return null;
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Unexpected error, see message: {ex.Message}");
        return null;
    }
}

Console.ReadKey();