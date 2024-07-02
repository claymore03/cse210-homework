public class Word
{
    private string _word;

    public string GetWord()
    {
        return _word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }

   

        // Display the words in the list
        
    //     foreach (string words in _wordsList)
    //     {
           
    //             var keyInfo = Console.ReadKey();
    //             if (keyInfo.Key == ConsoleKey.Enter)
    //             {
    //                 Random random = new Random();
    //                 int numberOfWordsToReplace = random.Next(0, _wordsList.Count);
    //                 HashSet<int> replacedIndices = new HashSet<int>();

    //                 string newSentence = string.Join(" ", _wordsList);
    //                 Console.Clear();
    //                 Console.WriteLine(newSentence);

    //                 while (replacedIndices.Count < numberOfWordsToReplace)
    //                 {
    //                     int index = random.Next(_wordsList.Count);
    //                     if (!replacedIndices.Contains(index))
    //                     {
    //                         _wordsList[index] = "---";
    //                         replacedIndices.Add(index);
    //                     }
    //                 }
    //             }
    //             else if (keyInfo.Key == ConsoleKey.Escape)
    //             {
    //                 break;
    //             }
    //         }
    //     }
    // }
    
}
