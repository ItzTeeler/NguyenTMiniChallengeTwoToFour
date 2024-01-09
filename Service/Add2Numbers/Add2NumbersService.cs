namespace NguyenTMiniChallengeTwoToFour.Service.Add2Numbers
{
    public class Add2NumbersService : IAdd2NumbersService
    {
        public string Adding2Num(string number1, string number2)
        {
            double num1 = 0;
            bool isTrue1 = double.TryParse(number1, out num1);
            
            if (isTrue1)
            {
                double num2 = 0;
                bool isTrue2 = double.TryParse(number2, out num2);
                
                if (isTrue2)
                {
                    double sum = num1 + num2;
                    return $"The sum of {num1} and {num2} is {sum}.";
                }
                else
                {
                    return "Your second number isn't a valid number";
                }
            }
            else
            {
                return "Your first number isn't a valid number";
            }
        }
    }
}
