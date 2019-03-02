using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaxsCipher
{
    class MainCipher
    {
        public static string CipherdText;
        public static string DecipherdText;


        public static void CipherText(string newText)
        {
            ChipherBuild(newText);
        }

        public static void DecipherText(string newText)
        {
            DechipherBuild(newText);
        }

        public static void ChipherBuild(string newText)
        {
            StringBuilder ChipherStringBuild = new StringBuilder(newText);

            //test
            ChipherStringBuild.Replace("1", " ``_` ");
            ChipherStringBuild.Replace("2", " --` ");
            ChipherStringBuild.Replace("3", " ==-- [][] ");
            ChipherStringBuild.Replace("4", " ';/ ");
            ChipherStringBuild.Replace("5", " =] ");
            ChipherStringBuild.Replace("6", " -= ");
            ChipherStringBuild.Replace("7", " ==-=-= ");
            ChipherStringBuild.Replace("8", " []//] ");
            ChipherStringBuild.Replace("9", " //;;; ");


            CipherdText = ChipherStringBuild.ToString();
        }

        public static void DechipherBuild(string newText)
        {
            StringBuilder DechipherStringBuild = new StringBuilder(newText);


            DechipherStringBuild.Replace(" ``_` ", "1");
            DechipherStringBuild.Replace(" --` ", "2");
            DechipherStringBuild.Replace(" ==-- [][] ", "3");
            DechipherStringBuild.Replace(" ';/ ", "4");
            DechipherStringBuild.Replace(" =] ", "5");
            DechipherStringBuild.Replace(" -= ", "6");
            DechipherStringBuild.Replace(" ==-=-= ", "7");
            DechipherStringBuild.Replace(" []//] ", "8");
            DechipherStringBuild.Replace(" //;;; ", "9");


            DecipherdText = DechipherStringBuild.ToString();
        }
    }
}

