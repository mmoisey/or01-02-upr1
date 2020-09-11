using System;

namespace or01_02_upr1
{
  class Prog //rpof
  {
    static void Main(string[] args)
    {
      SByte a = 0;
      Byte b = 0;
      Int16 c = 0;
      Int32 d = 0;
      Int64 e = 0;
      string s = "";
      Exception ex = new Exception();
      object[] types = { a, b, c, d, e, s, ex };
      foreach (object i in types)
      {
        string type;
        if (i.GetType().IsValueType) type = "Value type";
        else
          type = "Reference Type";
        Console.WriteLine("{0}: {1}", i.GetType(), type);
      }
    }
  }
}


