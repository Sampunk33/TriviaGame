using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriviaGame
{
    public class Game
    {
        Player player;
        List<Question> gameQuestions;
        int totalPoints = 0;
        
        /// <summary>
        /// Initialize questions object
        /// </summary>
        public void SetUpGame()
        {
            gameQuestions = new List<Question>();
            CreateQuestions();
        }

        /// <summary>
        /// Main flow of the game
        /// </summary>
        public void Start()
        {
            int pointsForRound = 0;
            for (int i = 1; i <=5; i++)
            {
                pointsForRound += 100;
                Question question = ChooseQuestion(i);
                Round round = CreateRound(i, question, pointsForRound);
                round.ShowQuestion();
                string answer = Console.ReadLine();
                if (answer == "q")
                {
                    EndGame(answer);
                    Restart();
                    break;
                }
                bool roundResult = round.EvaluateAnswer(answer);

                if(roundResult == false)
                {
                    EndGame("Fail");
                    Restart();
                    break;
                }

                totalPoints = totalPoints + round.Points;
                Console.WriteLine("-      Ganaste: " + totalPoints);
                if(i == 5)
                {
                    EndGame("Success");
                    Restart();
                }
            }
            
        }

        /// <summary>
        /// Initialize player object
        /// </summary>
        public void CreatePlayer()
        {
            player = new Player();
            Console.WriteLine("Ingrese su nombre");
            player.FullName = Console.ReadLine();
            Console.WriteLine("Ingrese su ciudad");
            player.City = Console.ReadLine();
        }

        /// <summary>
        /// Add questions to gameQuestions object
        /// </summary>
        private void CreateQuestions()
        {
            gameQuestions.AddRange(Question.CreateQuestionsForLevelOne());
            gameQuestions.AddRange(Question.CreateQuestionsForLevelTwo());
            gameQuestions.AddRange(Question.CreateQuestionsForLevelThree());
            gameQuestions.AddRange(Question.CreateQuestionsForLevelFour());
            gameQuestions.AddRange(Question.CreateQuestionsForLevelFive());
        }

        /// <summary>
        /// Select questions to each level
        /// </summary>
        /// <param name="roundNumber">level filter</param>
        /// <returns></returns>
        private Question ChooseQuestion(int roundNumber)
        {
            List<Question> questionForLevel = new List<Question>();

            for (int i = 0; i < gameQuestions.Count; i++)
            {
                if(gameQuestions[i].Level == roundNumber)
                {
                    questionForLevel.Add(gameQuestions[i]);
                }
            }
            Random randomObject = new Random();
            int randomNumber = randomObject.Next(0, 4);
            return questionForLevel[randomNumber];
        }

        /// <summary>
        /// Initialize round object
        /// </summary>
        /// <param name="roundNumber"></param>
        /// <param name="roundQuestion"></param>
        /// <param name="points"></param>
        /// <returns></returns>
        private Round CreateRound(int roundNumber, Question roundQuestion, int points)
        {
            Round round = new Round(roundNumber, roundQuestion, points);
            return round;
        }

        /// <summary>
        /// Show final message to the player when the game is over
        /// </summary>
        /// <param name="reason"></param>
        private void EndGame(string reason)
        {
            string message = "";
            switch (reason)
            {
                case "q":
                    message = "El jugador: " + player.FullName + " se retiró voluntariamente, con un total de: " + totalPoints + " puntos";
                    break;
                case "Success":
                    message = "Felicidades, has ganado el juego";
                    break;
                case "Fail":
                    message = "Has perdido " + player.FullName + " y tu puntaje es 0";
                    break;
            }

            Console.WriteLine("\n");
            Console.WriteLine(message);
        }

        /// <summary>
        /// Play again if the user wants
        /// </summary>
        private void Restart()
        {
            Console.WriteLine("\n");
            Console.WriteLine("¿Desea jugar nuevamente?");
            Console.WriteLine("si");
            Console.WriteLine("no");
            string restart = Console.ReadLine();
            if (restart == "si")
            {
                totalPoints = 0;
                CreatePlayer();
                Start();
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Muchas gracias por jugar");
            }
        }
    }
}
