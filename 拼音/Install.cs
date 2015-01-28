using System;
using System.IO;
using System.Text;

namespace 拼音
{
    public static class Install
    {
        public static void Start()
        {
            RegisterSnippets();
            RegisterSnippy();
        }

        private static void RegisterSnippets()
        {
            var home = (Environment.OSVersion.Platform == PlatformID.Unix || 
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            var snippy = home + "/.snipyin/";
            Directory.CreateDirectory(snippy);

            Console.WriteLine("created directory " + snippy);

            foreach (var v in Enum.GetNames(typeof(Tones.Vowel)))
            {
                foreach (var t in Enum.GetValues(typeof(Tones.Tone)))
                {     
                    var vowel = (Tones.Vowel)Enum.Parse(typeof(Tones.Vowel), v, false);
                    var tone = (Tones.Tone)Enum.Parse(typeof(Tones.Tone), ((int)t).ToString(), false);
                    var toneNo = ((int)t).ToString();
                    toneNo = toneNo.Replace("t", String.Empty);
                    var replace = Tones.GetVowel(vowel, tone).ToString();
                    File.WriteAllText(snippy + v + toneNo, replace);
                    Console.WriteLine("Wrote mapping " + snippy + v + toneNo + " : " + replace);
                }
            }
                
        }

        private static void RegisterSnippy()
        {
            File.Copy("snipyin.sh", "/usr/bin/snipyin.sh", true);
        }
    }
}

