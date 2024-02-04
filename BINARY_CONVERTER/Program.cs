using System.Text;

bool whileTrueFalse = true;

while (whileTrueFalse)
{
    InitialSettings();

    var keyOneTwoOrThree = Console.ReadLine();

    switch (keyOneTwoOrThree)
    {
        case "1":
            StringTranslation();
            break;
        case "2":
            FileTranslation();
            break;
        case "3":
            whileTrueFalse = false;
            break;
        default:
            Console.WriteLine("The chosen option is not among those requested, try again!");
            break;
    }
}

//Initial console settings.
static void InitialSettings()
{
    Console.Title = "Binary Converter";
    Console.WindowWidth = 80;
    Console.WindowHeight = 30;
    Console.BufferWidth = 80;
    Console.BufferHeight = 30;
    Console.SetWindowSize(80, 30);
    Console.SetWindowSize(80, 30);
    Console.SetWindowPosition(0, 0);

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("Welcome to the text to binary converter!");
    Console.WriteLine();
    Console.WriteLine("If you want to add text here, type (1):");
    Console.WriteLine("If you want to enter the path of a file ('.txt'), type (2):");
    Console.WriteLine("To close the translator, type (3):");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.White;
}

//String Translation Method.
static void StringTranslation()
{
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.Clear();
    Console.WriteLine("Enter the text to be converted:");

    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine();
    var textToConvert = Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.Blue;

    Console.Clear();
    Console.WriteLine("Your translated text:");

    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine();
    Console.WriteLine(Traslation(textToConvert));

    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine();
    Console.WriteLine("Press any key to return to the beginning!");
    Console.ReadKey();
}

