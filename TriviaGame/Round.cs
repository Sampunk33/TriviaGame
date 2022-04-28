using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGame
{
    public class Round
    {
        public Round(int roundNumber, Question roundQuestion, int points)
        {
            RoundNumber = roundNumber;
            RoundQuestion = roundQuestion;
            Points = points;
        }

        public int RoundNumber { get; }
        public Question RoundQuestion { get; }
        public int Points { get; }
        public string Result { get; }

        /// <summary>
        /// Give to the player the question and theirs possible answers
        /// </summary>
        public void ShowQuestion()
        {
            Console.WriteLine(RoundQuestion.Sentence);
            Console.WriteLine("\n");
            for (int i = 0; i < RoundQuestion.Answers.Count; i++)
            {
                Console.WriteLine($"{RoundQuestion.Answers[i].Index}) - {RoundQuestion.Answers[i].Sentence}");
            }
            Console.WriteLine("q) Abandonar Juego");
        }

        /// <summary>
        /// Receive the IsAnswerValid result
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        public bool EvaluateAnswer(string answer)
        {
            return RoundQuestion.IsAnswerValid(answer);
        }
    }
}
