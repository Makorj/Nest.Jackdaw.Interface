using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace Jackdaw
{
    [Serializable]
    class BuildInterface
    {
        [Serializable]
        public struct Settings
        {
            public string Name { get; set; }
            public bool Active { get; set; }
            public int Target { get; set; }
            public int Group { get; set; }
            public Symbol[] symbols { get; set; }
            public string Path { get; set; }
            public string Filename { get; set; }
            public bool Zip { get; set; }
            public bool UnityLogo { get; set; }
            public bool Sign { get; set; }

            public string Version { get; set; }
            public string AppID { get; set; }
            public int ReleaseNumber { get; set; }
        }

        public Settings[] Builds { get; set; }

        [Serializable]
        public struct Symbol
        {
            public bool Active { get; set; }
            public string Name { get; set; }
        }

        public Symbol[] GeneralSymbols { get; set; }

        public List<string> BuildPlatformForAssetBundles { get; set; }

        public bool Master { get; set; }
        public bool ScriptDebugging { get; set; }
        public bool LZ4Compression { get; set; }
        public string CodesignID { get; set; }
    }

    public static class BuildHelper
    {
        public static void Compress(string src, string dst)
        {
            ZipFile.CreateFromDirectory(src, dst, CompressionLevel.Optimal, false);
        }
    }
}
