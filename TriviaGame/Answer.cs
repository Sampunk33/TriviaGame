using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGame
{
    public class Answer
    {
        public Answer(string sentence, bool isValid, string index)
        {
            Sentence = sentence;
            IsValid = isValid;
            Index = index;
        }
        public string Sentence { get;  }
        public bool IsValid { get; }
        public string Index { get; }

    }
}
