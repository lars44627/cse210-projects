using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetReference());
        Console.WriteLine(string.Join(" ", _words.Select(word => word.GetDisplayText())));
    }

    public void HideWords()
    {
        int wordsToHide = 3;
        int hiddenCount = 0;
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        while (hiddenCount < wordsToHide && visibleWords.Count > 0)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
            hiddenCount++;
        }
    }

    public bool IsFullyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}