namespace NguyenTMiniChallengeTwoToFour.Service.LessOrGreater;

public class LessOrGreaterService : ILessOrGreaterService
{
    public string LessOrGreater(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);

        if (convertNum1 > convertNum2)
        {
            return $"{convertNum1} is greater than {convertNum2} \n {convertNum2} is less than {convertNum1}";
        }
        else if (convertNum1 < convertNum2)
        {
            return $"{convertNum2} is greater than {convertNum1} \n {convertNum1} is less than {convertNum2}";
        }
        else
            return $"{convertNum1} is equal to {convertNum2}";
    }
}