//File Translation Method.
static void FileTranslation()
{
    int cont = 1;
    int contBarra = 0;

    Console.ForegroundColor = ConsoleColor.Blue;

    Console.Clear();
    Console.WriteLine("Enter the path of the file (.txt) that will be converted:");

    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine();

    var pathFileConvert = Console.ReadLine();
    var textFileToConvert = File.ReadAllText(pathFileConvert);

    Console.ForegroundColor = ConsoleColor.Blue;

    Console.Clear();
    Console.WriteLine("Your translated text:");

    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine();

    for (int i = 0; i < pathFileConvert.Length; i++)
    {
        if (pathFileConvert.Substring(i, cont) == @"\")
        {
            contBarra = i;
        }
    }

    string pathFileToConvert = pathFileConvert.Remove(contBarra);

    File.WriteAllText(pathFileToConvert += @$"\Binary Translation - ({DateTime.Now.ToString("MM.dd.yyyy - HH.mm")}).txt", Traslation(textFileToConvert), Encoding.UTF8);
    Console.WriteLine("Your translated text is in this path: ");
    Console.WriteLine(pathFileToConvert);

    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine();
    Console.WriteLine("Press any key to return to the beginning!");
    Console.ReadKey();
}

//Translation method.
static string Traslation(string textToConvert)
{
    try
    {
        int cont = 1;
        StringBuilder convertedText = new StringBuilder();

        for (int i = 0; i < textToConvert.Length; i++)
        {
            char currentChar = textToConvert[i];

            switch (currentChar)
            {
                case 'A':
                    convertedText.Append(" " + (int)BinaryAlphabet.A);
                    break;
                case 'a':
                    convertedText.Append(" " + (int)BinaryAlphabet.a);
                    break;
                case 'B':
                    convertedText.Append(" " + (int)BinaryAlphabet.B);
                    break;
                case 'b':
                    convertedText.Append(" " + (int)BinaryAlphabet.b);
                    break;
                case 'C':
                    convertedText.Append(" " + (int)BinaryAlphabet.C);
                    break;
                case 'c':
                    convertedText.Append(" " + (int)BinaryAlphabet.c);
                    break;
                case 'D':
                    convertedText.Append(" " + (int)BinaryAlphabet.D);
                    break;
                case 'd':
                    convertedText.Append(" " + (int)BinaryAlphabet.d);
                    break;
                case 'E':
                    convertedText.Append(" " + (int)BinaryAlphabet.E);
                    break;
                case 'e':
                    convertedText.Append(" " + (int)BinaryAlphabet.e);
                    break;
                case 'F':
                    convertedText.Append(" " + (int)BinaryAlphabet.F);
                    break;
                case 'f':
                    convertedText.Append(" " + (int)BinaryAlphabet.f);
                    break;
                case 'G':
                    convertedText.Append(" " + (int)BinaryAlphabet.G);
                    break;
                case 'g':
                    convertedText.Append(" " + (int)BinaryAlphabet.g);
                    break;
                case 'H':
                    convertedText.Append(" " + (int)BinaryAlphabet.H);
                    break;
                case 'h':
                    convertedText.Append(" " + (int)BinaryAlphabet.h);
                    break;
                case 'I':
                    convertedText.Append(" " + (int)BinaryAlphabet.I);
                    break;
                case 'i':
                    convertedText.Append(" " + (int)BinaryAlphabet.i);
                    break;
                case 'J':
                    convertedText.Append(" " + (int)BinaryAlphabet.J);
                    break;
                case 'j':
                    convertedText.Append(" " + (int)BinaryAlphabet.j);
                    break;
                case 'K':
                    convertedText.Append(" " + (int)BinaryAlphabet.K);
                    break;
                case 'k':
                    convertedText.Append(" " + (int)BinaryAlphabet.k);
                    break;
                case 'L':
                    convertedText.Append(" " + (int)BinaryAlphabet.L);
                    break;
                case 'l':
                    convertedText.Append(" " + (int)BinaryAlphabet.l);
                    break;
                case 'M':
                    convertedText.Append(" " + (int)BinaryAlphabet.M);
                    break;
                case 'm':
                    convertedText.Append(" " + (int)BinaryAlphabet.m);
                    break;
                case 'N':
                    convertedText.Append(" " + (int)BinaryAlphabet.N);
                    break;
                case 'n':
                    convertedText.Append(" " + (int)BinaryAlphabet.n);
                    break;
                case 'O':
                    convertedText.Append(" " + (int)BinaryAlphabet.O);
                    break;
                case 'o':
                    convertedText.Append(" " + (int)BinaryAlphabet.o);
                    break;
                case 'P':
                    convertedText.Append(" " + (int)BinaryAlphabet.P);
                    break;
                case 'p':
                    convertedText.Append(" " + (int)BinaryAlphabet.p);
                    break;
                case 'Q':
                    convertedText.Append(" " + (int)BinaryAlphabet.Q);
                    break;
                case 'q':
                    convertedText.Append(" " + (int)BinaryAlphabet.q);
                    break;
                case 'R':
                    convertedText.Append(" " + (int)BinaryAlphabet.R);
                    break;
                case 'r':
                    convertedText.Append(" " + (int)BinaryAlphabet.r);
                    break;
                case 'S':
                    convertedText.Append(" " + (int)BinaryAlphabet.S);
                    break;
                case 's':
                    convertedText.Append(" " + (int)BinaryAlphabet.s);
                    break;
                case 'T':
                    convertedText.Append(" " + (int)BinaryAlphabet.T);
                    break;
                case 't':
                    convertedText.Append(" " + (int)BinaryAlphabet.t);
                    break;
                case 'U':
                    convertedText.Append(" " + (int)BinaryAlphabet.U);
                    break;
                case 'u':
                    convertedText.Append(" " + (int)BinaryAlphabet.u);
                    break;
                case 'V':
                    convertedText.Append(" " + (int)BinaryAlphabet.V);
                    break;
                case 'v':
                    convertedText.Append(" " + (int)BinaryAlphabet.v);
                    break;
                case 'W':
                    convertedText.Append(" " + (int)BinaryAlphabet.W);
                    break;
                case 'w':
                    convertedText.Append(" " + (int)BinaryAlphabet.w);
                    break;
                case 'X':
                    convertedText.Append(" " + (int)BinaryAlphabet.X);
                    break;
                case 'x':
                    convertedText.Append(" " + (int)BinaryAlphabet.x);
                    break;
                case 'Y':
                    convertedText.Append(" " + (int)BinaryAlphabet.Y);
                    break;
                case 'y':
                    convertedText.Append(" " + (int)BinaryAlphabet.y);
                    break;
                case 'Z':
                    convertedText.Append(" " + (int)BinaryAlphabet.Z);
                    break;
                case 'z':
                    convertedText.Append(" " + (int)BinaryAlphabet.z);
                    break;
                case ' ':
                    convertedText.Append(" 00100000 ");
                    break;
                case ':':
                    convertedText.Append(" 00111010 ");
                    break;
                case ',':
                    convertedText.Append(" 00101100 ");
                    break;
                case '?':
                    convertedText.Append(" 00111111 ");
                    break;
                case '/':
                    convertedText.Append(" 00101111 ");
                    break;
                case '°':
                    convertedText.Append(" 11011111 ");
                    break;
                case '<':
                    convertedText.Append(" 00111100 ");
                    break;
                case '>':
                    convertedText.Append(" 00111110 ");
                    break;
                case '{':
                    convertedText.Append(" 01111011 ");
                    break;
                case '[':
                    convertedText.Append(" 01011011 ");
                    break;
                case 'ª':
                    convertedText.Append(" 1011010 ");
                    break;
                case '}':
                    convertedText.Append(" 01111101 ");
                    break;
                case ']':
                    convertedText.Append(" 01011101 ");
                    break;
                case '=':
                    convertedText.Append(" 00111101 ");
                    break;
                case '+':
                    convertedText.Append(" 00101011 ");
                    break;
                case '_':
                    convertedText.Append(" 01011111 ");
                    break;
                case '-':
                    convertedText.Append(" 00101101 ");
                    break;
                case ')':
                    convertedText.Append(" 00101001 ");
                    break;
                case '*':
                    convertedText.Append(" 00101010 ");
                    break;
                case '&':
                    convertedText.Append(" 00100110 ");
                    break;
                case '¨':
                    convertedText.Append(" 11011100 ");
                    break;
                case '%':
                    convertedText.Append(" 00100101 ");
                    break;
                case '$':
                    convertedText.Append(" 00100100 ");
                    break;
                case '#':
                    convertedText.Append(" 00100011 ");
                    break;
                case '@':
                    convertedText.Append(" 01000000 ");
                    break;
                case '!':
                    convertedText.Append(" 00100001 ");
                    break;
                case '|':
                    convertedText.Append(" 01111101 ");
                    break;
                case '\\':
                    convertedText.Append(" 01011100 ");
                    break;
                case '¿':
                    convertedText.Append(" 00111111 ");
                    break;
                case '.':
                    convertedText.Append(" 00101110 ");
                    break;
                default:
                    convertedText.Append(" " + (int)currentChar);
                    break;
            }
        }

        return convertedText.ToString().TrimStart();
    }
    catch (Exception ex)
    {
        throw new Exception($"An error occurred during translation: {ex.Message}");
    }
}

//Enum that relates the alphabetic value to the binary code.
enum BinaryAlphabet
{
    A = 01000001, a = 01100001, B = 01000010, b = 01100010,
    C = 01000011, c = 01100011, D = 01000100, d = 01100100,
    E = 01000101, e = 01100101, F = 01000110, f = 01100110,
    G = 01000111, g = 01100111, H = 01001000, h = 01101000,
    I = 01001001, i = 01101001, J = 01001010, j = 01101010,
    K = 01001011, k = 01101011, L = 01001100, l = 01101100,
    M = 01001101, m = 01101101, N = 01001110, n = 01101110,
    O = 01001111, o = 01101111, P = 01010000, p = 01110000,
    Q = 01010001, q = 01110001, R = 01010010, r = 01110010,
    S = 01010011, s = 01110011, T = 01010100, t = 01110100,
    U = 01010101, u = 01110101, V = 01010110, v = 01110110,
    W = 01010111, w = 01110111, X = 01011000, x = 01111000,
    Y = 01011001, y = 01111001, Z = 01011010, z = 01111010,
    Space = 00100000, Colon = 00111010, Comma = 00101100,
    QuestionMark = 00111111, Slash = 00101111, Degree = 11011111,
    LessThan = 00111100, GreaterThan = 00111110, CurlyBrace = 01111011,
    SquareBracket = 01011011, FeminineOrdinalIndicator = 1011010,
    ClosingCurlyBrace = 01111101, ClosingSquareBracket = 01011101,
    Equals = 00111101, Plus = 00101011, Underscore = 01011111,
    Hyphen = 00101101, ClosingParenthesis = 00101001,
    Asterisk = 00101010, Ampersand = 00100110, Diaeresis = 11011100,
    Percent = 00100101, Dollar = 00100100, Hash = 00100011,
    At = 01000000, ExclamationMark = 00100001, SingleQuote = 00100111,
    DoubleQuote = 00100010, VerticalBar = 01111101, Backslash = 01011100,
    QuestionSlash = 00111111, AsteriskSlash = 00101010,
    HyphenSlash = 00101101, PlusSlash = 00101011, Period = 00101110
}