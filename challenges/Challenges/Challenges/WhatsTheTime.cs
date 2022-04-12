using System.Text;

namespace challenges.Challenges;

public class WhatsTheTime : Challenge
{
    public override string GetUrl()
    {
        return @"https://edabit.com/challenge/M65kgKXa2ut4CNorv";
    }
    
    public override void Run()
    {
        throw new NotImplementedException();
    }

    public string Solve(string input)
    {
        var firstNumber = FindFirstNumber(input);
        var secondNumber = FindSecondNumber(input);
        var thirdNumber = FindThirdNumber(input);
        var fourthNumber = FindFourthNumber(input);

        return $"{firstNumber}{secondNumber}:{thirdNumber}{fourthNumber}";
    }

    private string FindFirstNumber(string input)
    {
        return FindNumber(input, 0);
    }

    private string FindSecondNumber(string input)
    {
        return FindNumber(input, 4);
    }

    private string FindThirdNumber(string input)
    {
        return FindNumber(input, 10);
    }

    private string FindFourthNumber(string input)
    {
        return FindNumber(input, 14);
    }

    private string FindNumber(string input, int inclusiveLower)
    {
        var sb = new StringBuilder();
        
        sb.Append(GetRow(input, inclusiveLower, 0));
        sb.Append(GetRow(input, inclusiveLower, 1));
        sb.Append(GetRow(input, inclusiveLower, 2));
        sb.Append(GetRow(input, inclusiveLower, 3));
        sb.Append(GetRow(input, inclusiveLower, 4));

        var numberAsBits = sb.ToString();
        return ConvertBitsToNumber(numberAsBits);
    }

    private string GetRow(string input, int inclusiveLower, int zeroBasedRow)
    {
        var correctInclusiveLower = inclusiveLower + (17 * zeroBasedRow);

        var bit1 = correctInclusiveLower;
        var bit2 = correctInclusiveLower + 1;
        var bit3 = correctInclusiveLower + 2;
        
        return $"{input[bit1]}{input[bit2]}{input[bit3]}";
    }

    private string ConvertBitsToNumber(string numberAsString)
    {
        switch (numberAsString)
        {
            case "111101101101111": return "0";
            case "010110010010111": return "1";
            case "111001111100111": return "2";
            case "111001111001111": return "3";
            case "101101111001001": return "4";
            case "111100111001111": return "5";
            case "100100111101111": return "6";
            case "111001001001001": return "7";
            case "111101111101111": return "8";
            case "111101111001001": return "9";
            default:
                throw new ArgumentException("Invalid bits. Cannot convert to number", numberAsString);
        }
    }
}