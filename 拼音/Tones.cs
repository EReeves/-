using System;

namespace 拼音
{
    public static class Tones
    {
        public enum Tone : int { t1=1, t2=2, t3=3, t4=4 };    
        public enum Vowel : int { a=1, e=2, i=3, o=4, u=5, A=6, E=7, I=8, O=9, U=10 }

        private static readonly string[] characters = {"āáǎà", "ēéěè", "īíǐì",
            "ōóǒò","ūúǔù", "ĀÁǍÀ", "ĒÉĚÈ", "ĪÍǏÌ", "ŌÓǑÒ", "ŪÚǓÙ" };

        public static char GetVowel(Vowel vowel, Tone tone)
        {
            var v = (int)Convert.ChangeType(vowel, vowel.GetTypeCode());
            var t = (int)Convert.ChangeType(tone, tone.GetTypeCode());
            return characters[v-1][t-1];
        }
    }
}