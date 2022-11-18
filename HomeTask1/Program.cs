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

void PlusLine()
{
    for (int i = 0; i < RanNum * 2 + 4; i++)
    {
        Console.Write("+"); 
    }
}
#endregion
    string Space = new(' ', Text.Length);
FirstString();

void FirstString()
{
    PlusLine();
    //Console.WriteLine(Space);
        Console.WriteLine();
    for (int i = 0; i < RanNum * 2 ; i++)
    {
            Console.WriteLine('+' + new string(' ', RanNum) 
            + (i == RanNum  ? Text : Space ) 
            + new string(' ', RanNum) + '+');
    }
    PlusLine();
}
