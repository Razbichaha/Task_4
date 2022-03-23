using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вас зовут Алексей, вам 21 год, вы водолей и работаете на заводе.

            

<<<<<<<<< Temporary merge branch 1
            string[] age = { "Привет \nСейчас вам будет заданно несколько вопросов. \nПосле ввода ответа нажмите клавишу Enter. ", "Вас зовут", "Сколько вам лет", "Каков ваш знак зодиака", "Где вы работаете" };
=========
            string[] messagesToUser = { "Привет \nСейчас вам будет заданно несколько вопросов. \nПосле ввода ответа нажмите клавишу Enter. ", "Вас зовут", "Сколько вам лет", "Каков ваш знак зодиака", "Где вы работаете" };
>>>>>>>>> Temporary merge branch 2
            string[] templateAnswer = { "Вас зовут", "Ваш возраст", "Вы родились под знаком зодиака", "Вы работаете" };
            //string work = "Где вы работаете";
            string mark = " ?";
         
            string answer = "";
            Console.WriteLine("Привет \nСейчас вам будет заданно несколько вопросов. \nПосле ввода ответа нажмите клавишу Enter. ");
            Console.ReadLine();
            Console.WriteLine("Вас зовут ?");
            answer = "Вас зовут - " + Console.ReadLine()+". ";
            Console.WriteLine("Сколько вам лет ?");
            answer = answer +"Ваш возраст - "+ Console.ReadLine()+". ";
            Console.WriteLine("Каков ваш знак зодиака ?");
            answer = answer + "Вы родились под знаком зодиака - " + Console.ReadLine() + ". ";
            Console.WriteLine("Где вы работаете");
            answer = answer +  "Вы работаете - " + Console.ReadLine() + ". ";
            Console.WriteLine(answer);
            Console.ReadLine();
        }



    }
}
