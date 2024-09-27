
// Your classmates asked you to copy some paperwork for them. 
// You know that there are 'n' classmates and the paperwork has 'm' pages.
// Your task is to calculate how many blank pages do you need. If n < 0 or m < 0 return 0.
static void PaperworkKata()
{

    if (Paperwork(5, -5).Equals(0)) Console.WriteLine("Success !");
    else Console.WriteLine("Fail");

    if (Paperwork(-5, -5).Equals(0)) Console.WriteLine("Success !");
    else Console.WriteLine("Fail");

    if (Paperwork(5, 5).Equals(25)) Console.WriteLine("Success !");
    else Console.WriteLine($"Fail : {Paperwork(5, 5).Equals(25)}");

    if (Paperwork(10, 5).Equals(50)) Console.WriteLine("Success !");
    else Console.WriteLine("Fail");

    static int Paperwork(int n, int m) => (n > 0 && m > 0) ? n * m : 0;
}
PaperworkKata();