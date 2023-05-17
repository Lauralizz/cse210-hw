using System;
using System.Collections.Generic;

public class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public ScriptureReference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetFormattedReference()
    {
        if (_endVerse != null)
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        else
            return $"{_book} {_chapter}:{_startVerse}";
    }
}