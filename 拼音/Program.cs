using System;
using System.Linq;

namespace 拼音
{
    class MainClass
    {
        public static void Main(string[] args)
        {     
            if (args.Contains("--install-snippets"))
            {
                Install.InstallSnippets();  
            }

            if(args.Contains("--install-bin"))
            {
                 Install.InstallBinary();
            }
        }
    }
}
