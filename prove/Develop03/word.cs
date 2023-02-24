//Splits the scripture into a list of AR_words to be blanked out
// Austin Reeves
public class AR_Word
{
    List<string> AR_words = new List<string>();
    int count = 0;
    int hiddenAR_WordsCount = 0;

    public void SplitAndAddWords(string scriptureText)
    {
        string[] AR_wordsArray = scriptureText.Split(' ');
        foreach (string AR_word in AR_wordsArray)
        {
            AR_words.Add(AR_word);
        }
    }

    public string GetVisibleScripture()
    {
        string visibleScripture = "";
        for (int i = 0; i < AR_words.Count; i++)
        {
            if ((i + 1) % 3 != 0 || AR_words[i] == "___")
            {
                visibleScripture += AR_words[i] + " ";
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
            for (int i = 2; i < AR_words.Count; i += 3)
            {
                if (AR_words[i] != "___")
                {
                    AR_words[i] = "___";
                    hiddenAR_WordsCount++;
                }
            }
            if (hiddenAR_WordsCount == AR_words.Count / 3)
            {
                return false;
            }
        }
        return true;
    }
}