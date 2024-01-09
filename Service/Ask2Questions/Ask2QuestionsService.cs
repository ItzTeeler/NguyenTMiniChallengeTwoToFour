namespace NguyenTMiniChallengeTwoToFour.Service.Ask2Questions;

public class Ask2QuestionsService : IAsk2QuestionsService
{
    public string Ask2Questions(string Whatisyourname, string Whatisyourfavoritefood)
    {
        return $"Hello {Whatisyourname}! Your favorite food is {Whatisyourfavoritefood}!";
    }
}
