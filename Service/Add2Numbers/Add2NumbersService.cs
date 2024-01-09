namespace NguyenTMiniChallengeTwoToFour.Service.Add2Numbers;

public class Add2NumbersService : IAdd2NumbersService
{
    public double Adding2Num(string number1, string number2)
    {
        double convertNum1 = Convert.ToDouble(number1);
        double convertNum2 = Convert.ToDouble(number2);
        double sum = convertNum1 + convertNum2;
        return sum;
    }
}
