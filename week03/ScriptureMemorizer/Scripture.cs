using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] splitScripture = text.Split(' ');
        foreach (string word in splitScripture)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numHidWords)
    {
        Random rand = new Random();
        int count = numHidWords;

        while (count > 0)
        {
            int index = rand.Next(_words.Count);
            if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
                count--;
            }
        }
    }

    public string GetDisplayText()
    {
        string newScriptureV = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            newScriptureV += word.GetDisplayText() + " ";
        }
        return newScriptureV.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
                return false;
        }
        return true;
    }
}
