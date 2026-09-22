using System;
using System.Collections.Generic;
public class Scripture

{

    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)

    {
        _reference = reference;

        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords) 
        {
            _words.Add(new Word(wordText));
        }
    }
    public void HideRandomWords(int numberToHide)

    {
        Random random = new Random();

        List<Word> visibleWords = new List<Word>();

        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        for (int i = 0; i < numberToHide; i++)
        {
            if (visibleWords.Count == 0)
            {
                break;
            }

            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();

            visibleWords.RemoveAt(index);
        }

    }

    public string GetDisplayText()
    {
        List<string> wordTexts = new List<string>();
        foreach (Word word in _words)
        {
            wordTexts.Add(word.GetDisplayText());
        }

        string text = string.Join(" ", wordTexts);
        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompletelyHidden()
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