using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вас зовут Алексей, вам 21 год, вы водолей и работаете на заводе.

            

            string[] messagesToUser = { "Привет \nСейчас вам будет заданно несколько вопросов. \nПосле ввода ответа нажмите клавишу Enter. ", "Вас зовут", "Сколько вам лет", "Каков ваш знак зодиака", "Где вы работаете" };
            string[] templateAnswer = { "Вас зовут", "Ваш возраст", "Вы родились под знаком зодиака", "Вы работаете" };
            //string work = "Где вы работаете";
            string mark = " ?";
         
            string answer = "";
            {
                if (i != 0)
                {
                    // Console.ReadLine();
                    answer = answer + templateAnswer[i-1]+" - " + Console.ReadLine()+". ";
                answer = answer + " ";
                }
                else
                {
                Console.ReadLine();
                }
            }

            Console.WriteLine(answer);
            Console.ReadLine();
        }



    }
}
