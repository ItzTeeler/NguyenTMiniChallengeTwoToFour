namespace NguyenTMiniChallengeTwoToFour.Service.Ask2Questions;

public class Ask2QuestionsService : IAsk2QuestionsService
{
    public string Ask2Questions(string Whatisyourname, string Whattimedidyouwakeup)
    {
        return $"Hello {Whatisyourname}! You woke up at {Whattimedidyouwakeup}! Good Job...";
    }
}
