using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordArray = text.Split(" ");        

        foreach (string w in wordArray)
        {
            Word scripWord = new Word(w);
            _words.Add(scripWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i <= numberToHide; i++)
        {  
            Random random = new Random();
            int randomNum = -1;

            do
            {
                randomNum = random.Next(0, _words.Count());   
            } while (_words[randomNum].IsHidden());

            _words[randomNum].Hide();                      
        }
    }

    public string GetDisplayText()
    {
        Console.Clear();
        _reference.GetDisplayText();
        string scripture = "";
        scripture = _reference.GetDisplayText();
        foreach (Word w in _words)
        {
            scripture += $" {w.GetDisplayText()}";
        }
        return scripture;
    }

    public bool IsCompletelyHidden()
    {
        bool allHidden = true;

        foreach (Word w in _words)
        {
            if (w.IsHidden() == false)
            {
                allHidden = false;
                break;
            }
        }

        return allHidden;
    }
}