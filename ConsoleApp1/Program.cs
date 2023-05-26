Random random = new Random();
Console.WriteLine("Введите длину пароля: ");
int n = int.Parse(Console.ReadLine());
string[] arr = {"1", "2" , "3", "4", "5", "6", "7", "8", "9",
    "A" ,"B" ,"C" ,"D" ,"E" ,"F" ,"G" ,"H" ,"I" ,"J" ,
    "K" ,"L" ,"M" ,"N" ,"O" ,"P" ,"Q" ,"R" ,"S" ,"T" ,
    "Y" ,"V" ,"W" ,"X" ,"U" ,"Z" ,"a" ,"b" ,"c" ,"d" ,
    "e" ,"f" ,"g" ,"h" ,"i" ,"j" ,"k" ,"l" ,"m" ,"n" ,
    "o" ,"p" ,"q" ,"r" ,"s" ,"t" ,"y" ,"v" ,"w" ,"x" ,"u" ,"z"};
string PassKey = "";
int Q = n % 5;
Random rnd = new Random();
int lng = arr.Length;
for (int i = 0; i < n; i++)
{
    PassKey = PassKey + arr[random.Next(lng)];
}
Console.WriteLine(PassKey);