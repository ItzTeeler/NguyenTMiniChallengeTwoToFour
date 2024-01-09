namespace NguyenTMiniChallengeTwoToFour.Service.LessOrGreater;

public class LessOrGreaterService : ILessOrGreaterService
{
    public string LessOrGreater(double number1, double number2)
    {
        if (number1 > number2)
        {
            return $"{number1} is greater than {number2}. \n {number2} is less than {number1}.";
        }
        else if (number1 < number2)
        {
            return $"{number2} is greater than {number1}. \n {number1} is less than {number2}.";
        }
        else
            return $"{number1} is equal to {number2}.";
    }
}
