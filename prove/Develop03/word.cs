//Splits the scripture into a list of words to be blanked out
public class Word
{
    List<string> words = new List<string>();
    int count = 0;
    int hiddenWordsCount = 0;

    public void SplitAndAddWords(string scriptureText)
    {
        string[] wordsArray = scriptureText.Split(' ');
        foreach (string word in wordsArray)
        {
            words.Add(word);
        }
    }

    public string GetVisibleScripture()
    {
        string visibleScripture = "";
        for (int i = 0; i < words.Count; i++)
        {
            if ((i + 1) % 3 != 0 || words[i] == "___")
            {
                visibleScripture += words[i] + " ";
            }
            else
            {
                visibleScripture += "___ ";
            }
        }
        return visibleScripture;
    }

    public bool HandleEnterPressed()
    {
        count++;
        if (count % 3 == 0)
        {
            for (int i = 2; i < words.Count; i += 3)
            {
                if (words[i] != "___")
                {
                    words[i] = "___";
                    hiddenWordsCount++;
                }
            }
            if (hiddenWordsCount == words.Count / 3)
            {
                return false;
            }
        }
        return true;
    }
}