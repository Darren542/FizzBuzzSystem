namespace FizzBuzzLibrary;

public class FizzBuzzLogic
{
    public string GetFizzBuzz(int? number)
    {
      if (number == null) {
            throw new Exception("Number must not be null.");
      }
      if (number < 0 || number > 100) {
            throw new Exception("Number must be greater than or equal to 0 and less than or equal to 100.");
      }
      string result = string.Empty;
      for (int i = 1; i <= number; i++) {
        result += GetFizzBuzzSingle(i);
      }
      return result;
    }

    public static string GetFizzBuzzSingle(int number)
    {
        if (number < 0) {
            throw new Exception("Number must be greater than or equal to 0.");
        }
        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz ";
        }
        if (number % 3 == 0)
        {
            return "Fizz ";
        }
        if (number % 5 == 0)
        {
            return "Buzz ";
        }
        return number.ToString() + ' ';
    }
}
