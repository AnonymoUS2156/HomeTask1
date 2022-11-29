#region Enter
using System.Diagnostics.SymbolStore;

int RanNum;//целочисленная переменная 
do
{
    Console.WriteLine("Введите произвольное значение:");//надпись
    Int32.TryParse(Console.ReadLine(), out RanNum);//преобразование введенного значения в тип
} while (RanNum < 1 || RanNum > 6);//проверка введенного значения   на , где число будет повторяться бесконечно, пока не будет выполнено условие

string Text;
do
{
    Console.WriteLine("Введите произвольный текст");//надпись
    Text = Console.ReadLine();//вводимый текст
} while (Text == "");//проверка значения
int length = Text.Length + RanNum * 2;
void PlusLine()
{
    int i = 0;
    for (; i < (length) + 2; i++)
    {
        Console.Write("+");
    }
    Console.WriteLine(i);
}
#endregion
string Space = new(' ', Text.Length); //я сделал отдельную переменную для упращения кода
FirstString();
void FirstString()
{
    PlusLine();
    //Console.WriteLine(Space);

    for (int i = 1; i < RanNum * 2; i++)
    {
        Console.WriteLine('+' + new string(' ', RanNum)
        + (i == RanNum ? Text : Space)
        + new string(' ', RanNum) + '+');//проверка + вывод готового значения 
    }
    PlusLine();//вывод линии из плюсов
    SecondString();//вызов следующего метода
}
void SecondString()//создание второй строки 
{
    int num = 0;// счетчик
    for (int a = 0; a < length; a++)//создание таблицы по оси Х
    {
        Console.Write("+");//начальный столбик из плюсов
        for (int b = 0; b < (length); b++)//создание таблицы по оси Y
        {
            num++;//счетчик + 1
            if ((a + b) % 2 == 0)//проверка значения на вставку плюса
                Console.Write("+");
            else
                Console.Write(" ");//при другом варианте пропускает значение 
        }
        Console.WriteLine("+");//конечный столбик из плюсов
    }
    PlusLine();// вызов строки из плюсов
    ThirdString();//вызов следующего метода
}
void ThirdString()// Третий столбец из строчек
{
    for (int i = 0; i < (length); i++)
    {
        Console.Write("+");
        for (int j = 0; j < length; j++)
        {
            if (i == j || i == length - 1 - j)
                Console.Write("+");
            else
                Console.Write(" ");
        }
        Console.WriteLine("+");
    }
    PlusLine();
}
