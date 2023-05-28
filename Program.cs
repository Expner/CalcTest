string expression = Console.ReadLine();
string[] massive_Char_expression = expression.Split(new char[] { ' ' });
string[] expression_after = new string[massive_Char_expression.Length];

int var_plus = 0, // +
    var_minus = 0, // -
    var_mult = 0, // *
    var_div = 0; // /

foreach (char s in expression) // перебираем выражение и считаем знаки в строке
{
    if (s == '+') var_plus++;
    if (s == '-') var_minus++;
    if (s == '*') var_mult++;
    if (s == '/') var_div++;
}

string str_all = ""; // создаем строку в которой определим знаки из примера по иерархии
string str_mult = new string('*', var_mult);
string str_div = new string('/', var_div);
string str_plus = new string('+', var_plus);
string str_minus = new string('-', var_minus);
str_all = str_mult + str_div + str_plus + str_minus;

foreach (char s in str_all) 
{
    switch (s)
    {
        case '*':
            Array.Resize(ref expression_after, massive_Char_expression.Length - 2);
            Array.Copy(massive_Char_expression, 0, expression_after, 0, Array.IndexOf(massive_Char_expression, "*") - 1);
            expression_after[Array.IndexOf(massive_Char_expression, "*") - 1] = Convert.ToString(Convert.ToInt32(massive_Char_expression[Array.IndexOf(massive_Char_expression, "*") - 1]) * Convert.ToInt32(massive_Char_expression[Array.IndexOf(massive_Char_expression, "*") + 1]));
            Array.Copy(massive_Char_expression, Array.IndexOf(massive_Char_expression, "*") + 2, expression_after, Array.IndexOf(massive_Char_expression, "*"), expression_after.Length - Array.IndexOf(massive_Char_expression, "*"));
            Array.Resize(ref massive_Char_expression, massive_Char_expression.Length - 2);
            Array.Copy(expression_after, 0, massive_Char_expression, 0, expression_after.Length);
            break;

        case '/':
            Array.Resize(ref expression_after, massive_Char_expression.Length - 2);
            Array.Copy(massive_Char_expression, 0, expression_after, 0, Array.IndexOf(massive_Char_expression, "/") - 1);
            expression_after[Array.IndexOf(massive_Char_expression, "/") - 1] = Convert.ToString(Convert.ToInt32(massive_Char_expression[Array.IndexOf(massive_Char_expression, "/") - 1]) / Convert.ToInt32(massive_Char_expression[Array.IndexOf(massive_Char_expression, "/") + 1]));
            Array.Copy(massive_Char_expression, Array.IndexOf(massive_Char_expression, "/") + 2, expression_after, Array.IndexOf(massive_Char_expression, "/"), expression_after.Length - Array.IndexOf(massive_Char_expression, "/"));
            Array.Resize(ref massive_Char_expression, massive_Char_expression.Length - 2);
            Array.Copy(expression_after, 0, massive_Char_expression, 0, expression_after.Length);
            break;

        case '+':
            Array.Resize(ref expression_after, massive_Char_expression.Length - 2);
            Array.Copy(massive_Char_expression, 0, expression_after, 0, Array.IndexOf(massive_Char_expression, "+") - 1);
            expression_after[Array.IndexOf(massive_Char_expression, "+") - 1] = Convert.ToString(Convert.ToInt32(massive_Char_expression[Array.IndexOf(massive_Char_expression, "+") - 1]) + Convert.ToInt32(massive_Char_expression[Array.IndexOf(massive_Char_expression, "+") + 1]));
            Array.Copy(massive_Char_expression, Array.IndexOf(massive_Char_expression, "+") + 2, expression_after, Array.IndexOf(massive_Char_expression, "+"), expression_after.Length - Array.IndexOf(massive_Char_expression, "+"));
            Array.Resize(ref massive_Char_expression, massive_Char_expression.Length - 2);
            Array.Copy(expression_after, 0, massive_Char_expression, 0, expression_after.Length);
            break;
            break;

        case '-':
            Array.Resize(ref expression_after, massive_Char_expression.Length - 2);
            Array.Copy(massive_Char_expression, 0, expression_after, 0, Array.IndexOf(massive_Char_expression, "-") - 1);
            expression_after[Array.IndexOf(massive_Char_expression, "-") - 1] = Convert.ToString(Convert.ToInt32(massive_Char_expression[Array.IndexOf(massive_Char_expression, "-") - 1]) - Convert.ToInt32(massive_Char_expression[Array.IndexOf(massive_Char_expression, "-") + 1]));
            Array.Copy(massive_Char_expression, Array.IndexOf(massive_Char_expression, "-") + 2, expression_after, Array.IndexOf(massive_Char_expression, "-"), expression_after.Length - Array.IndexOf(massive_Char_expression, "-"));
            Array.Resize(ref massive_Char_expression, massive_Char_expression.Length - 2);
            Array.Copy(expression_after, 0, massive_Char_expression, 0, expression_after.Length);
            break;
            break;
    }
}
Console.WriteLine(expression_after[0]);