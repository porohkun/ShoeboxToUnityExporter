using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeBoxToUnityExporter
{
    public struct ShoeChar
    {
        public int Id;
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public int XOffset;
        public int YOffset;
        public int XAdvance;
        public int Page;
        public int Chnl;

        public ShoeChar(string line)
        {
            Id = 0;
            X = 0;
            Y = 0;
            Width = 0;
            Height = 0;
            XOffset = 0;
            YOffset = 0;
            XAdvance = 0;
            Page = 0;
            Chnl = 0;
            string[] words = line.Split(' ');
            if (words[0] != "char")
                throw new FormatException();

            for (int i = 1; i < 10; i++)
            {
                string[] kv = words[i].Split('=');
                string key = kv[0];
                int val = int.Parse(kv[1]);

                switch (key)
                {
                    case "id": Id = val; break;
                    case "x": X = val; break;
                    case "y": Y = val; break;
                    case "width": Width = val; break;
                    case "height": Height = val; break;
                    case "xoffset": XOffset = val; break;
                    case "yoffset": YOffset = val; break;
                    case "xadvance": XAdvance = val; break;
                    case "page": Page = val; break;
                    case "chnl": Chnl = val; break;
                }
            }
        }
    }
}
