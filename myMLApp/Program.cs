using MyMLApp;
// Add input data

bool isContinue = true;
do
{

    Console.WriteLine("Please enter a sample review");
    var sampleData = new SentimentModel.ModelInput()
    {
        Col0 = Console.ReadLine() ?? "I loved it"
    };
    // Load model and predict output of sample data
    var result = SentimentModel.Predict(sampleData);

    // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
    var sentiment = result.Prediction == 1 ? "Positive" : "Negative";
    Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
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

