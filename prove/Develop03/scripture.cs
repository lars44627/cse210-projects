using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetReference());

        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        Console.WriteLine(displayText.Trim());
    }

    public void HideWords()
    {
        int wordsToHide = 3;
        int hiddenCount = 0;
        List<int> visibleIndexes = new List<int>();
        
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        while (hiddenCount < wordsToHide && visibleIndexes.Count > 0)
        {
            int randomIndex = _random.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[randomIndex];

            _words[wordIndex].Hide();
            visibleIndexes.RemoveAt(randomIndex);
            hiddenCount++;
        }
    }

    public bool IsFullyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}