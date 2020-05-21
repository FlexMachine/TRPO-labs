using System;


namespace StringFormatter
{
    public class StringFormatter
    {
        string str;

        public string Str
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
            }
        }

        public string WebString(string str)
        {
            string fnly = "";
            if (str.StartsWith("http://"))
                return str;
            else
                fnly = str.Insert(0, "http://");

            return fnly;


        }
        public string GitString(string str)
        {
            string git = "git://";
            if (str.EndsWith(".git"))
            {
                str = str.Replace(".git", " ");
                str = str.Insert(0, git);
                str = str.Trim();
            }
            else
                return str;

            return str;
        }

        public string IsNull(string str)
        {

            if (str == null)
                throw new NullReferenceException();
            return str;
        }
        public static void Main(string[] args)
        {

        }
    }
}
