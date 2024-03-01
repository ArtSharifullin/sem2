//Использование очереди (распределение букв и цифр по разным очередям)

/*LinkedList.Queue<char> let = new LinkedList.Queue<char> ();
LinkedList.Queue<int> num = new LinkedList.Queue<int> ();

string s = "skdnodsouh3ie02ru32320oj32ufu329u23kf32";
foreach (char ch in s)
{
    if (Char.IsLetter (ch)) { let.Enqueue(ch); }
    else
    {
         num.Enqueue (ch);
    }
}

Console.WriteLine (let);
Console.WriteLine (num);
*/

LinkedList.MasQueue<int> m = new LinkedList.MasQueue<int>(5);
for (int i = 15; i< 20; i++)
{
    m.Enqueue(i);
}
m.PrintQueue();
m.Dequeue();
m.Enqueue(0);
m.Enqueue(1);
m.PrintQueue();







