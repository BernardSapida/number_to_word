using System;

namespace Program
{
  class Program
  {
    string[] numbers = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
    string[] tens = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
    string number = "";

    static void Main(string[] args)
    {
        Program program = new Program();
        program.getUserInput();
        Console.WriteLine(program.convertToWord(Convert.ToInt32(program.number)));
    }

    /// <summary>
    /// The function `getUserInput()` asks the user to enter a number and stores the number in the
    /// variable `number`
    /// </summary>
    void getUserInput() {
        Console.Write("Enter a number: ");
        number = Console.ReadLine();
    }

    /// <summary>
    /// If the number is less than 20, return the word for that number. If the number is less than 100,
    /// return the word for the tens place and the word for the ones place. If the number is less than
    /// 1000, return the word for the hundreds place and the word for the tens and ones place. If the
    /// number is less than 1000000, return the word for the thousands place and the word for the
    /// hundreds, tens, and ones place
    /// </summary>
    /// <param name="number">The number to be converted to words.</param>
    /// <returns>
    /// the number in words.
    /// </returns>
    string convertToWord(int number) {
        if(number < 20) return numbers[number];

        int digit = number%10;
        if(number < 100) return tens[(number/10)-2] + (digit != 0 ? " " + numbers[digit] : "");
        if(number < 1000) return numbers[(number/100)] + " Hundred " + (number % 100 == 0 ? "" : convertToWord(number % 100));
        return convertToWord(number/1000) + " Thousand " + (number % 1000 != 0 ? "" + convertToWord(number % 1000) : "");
    }
  }
}