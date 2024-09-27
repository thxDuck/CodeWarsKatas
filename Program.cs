Console.Clear();


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
// PaperworkKata();


/******************************************************************************/

// Clock shows h hours, m minutes and s seconds after midnight.
// Your task is to write a function which returns the time since midnight in milliseconds.
Clock();
static void Clock()
{
    int miliSecondsSinceMidnight = Past(0, 1, 1);
    const int result = 61000;
    if (miliSecondsSinceMidnight.Equals(result)) Console.WriteLine("Success !");
    else Console.WriteLine("Fail !");
    static int Past(int h, int m, int s)
    {
        const int secondToMs = 1000;
        const int minuteToMs = secondToMs * 60;
        const int hourToMs = minuteToMs * 60;

        return h * hourToMs + m * minuteToMs + s * secondToMs;
    }
}

/******************************************************************************/
SpacesRemover();
static void SpacesRemover()
{
    (string, string) test_1 = ("8 j 8   mBliB8g  imjB8B8  jl  B", "8j8mBliB8gimjB8B8jlB");
    (string, string) test_2 = ("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd", "88Bifk8hB8BB8BBBB888chl8BhBfd");
    (string, string) test_3 = ("8aaaaa dddd r     ", "8aaaaaddddr");

    if (NoSpace(test_1.Item1).Equals(test_1.Item2)) Console.WriteLine("Success !");
    else Console.WriteLine($"Fail, result should be {test_1.Item2}");

    if (NoSpace(test_2.Item1).Equals(test_2.Item2)) Console.WriteLine("Success !");
    else Console.WriteLine($"Fail, result should be {test_1.Item2}");

    if (NoSpace(test_3.Item1).Equals(test_3.Item2)) Console.WriteLine("Success !");
    else Console.WriteLine($"Fail, result should be {test_1.Item2}");

    static string NoSpace(string input) => input.Replace(" ", "");
}