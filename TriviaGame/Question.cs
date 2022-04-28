using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGame
{
    public class Question
    {
        public int Level { get; set; }
        public string Sentence { get; set; } 
        public List <Answer> Answers { get; set; }

        /// <summary>
        /// Check the selected answer
        /// </summary>
        /// <param name="answerIndex">selected answer</param>
        /// <returns></returns>
        public bool IsAnswerValid(string answerIndex)
        {
            Answer rightAnswer;
            for (int i = 0; i < Answers.Count; i++)
            {
                if (Answers[i].IsValid)
                {
                    rightAnswer = new Answer(Answers[i].Sentence, Answers[i].IsValid, Answers[i].Index);

                    if (rightAnswer.Index == answerIndex)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Fill the questionsLevelOne object
        /// </summary>
        /// <returns> questions by level 1</returns>
        public static List<Question> CreateQuestionsForLevelOne()
        {
            List<Question> questionsLevelOne = new List<Question>();
            Question questionOne = new Question();
            questionOne.Sentence = "¿Cuál es el planeta más grande del sistema solar?";
            questionOne.Level = 1;
            questionOne.Answers = new List<Answer>
            {
                new Answer("Tierra", false, "a"),
                new Answer("Saturno", false, "b"),
                new Answer("Venus", false, "c"),
                new Answer("Jupiter", true, "d"),
            };

            questionsLevelOne.Add(questionOne);

            Question questionTwo = new Question();
            questionTwo.Sentence = "¿Cuál es la capital de Argentina?";
            questionTwo.Level = 1;
            questionTwo.Answers = new List<Answer>
            {
                new Answer("Mendoza", false, "a"),
                new Answer("Buenos Aires", true, "b"),
                new Answer("Rosario", false, "c"),
                new Answer("Cordoba", false, "d"),
            };

            questionsLevelOne.Add(questionTwo);

            Question questionThree = new Question();
            questionThree.Sentence = "¿Cuántos días tiene un año bisiesto?";
            questionThree.Level = 1;
            questionThree.Answers = new List<Answer>
            {
                new Answer("366", true, "a"),
                new Answer("420", false, "b"),
                new Answer("365", false, "c"),
                new Answer("364", false, "d"),
            };

            questionsLevelOne.Add(questionThree);

            Question questionFour = new Question();
            questionFour.Sentence = "¿Cuáles son los colores de la bandera de Colombia?";
            questionFour.Level = 1;
            questionFour.Answers = new List<Answer>
            {
                new Answer("Amarillo y Rojo", false, "a"),
                new Answer("Amarillo, Azúl y Rojo", true, "b"),
                new Answer("Rojo y Blanco", false, "c"),
                new Answer("Rojo", false, "d"),
            };

            questionsLevelOne.Add(questionFour);

            Question questionFive = new Question();
            questionFive.Sentence = "¿Cuál es el transporte más seguro del mundo?";
            questionFive.Level = 1;
            questionFive.Answers = new List<Answer>
            {
                new Answer("Avión", true, "a"),
                new Answer("Carro", false, "b"),
                new Answer("Tren", false, "c"),
                new Answer("Moto", false, "d"),
            };

            questionsLevelOne.Add(questionFive);

            return questionsLevelOne;
        }

        /// <summary>
        /// Fill the questionsLevelTwo object
        /// </summary>
        /// <returns> questions by level 2 </returns>
        public static List<Question> CreateQuestionsForLevelTwo()
        {
            List<Question> questionsLevelTwo = new List<Question>();
            Question questionOne = new Question();
            questionOne.Sentence = "¿Quién fue el fundador de Facebook?";
            questionOne.Level = 2;
            questionOne.Answers = new List<Answer>
            {
                new Answer("Elon Musk", false, "a"),
                new Answer("Mark Zuckerberg", true, "b"),
                new Answer("Bill Gates", false, "c"),
                new Answer("Steve Jobs", false, "d"),
            };

            questionsLevelTwo.Add(questionOne);

            Question questionTwo = new Question();
            questionTwo.Sentence = "¿Cuál es la capital de Brasil?";
            questionTwo.Level = 2;
            questionTwo.Answers = new List<Answer>
            {
                new Answer("Brasilia", true, "a"),
                new Answer("Sao Paulo", false, "b"),
                new Answer("Rio de Janeiro", false, "c"),
                new Answer("PortoAlegre", false, "d"),
            };

            questionsLevelTwo.Add(questionTwo);

            Question questionThree = new Question();
            questionThree.Sentence = "¿Cuál es la montaña más alta del mundo?";
            questionThree.Level = 2;
            questionThree.Answers = new List<Answer>
            {
                new Answer("Everest", true, "a"),
                new Answer("Machu Picchu", false, "b"),
                new Answer("El picacho", false, "c"),
                new Answer("El Kilimanyaru", false, "d"),
            };

            questionsLevelTwo.Add(questionThree);

            Question questionFour = new Question();
            questionFour.Sentence = "¿Qién fue Gabriel Garcia Marquez?";
            questionFour.Level = 2;
            questionFour.Answers = new List<Answer>
            {
                new Answer("Un Piloto", false, "a"),
                new Answer("Un Cantante", false, "b"),
                new Answer("Un Politico", false, "c"),
                new Answer("Un Escritor", true, "d"),
            };

            questionsLevelTwo.Add(questionFour);

            Question questionFive = new Question();
            questionFive.Sentence = "¿En qué país se encuentra la torre Eiffel?";
            questionFive.Level = 2;
            questionFive.Answers = new List<Answer>
            {
                new Answer("Francia", true, "a"),
                new Answer("España", false, "b"),
                new Answer("Colombia", false, "c"),
                new Answer("Venezuela", false, "d"),
            };

            questionsLevelTwo.Add(questionFive);

            return questionsLevelTwo;
        }

        /// <summary>
        /// Fill the questionsLevelThree object
        /// </summary>
        /// <returns> questions by level 3 </returns>
        public static List<Question> CreateQuestionsForLevelThree()
        {
            List<Question> questionsLevelThree = new List<Question>();
            Question questionOne = new Question();
            questionOne.Sentence = "¿Quién escribió la odisea?";
            questionOne.Level = 3;
            questionOne.Answers = new List<Answer>
            {
                new Answer("Homero", true, "a"),
                new Answer("William Shakespeare", false, "b"),
                new Answer("Gabriel Garcia Marquez", false, "c"),
                new Answer("Paulo Cohelo", false, "d"),
            };

            questionsLevelThree.Add(questionOne);

            Question questionTwo = new Question();
            questionTwo.Sentence = "¿Quién es el rey del rock?";
            questionTwo.Level = 3;
            questionTwo.Answers = new List<Answer>
            {
                new Answer("Michael Jackson", false, "a"),
                new Answer("Elvis Presley", true, "b"),
                new Answer("Juanes", false, "c"),
                new Answer("The Beatles", false, "d"),
            };

            questionsLevelThree.Add(questionTwo);

            Question questionThree = new Question();
            questionThree.Sentence = "¿En qué país queda el Taj Mahal?";
            questionThree.Level = 3;
            questionThree.Answers = new List<Answer>
            {
                new Answer("Indonesia", false, "a"),
                new Answer("Rusia", false, "b"),
                new Answer("Ucrania", false, "c"),
                new Answer("India", true, "d"),
            };

            questionsLevelThree.Add(questionThree);

            Question questionFour = new Question();
            questionFour.Sentence = "¿Qué deporte práctica Roger Federer?";
            questionFour.Level = 3;
            questionFour.Answers = new List<Answer>
            {
                new Answer("Golf", false, "a"),
                new Answer("Tejo", false, "b"),
                new Answer("Tenis", true, "c"),
                new Answer("Baloncesto", false, "d"),
            };

            questionsLevelThree.Add(questionFour);

            Question questionFive = new Question();
            questionFive.Sentence = "¿Quién sabía que no sabía nada?";
            questionFive.Level = 3;
            questionFive.Answers = new List<Answer>
            {
                new Answer("Sócrates", false, "a"),
                new Answer("Platón", true, "b"),
                new Answer("Descartes", false, "c"),
                new Answer("Aristoteles", false, "d"),
            };

            questionsLevelThree.Add(questionFive);

            return questionsLevelThree;
        }

        /// <summary>
        /// Fill the questionsLevelFour object
        /// </summary>
        /// <returns> questions by level 4 </returns>
        public static List<Question> CreateQuestionsForLevelFour()
        {
            List<Question> questionsLevelFour = new List<Question>();
            Question questionOne = new Question();
            questionOne.Sentence = "¿Cuántos huesos tiene el cuerpo humano?";
            questionOne.Level = 4;
            questionOne.Answers = new List<Answer>
            {
                new Answer("210", false, "a"),
                new Answer("206", true, "b"),
                new Answer("150", false, "c"),
                new Answer("170", false, "d"),
            };

            questionsLevelFour.Add(questionOne);

            Question questionTwo = new Question();
            questionTwo.Sentence = "¿Qué es un lustro?";
            questionTwo.Level = 4;
            questionTwo.Answers = new List<Answer>
            {
                new Answer("5 años", true, "a"),
                new Answer("50 años", false, "b"),
                new Answer("Un calendario", false, "c"),
                new Answer("Un limpia botas", false, "d"),
            };

            questionsLevelFour.Add(questionTwo);

            Question questionThree = new Question();
            questionThree.Sentence = "¿Cuántas semanas tiene un año?";
            questionThree.Level = 4;
            questionThree.Answers = new List<Answer>
            {
                new Answer("45", false, "a"),
                new Answer("50", false, "b"),
                new Answer("21", false, "c"),
                new Answer("52", true, "d"),
            };

            questionsLevelFour.Add(questionThree);

            Question questionFour = new Question();
            questionFour.Sentence = "¿Qué es un oviparo?";
            questionFour.Level = 4;
            questionFour.Answers = new List<Answer>
            {
                new Answer("Un animal que come huevos", false, "a"),
                new Answer("Un animal volador", false, "b"),
                new Answer("Un animal que nace de un huevo", true, "c"),
                new Answer("Una tipo de árbol", false, "d"),
            };

            questionsLevelFour.Add(questionFour);

            Question questionFive = new Question();
            questionFive.Sentence = "¿En qué año murió Steve Jobs?";
            questionFive.Level = 4;
            questionFive.Answers = new List<Answer>
            {
                new Answer("2021", false, "a"),
                new Answer("2010", false, "b"),
                new Answer("2011", true, "c"),
                new Answer("2008", false, "d"),
            };

            questionsLevelFour.Add(questionFive);

            return questionsLevelFour;
        }

        /// <summary>
        /// Fill the questionsLevelFive object
        /// </summary>
        /// <returns> questions by level 5 </returns>
        public static List<Question> CreateQuestionsForLevelFive()
        {
            List<Question> questionsLevelFive = new List<Question>();
            Question questionOne = new Question();
            questionOne.Sentence = "¿En qué año terminó la segunda guerra mundial?";
            questionOne.Level = 5;
            questionOne.Answers = new List<Answer>
            {
                new Answer("1945", true, "a"),
                new Answer("1943", false, "b"),
                new Answer("1950", false, "c"),
                new Answer("1955", false, "d"),
            };

            questionsLevelFive.Add(questionOne);

            Question questionTwo = new Question();
            questionTwo.Sentence = "¿Cuál es el disco más vendido de la historia?";
            questionTwo.Level = 5;
            questionTwo.Answers = new List<Answer>
            {
                new Answer("Thriller", true, "a"),
                new Answer("Black Album", false, "b"),
                new Answer("The dark side of the moon", false, "c"),
                new Answer("Back in black", false, "d"),
            };

            questionsLevelFive.Add(questionTwo);

            Question questionThree = new Question();
            questionThree.Sentence = "¿Cuál es la capital de Croacia?";
            questionThree.Level = 5;
            questionThree.Answers = new List<Answer>
            {
                new Answer("Zagreb", true, "a"),
                new Answer("Zadar", false, "b"),
                new Answer("Pula", false, "c"),
                new Answer("Ragusa", false, "d"),
            };

            questionsLevelFive.Add(questionThree);

            Question questionFour = new Question();
            questionFour.Sentence = "¿Cuál es la pélicula más taquillera de la historia?";
            questionFour.Level = 5;
            questionFour.Answers = new List<Answer>
            {
                new Answer("Avengers Endgame", false, "a"),
                new Answer("Titanic", false, "b"),
                new Answer("Avatar", true, "c"),
                new Answer("Jurassic World", false, "d"),
            };

            questionsLevelFive.Add(questionFour);

            Question questionFive = new Question();
            questionFive.Sentence = "¿En qué año llegó el ser humano a la luna?";
            questionFive.Level = 5;
            questionFive.Answers = new List<Answer>
            {
                new Answer("1968", false, "a"),
                new Answer("1967", false, "b"),
                new Answer("1969", true, "c"),
                new Answer("1970", false, "d"),
            };

            questionsLevelFive.Add(questionFive);

            return questionsLevelFive;
        }
    }
}
