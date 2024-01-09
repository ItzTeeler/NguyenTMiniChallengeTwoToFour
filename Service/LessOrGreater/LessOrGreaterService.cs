namespace NguyenTMiniChallengeTwoToFour.Service.LessOrGreater;

public class LessOrGreaterService : ILessOrGreaterService
{
    public string LessOrGreater(string number1, string number2)
    {
        double num1 = 0;
        bool isTrue1 = double.TryParse(number1, out num1);
        if (isTrue1)
        {
            double num2 = 0;
            bool isTrue2 = double.TryParse(number2, out num2);
            if (isTrue2)
            {
                if (num1 > num2)
                {
                    return $"{num1} is greater than {number2}. \n {num2} is less than {num1}.";
                }
                else if (num1 < num2)
                {
                    return $"{num2} is greater than {num1}. \n {num1} is less than {num2}.";
                }
                else
                    {
                        return $"{num1} is equal to {num2}.";
                    }
            }
            else
            {
                return "Your second number is invalid";
            }
        }
        else
        {
            return "Your first number is invalid";
        };

    }
}
