using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
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
