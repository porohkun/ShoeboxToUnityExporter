using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeBoxToUnityExporter
{
    public class FontExporter
    {
        private string _header="%YAML 1.1\n%TAG !u! tag:unity3d.com,2011:\n--- !u!128 &12800000\nFont:\n  m_ObjectHideFlags: 0\n  m_PrefabParentObject: {fileID: 0}\n  m_PrefabInternal: {fileID: 0}\n  m_Name: New Font\n  serializedVersion: 4\n  m_AsciiStartOffset: 0\n  m_Kerning: 1\n  m_LineSpacing: .100000001\n  m_CharacterSpacing: 1\n  m_CharacterPadding: 0\n  m_ConvertCase: 0\n  m_DefaultMaterial: {fileID: 0}\n  m_CharacterRects:\n";
        private string _itemTempl = "  - serializedVersion: 2\n    index: {0}\n    uv:\n      serializedVersion: 2\n      x: {1}\n      y: {2}\n      width: {3}\n      height: {4}\n    vert:\n      serializedVersion: 2\n      x: {5}\n      y: {6}\n      width: {7}\n      height: {8}\n    width: {9}\n    flipped: 0\n";
        private string _footer = "  m_Texture: {fileID: 0}\n  m_KerningValues: []\n  m_PixelScale: .100000001\n  m_FontData: \n  m_FontSize: 0\n  m_Ascent: 0\n  m_DefaultStyle: 0\n  m_FontNames: []\n  m_FallbackFonts: []\n  m_FontRenderingMode: 0\n";
        ShoeChar[] _chars;
        private string _txtFile;
        private int _width;
        private int _height;
        
        public FontExporter(string file)
        {
            _txtFile = file;
            int i = 0;
            foreach (var line in File.ReadAllLines(file))
            {
                if (i == 0 && line.Length > 5 && line.Substring(0, 6) == "common")
                {
                    var pars = line.Split(' ');
                    _width = int.Parse(pars[3].Split('=')[1]);
                    _height = int.Parse(pars[4].Split('=')[1]);
                }
                else if (_chars == null && line.Length > 4 && line.Substring(0, 5) == "chars")
                    _chars = new ShoeChar[int.Parse(line.Split('=')[1])];
                else if (line.Length > 4 && line.Substring(0, 5) == "char ")
                {
                    _chars[i] = new ShoeChar(line);
                    i++;
                }
            }
        }

        public string Export()
        {
            string file = Path.ChangeExtension(_txtFile, ".fontsettings");
            using (StreamWriter stream = new StreamWriter(File.Create(file)))
            {
                stream.Write(_header);

                foreach (var chr in _chars)
                {
                    stream.Write(string.Format(_itemTempl,
                        chr.Id,
                        (((float)chr.X) / _width).ToString(CultureInfo.InvariantCulture),
                        (1f-((float)chr.Y) / _height).ToString(CultureInfo.InvariantCulture),
                        (((float)chr.Width) / _width).ToString(CultureInfo.InvariantCulture),
                        (-((float)chr.Height) / _height).ToString(CultureInfo.InvariantCulture),
                        1,
                        0,
                        chr.Width,
                        chr.Height,
                        chr.Width+2));
                }

                stream.Write(_footer);
            }
            return file;
        }
    }
}
