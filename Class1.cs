using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;



namespace WindowsFormsApp2
{
    public class Class1
    {
       

        public string[] s;
        public int m;
        public string[] search1()

        {

           string[] inputEmails = new string[] { "aryarmin@yahoo.com", "aryarmin@yahoo.com", "aryarmin@gmail.com" };
            
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            
            for (int j = 1; j < inputEmails.Length; j++)


            {
                foreach (Match match in Regex.Matches(inputEmails[j].ToString(), strRegex))
                {
                  
                    s[j] = match.Value.ToString();
                }
            }

            return s;
        }

        


        public string[] key;
        public string[] search2()
        {
            string inputEmails = "aryarmin1@gmail.com,aryarmin@yahoo.com,aryarmin6@yahoo.com";
            string[] words = inputEmails.Split(',');



            // Here we call Regex.Match.
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";


            for (int i = 0; i < words.Length; i++)
            {
                //  Match match {
                Match match = Regex.Match(words[i], strRegex);
                if (match.Success)
                {
                    key[i] = match.Groups["email"].Value;

                    match = match.NextMatch();
                }
            }

            return key;

        }
        public string p;
        public string seach3()
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"; ;
            string input = "aryarmin1@gmail.com,aryarmin@yahoo.com,aryarmin6@yahoo.com";
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                Match m = Regex.Match(words[i], pattern);

                while (m.Success)
                {
                    p = m.Value;
               //     m = m.NextMatch();
                }
            }
            return p;


        }


        public string key1;
        public string search4()
        {
            string[] sentences =
            {

"aryarmin1@gmail.com","aryarmin@yahoo.com","aryarmin6@yahoo.com"


            };

            string spattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";


            foreach (string s in sentences)
            {

                if (System.Text.RegularExpressions.Regex.IsMatch(s, spattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))

                {

                    key1 = s;

                }

               


            }
            return key1;
        }


    }

    

    }

