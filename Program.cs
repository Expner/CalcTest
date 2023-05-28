string example = "";
example = Console.ReadLine();
string[] ex = example.Split(new char[] { ' ' });
int q = 0, // +
    w = 0, // -
    e = 0, // *
    r = 0; // /
foreach (char s in example)
{
    if (s == '+') q++;
    if (s == '-') w++;
    if (s == '*') e++;
    if (s == '/') r++;
}
string p = "";
string p0 = new string('*', e);
string p1 = new string('/', r);
string p2 = new string('+', q);
string p3 = new string('-', w);
p = p0 + p1 + p2 + p3;
//God is ashamed of me.... sorted char by hierarchy
string[] w1 = new string[ex.Length];
foreach (char s in p)
{
    switch (s)
    {
        case '*':
            Array.Resize(ref w1, ex.Length - 2);
            Array.Copy(ex, 0, w1, 0, Array.IndexOf(ex, "*") - 1);
            w1[Array.IndexOf(ex, "*") - 1] = Convert.ToString(Convert.ToInt32(ex[Array.IndexOf(ex, "*") - 1]) * Convert.ToInt32(ex[Array.IndexOf(ex, "*") + 1]));
            Array.Copy(ex, Array.IndexOf(ex, "*") + 2, w1, Array.IndexOf(ex, "*"), w1.Length - Array.IndexOf(ex, "*"));
            Array.Resize(ref ex, ex.Length - 2);
            Array.Copy(w1, 0, ex, 0, w1.Length);
            break;

        case '/':
            Array.Resize(ref w1, ex.Length - 2);
            Array.Copy(ex, 0, w1, 0, Array.IndexOf(ex, "/") - 1);
            w1[Array.IndexOf(ex, "/") - 1] = Convert.ToString(Convert.ToInt32(ex[Array.IndexOf(ex, "/") - 1]) / Convert.ToInt32(ex[Array.IndexOf(ex, "/") + 1]));
            Array.Copy(ex, Array.IndexOf(ex, "/") + 2, w1, Array.IndexOf(ex, "/"), w1.Length - Array.IndexOf(ex, "/"));
            Array.Resize(ref ex, ex.Length - 2);
            Array.Copy(w1, 0, ex, 0, w1.Length);
            break;

        case '+':
            Array.Resize(ref w1, ex.Length - 2);
            Array.Copy(ex, 0, w1, 0, Array.IndexOf(ex, "+") - 1);
            w1[Array.IndexOf(ex, "+") - 1] = Convert.ToString(Convert.ToInt32(ex[Array.IndexOf(ex, "+") - 1]) + Convert.ToInt32(ex[Array.IndexOf(ex, "+") + 1]));
            Array.Copy(ex, Array.IndexOf(ex, "+") + 2, w1, Array.IndexOf(ex, "+"), w1.Length - Array.IndexOf(ex, "+"));
            Array.Resize(ref ex, ex.Length - 2);
            Array.Copy(w1, 0, ex, 0, w1.Length);
            break;

        case '-':
            Array.Resize(ref w1, ex.Length - 2);
            Array.Copy(ex, 0, w1, 0, Array.IndexOf(ex, "-") - 1);
            w1[Array.IndexOf(ex, "-") - 1] = Convert.ToString(Convert.ToInt32(ex[Array.IndexOf(ex, "-") - 1]) - Convert.ToInt32(ex[Array.IndexOf(ex, "-") + 1]));
            Array.Copy(ex, Array.IndexOf(ex, "-") + 2, w1, Array.IndexOf(ex, "-"), w1.Length - Array.IndexOf(ex, "-"));
            Array.Resize(ref ex, ex.Length - 2);
            Array.Copy(w1, 0, ex, 0, w1.Length);
            break;
    }
}
Console.WriteLine(w1[0]);