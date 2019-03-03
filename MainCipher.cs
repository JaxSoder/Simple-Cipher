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

            //Start Numbers

            ChipherStringBuild.Replace("0", " _+_+==-= ");
            ChipherStringBuild.Replace("1", " ``_` ");
            ChipherStringBuild.Replace("2", " ¯`·.¸¸.-> °º ");
            ChipherStringBuild.Replace("3", " ==-- [][] ");
            ChipherStringBuild.Replace("4", " ';/ ");
            ChipherStringBuild.Replace("5", " =] ");
            ChipherStringBuild.Replace("6", " -= ");
            ChipherStringBuild.Replace("7", " ==-=-= ");
            ChipherStringBuild.Replace("8", " []//] ");
            ChipherStringBuild.Replace("9", " //;;; ");

            //Start Letters

            ChipherStringBuild.Replace("q", " ☺☺ ");
            ChipherStringBuild.Replace("w", " ☀☁☊☀ ");
            ChipherStringBuild.Replace("e", " ☂☩☇ ");
            ChipherStringBuild.Replace("r", " ☉☊☩☉ ");
            ChipherStringBuild.Replace("t", " ☩☧☬☧ ");
            ChipherStringBuild.Replace("y", " ☩☧☩ ");
            ChipherStringBuild.Replace("u", " ⛺⚼⚻ ");
            ChipherStringBuild.Replace("i", " ⚶⛺ ");
            ChipherStringBuild.Replace("o", " ⚼⚶ ");
            ChipherStringBuild.Replace("p", " ⛏ ");

            ChipherStringBuild.Replace("a", " ☷★★☷ ");
            ChipherStringBuild.Replace("s", " ☥☒☒ ");
            ChipherStringBuild.Replace("d", " ☷☥ ");
            ChipherStringBuild.Replace("f", " ☕☕ ");
            ChipherStringBuild.Replace("g", " ☷☓☓ ");
            ChipherStringBuild.Replace("h", " ☥ ");
            ChipherStringBuild.Replace("j", " ♂♂♂♂ ");
            ChipherStringBuild.Replace("k", " ☒☷☒ ");
            ChipherStringBuild.Replace("l", " ☥☓☥ ");

            ChipherStringBuild.Replace("z", " 人大（或二十四日山 ");
            ChipherStringBuild.Replace("x", " 大部首中的第 ");
            ChipherStringBuild.Replace("c", " 人山人 ");
            ChipherStringBuild.Replace("v", " 山從上、下、左方 ");
            ChipherStringBuild.Replace("b", " 人和簡體中大 ");
            ChipherStringBuild.Replace("n", " 大漢字索引裡為部 ");
            ChipherStringBuild.Replace("m", " 人大人 ");

            CipherdText = ChipherStringBuild.ToString();
        }

        public static void DechipherBuild(string newText)
        {
            StringBuilder DechipherStringBuild = new StringBuilder(newText);

            //Start Numbers

            DechipherStringBuild.Replace(" _+_+==-= ", "0");
            DechipherStringBuild.Replace(" ``_` ", "1");
            DechipherStringBuild.Replace(" ¯`·.¸¸.-> °º ", "2");
            DechipherStringBuild.Replace(" ==-- [][] ", "3");
            DechipherStringBuild.Replace(" ';/ ", "4");
            DechipherStringBuild.Replace(" =] ", "5");
            DechipherStringBuild.Replace(" -= ", "6");
            DechipherStringBuild.Replace(" ==-=-= ", "7");
            DechipherStringBuild.Replace(" []//] ", "8");
            DechipherStringBuild.Replace(" //;;; ", "9");

            //Start Leters

            DechipherStringBuild.Replace(" ☺☺ ", "q");
            DechipherStringBuild.Replace(" ☀☁☊☀ ", "w");
            DechipherStringBuild.Replace(" ☂☩☇ ", "e");
            DechipherStringBuild.Replace(" ☉☊☩☉ ", "r");
            DechipherStringBuild.Replace(" ☩☧☬☧ ", "t");
            DechipherStringBuild.Replace(" ☩☧☩ ", "y");
            DechipherStringBuild.Replace(" ⛺⚼⚻ ", "u");
            DechipherStringBuild.Replace(" ⚶⛺ ", "i");
            DechipherStringBuild.Replace(" ⚼⚶ ", "o");
            DechipherStringBuild.Replace(" ⛏ ", "p");

            DechipherStringBuild.Replace(" ☷★★☷ ", "a");
            DechipherStringBuild.Replace(" ☥☒☒ ", "s");
            DechipherStringBuild.Replace(" ☷☥ ", "d");
            DechipherStringBuild.Replace(" ☕☕ ", "f");
            DechipherStringBuild.Replace(" ☷☓☓ ", "g");
            DechipherStringBuild.Replace(" ☥ ", "h");
            DechipherStringBuild.Replace(" ♂♂♂♂ ", "j");
            DechipherStringBuild.Replace(" ☒☷☒ ", "k");
            DechipherStringBuild.Replace(" ☥☓☥ ", "l");

            DechipherStringBuild.Replace(" 人大（或二十四日山 ", "z");
            DechipherStringBuild.Replace(" 大部首中的第 ", "x");
            DechipherStringBuild.Replace(" 人山人 ", "c");
            DechipherStringBuild.Replace(" 山從上、下、左方 ", "v");
            DechipherStringBuild.Replace(" 人和簡體中大 ", "b");
            DechipherStringBuild.Replace(" 大漢字索引裡為部 ", "n");
            DechipherStringBuild.Replace(" 人大人 ", "m");

            DecipherdText = DechipherStringBuild.ToString();
        }
    }
}

