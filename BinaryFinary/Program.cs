

bool[] eightBitArray = { true, false, false, true, false, true, false, true };

string b = BoolArrayToString(eightBitArray);
Console.WriteLine("8bit boolean array as binary: {0}", b);
int i = BinaryByteToInteger(b);
Console.Write("8bit binary as decimal: {0}", i);

static string BoolArrayToString(bool[] array)
{
    string output = "";
    foreach (bool bit in array)
    {

        if (bit) { output += "1"; } else { output += "0"; }
    }
    return output;

}

static int BinaryByteToInteger(string s)
{
    int num = 0;
    int bits = s.Length;

    for (int i = 0; i < bits; i++)
    {
        switch (i)
        {
            case 0:
                if (s[i].Equals('1')) { num += (int)Math.Pow(2, bits-i-1); }
                break;
            case 1:
                if (s[i].Equals('1')) { num += (int)Math.Pow(2, bits-i-1); }
                break;
            case 2:
                if (s[i].Equals('1')) { num += (int)Math.Pow(2, bits-i-1); }
                break;
            case 3:
                if (s[i].Equals('1')) { num += (int)Math.Pow(2, bits-i-1); }
                break;
            case 4:
                if (s[i].Equals('1')) { num += (int)Math.Pow(2, bits-i-1); }
                break;
            case 5:
                if (s[i].Equals('1')) { num += (int)Math.Pow(2, bits-i-1); }
                break;
            case 6:
                if (s[i].Equals('1')) { num += (int)Math.Pow(2, bits-i-1); }
                break;
            case 7:
                if (s[i].Equals('1')) { num += (int)Math.Pow(2, bits-i-1); }
                break;
        }
    }

    return num;
}

