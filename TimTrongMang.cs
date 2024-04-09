string[] myStudent = { "Mai", "An", "Hao", "Hoang" };
System.Console.WriteLine("Nhap ten");
string name = Console.ReadLine();

bool availble = false;
for (int i = 0; i < myStudent.Length; i++)
{
    if (myStudent[i].Equals(name))
    {
        System.Console.WriteLine("Co trong lop");
        availble = true;
        break;
    }
    if (!availble)
    {
        System.Console.WriteLine("Khong co trong lop");
    }
}