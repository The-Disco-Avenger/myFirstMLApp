using MyMLApp;
// Add input data

bool isContinue = true;
do
{

    Console.WriteLine("Please enter the Moves First Address then second address.");
    var TestMove = new SentimentModel.ModelInput()
    {
        Col1 = Console.ReadLine() ?? "419 east park st lapeer MI 48446",
        Col2 = Console.ReadLine() ?? "6837 northlake rd otterlake MI 48404"
    };
    // Load model and predict output of sample data
    var result = SentimentModel.Predict(TestMove);

    Console.WriteLine($"Prediction Score: {result.Score}\nPredicted Price: {result.Prediction}\nFrom Address: {TestMove.Col1}\nTo Address: {TestMove.Col2}");
    Console.WriteLine("----------------------------");
    Console.WriteLine("Would you like to try another review?");
    bool isAccurateAnswer = false;
    while (!isAccurateAnswer)
    {
        Console.WriteLine("!!Please Enter Y for yes or N for no!!");
        var userResponse = Console.ReadLine();
        if (userResponse.ToUpper() == "Y" || userResponse.ToUpper() == "N")
        {
            isAccurateAnswer = true;
            if (userResponse.ToUpper() == "N")
            {
                isContinue = false;
            }
        }
    }

} while (isContinue);

