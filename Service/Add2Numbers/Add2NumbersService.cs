namespace NguyenTMiniChallengeTwoToFour.Service.Add2Numbers;

public class Add2NumbersService : IAdd2NumbersService
{
    public double Adding2Num(double number1, double number2)
    {
        double sum = number1 + number2;
        return sum;
    }
}
