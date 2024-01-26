using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        char[] wordAsChars = _text.ToCharArray();
                
        for (int i = 0; i < wordAsChars.Length; i++)
        {
            wordAsChars[i] = '_';
        }

        string updatedWord = new string(wordAsChars);
        _text = updatedWord;
        _isHidden = true;
    }

    public void Show()
    {
        ;
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