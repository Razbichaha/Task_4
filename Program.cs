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
            for (int i=0;i<=messagesToUser.Length-1;i++)
            {
                if (i != 0)
                {
                    Console.WriteLine(messagesToUser[i]+mark);
                    // Console.ReadLine();
                    answer = answer + templateAnswer[i-1]+" - " + Console.ReadLine()+". ";
                answer = answer + " ";
                }
                else
                {
                Console.WriteLine(messagesToUser[i]);
                Console.ReadLine();
                }
            }

            Console.WriteLine(answer);
            Console.ReadLine();
        }



    }
}
