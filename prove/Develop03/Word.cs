using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        char[] wordAsChars = _text.ToCharArray();
                
        for (int i = 0; i < wordAsChars.Length; i++)
        {
            
            if (char.IsPunctuation(wordAsChars[i]))
            {
                continue;
            }
            
            wordAsChars[i] = '_';
        }

        string hiddenWord = new string(wordAsChars);
        _text = hiddenWord;
        _isHidden = true;
    }

    // I didn't end up using the Show() method, but I still kept it in the code.
    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }

}