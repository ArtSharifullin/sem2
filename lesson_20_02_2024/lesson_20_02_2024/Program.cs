LinkedList.Queue<char> let = new LinkedList.Queue<char> ();
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








