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
    int cont = 1;
    string convertedText = "";

    for (int i = 0; i < textToConvert.Length; i++)
    {
        if (textToConvert.Substring(i, cont) == BinaryAlphabet.A.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.A;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.a.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.a;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.B.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.B;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.b.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.b;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.C.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.C;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.c.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.c;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.D.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.D;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.d.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.d;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.E.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.E;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.e.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.e;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.F.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.F;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.f.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.f;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.G.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.G;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.g.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.g;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.H.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.H;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.h.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.h;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.I.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.I;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.i.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.i;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.J.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.J;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.j.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.j;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.K.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.K;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.k.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.k;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.L.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.L;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.l.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.l;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.M.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.m;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.m.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.m;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.N.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.N;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.n.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.n;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.O.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.O;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.o.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.o;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.P.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.P;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.p.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.p;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.Q.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.Q;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.q.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.q;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.R.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.R;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.r.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.r;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.S.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.S;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.s.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.s;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.T.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.T;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.t.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.t;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.U.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.U;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.u.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.u;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.V.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.V;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.v.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.v;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.W.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.W;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.w.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.w;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.X.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.X;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.x.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.x;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.Y.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.Y;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.y.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.y;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.Z.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.Z;
        }
        else if (textToConvert.Substring(i, cont) == BinaryAlphabet.z.ToString())
        {
            convertedText += " " + (int)BinaryAlphabet.z;
        }
        else if (textToConvert.Substring(i, cont) == " ")
        {
            convertedText += " 00100000 ";
        }
    }

    return convertedText.Remove(0, 1);
}

//Enum that relates the alphabetic value to the binary code.
enum BinaryAlphabet
{
    A = 01000001,
    a = 01100001,
    B = 01000010,
    b = 01100010,
    C = 01000011,
    c = 01100011,
    D = 01000100,
    d = 01100100,
    E = 01000101,
    e = 01100101,
    F = 01000110,
    f = 01100110,
    G = 01000111,
    g = 01100111,
    H = 01001000,
    h = 01101000,
    I = 01001001,
    i = 01101001,
    J = 01001010,
    j = 01101010,
    K = 01001011,
    k = 01101011,
    L = 01001100,
    l = 01101100,
    M = 01001101,
    m = 01101101,
    N = 01001110,
    n = 01101110,
    O = 01001111,
    o = 01101111,
    P = 01010000,
    p = 01110000,
    Q = 01010001,
    q = 01110001,
    R = 01010010,
    r = 01110010,
    S = 01010011,
    s = 01110011,
    T = 01010100,
    t = 01110100,
    U = 01010101,
    u = 01110101,
    V = 01010110,
    v = 01110110,
    W = 01010111,
    w = 01110111,
    X = 01011000,
    x = 01111000,
    Y = 01011001,
    y = 01111001,
    Z = 01011010,
    z = 01111010
}