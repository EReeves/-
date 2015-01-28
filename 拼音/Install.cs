using System;
using System.IO;
using System.Text;

namespace 拼音
{
    public static class Install
    {

        public static void InstallSnippets()
        {
            var home = (Environment.OSVersion.Platform == PlatformID.Unix || 
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            var snippy = home + "/.snipyin/";
            Directory.CreateDirectory(snippy);
            File.Copy(".mandarin", snippy + "/.mandarin", true);

            Console.WriteLine("created directory " + snippy);


            var result = new StringBuilder();

            foreach (var v in Enum.GetNames(typeof(Tones.Vowel)))
            {
                foreach (var t in Enum.GetValues(typeof(Tones.Tone)))
                {     
                    var vowel = (Tones.Vowel)Enum.Parse(typeof(Tones.Vowel), v, false);
                    var tone = (Tones.Tone)Enum.Parse(typeof(Tones.Tone), ((int)t).ToString(), false);

                    var toneNo = ((int)t).ToString();
                    toneNo = toneNo.Replace("t", String.Empty);
                    var replace = Tones.GetVowel(vowel, tone).ToString();

                    result.AppendLine("[" + v + toneNo + "] " + replace);
                }
            }

            File.WriteAllText(snippy + "/.vowels", result.ToString());
                
        }

        public static void InstallBinary()
        {
            File.Copy("snipyin.sh", "/usr/bin/snipyin.sh", true);
        }
    }
}

