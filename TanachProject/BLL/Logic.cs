using DAL;
using DTO;
using Newtonsoft.Json;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
namespace BLL
{
    public class Logic
    {
        public static string ChumashSearch(string str)
        {
            string s1 = str;
            str = str + "$";
            string[] ChumashSearch = Base.tora.Split('$');
            foreach (string s in ChumashSearch)
            {
                int a = s.IndexOf("~");
                string book = s.Substring(0, a);
                if (book.Contains(s1))
                    return s;
            }
            return str;
        }
        //פונקציית חיפוש-מקבלת מילה ועבורה מביאה את כל הפסוקים המכילים אותה
        public static List<AllTora> Find(string str)
        {
            List<AllTora> result = new List<AllTora>();
            //string[] lines = File.ReadAllLines(Base.tora);
            string[] ChumashSearch = Base.tora.Split('$');
            for (int i = 0; i < ChumashSearch.Length; i++)
            {
                int a = ChumashSearch[i].IndexOf('~');
                int b = ChumashSearch[i].IndexOf(' ', a + 2);
                int n = b - a;
                string Chumash = ChumashSearch[i].Substring(a + 1, n);
                string[] PerekSearch = ChumashSearch[i].Split('~');
                for (int j = 1; j < PerekSearch.Length; j++)
                {
                    // b = PerekSearch[j].IndexOf(al.Chumash);
                    string Perek = PerekSearch[j].Substring(Chumash.Length, 6);
                    string[] PasukSearch = PerekSearch[j].Split('!');
                    for (int k = 0; k < PasukSearch.Length; k++)
                        if (PasukSearch[k].Contains(str))
                        {
                            int c = PasukSearch[k].IndexOf('}');
                            int d = PasukSearch[k].IndexOf('{');
                            string Pasuk = PasukSearch[k].Substring(d + 1, c - d - 1);
                            string Melel = PasukSearch[k].Substring(c + 1);
                            result.Add(new AllTora(Chumash, Perek, Pasuk, Melel));
                        }
                }
            }
            return result;
        }
        //פונקצייה המחפשת מילים שלימות בתוך הפסוקים
        public static List<AllTora> FindFullWord(string str)
        {
            string s = " ";
            s += str;
            s += " ";
            return Find(s);
        }
        //פונקציית חיפוש בשונה מהפונקציה הקודמת היא מקבלת מחרוזת של מילים ולא מילה בודדת
        public static List<AllTora> Find1(List<string> str)
        {
            List<AllTora> result = new List<AllTora>();
            string[] ChumashSearch = Base.tora.Split('$');
            for (int i = 0; i < ChumashSearch.Length; i++)
            {
                int a = ChumashSearch[i].IndexOf('~');
                int b = ChumashSearch[i].IndexOf(' ', a + 2);
                int n = b - a;
                string Chumash = ChumashSearch[i].Substring(a + 1, n);
                string[] PerekSearch = ChumashSearch[i].Split('~');
                for (int j = 1; j < PerekSearch.Length; j++)
                {
                    string Perek = PerekSearch[j].Substring(Chumash.Length, 6);
                    string[] PasukSearch = PerekSearch[j].Split('!');
                    for (int k = 0; k < PasukSearch.Length; k++)
                        foreach (string s in str)
                            if (PasukSearch[k].Contains(s))
                            {
                                int c = PasukSearch[k].IndexOf('}');
                                int d = PasukSearch[k].IndexOf('{');
                                string Pasuk = PasukSearch[k].Substring(d + 1, c - d - 1);
                                string Melel = PasukSearch[k].Substring(c + 1);
                                result.Add(new AllTora(Chumash, Perek, Pasuk, Melel));
                            }
                }
            }
            return result;
        }

        //פונקצייה המביאה את המילה המוכנסת בכתיב חסר
        public static List<AllTora> FindWithMoreLetters(string str)
        {
            string st = File.ReadAllText(@"C:\Users\Moriya\Documents\Programming\Year 2 programming\C#\Tanach\history.json");
            List<Json> dataList = JsonConvert.DeserializeObject<List<Json>>(st);
            foreach (Json j in dataList)
            {
                if (j.FindName == str)
                    return j.ListFoundPsukim;
            }
            List<string> moreWords = new List<string>();
            List<AllTora> all = new List<AllTora>();
            moreWords.Add(str);
            string str1 = str;
            string str2 = str;
            string str3 = str;
            while (str3.Contains('י') && str3.Contains('ו'))
            {
                int a = str3.IndexOf('י');
                string s = str3.Substring(0, a);
                s += str3.Substring(a + 1);
                int b = str3.IndexOf('ו');
                s = str3.Substring(0, b);
                s += str3.Substring(b + 1);
                str3 = s;
                moreWords.Add(s);
            }
            while (str3.Contains('ו'))
            {
                int a = str3.IndexOf('ו');
                string s = str3.Substring(0, a);
                s += str3.Substring(a + 1);
                str3 = s;
                moreWords.Add(s);
            }
            while (str3.Contains('י'))
            {
                int a = str3.IndexOf('י');
                string s = str3.Substring(0, a);
                s += str3.Substring(a + 1);
                str3 = s;
                moreWords.Add(s);
            }
            while (str1.Contains('ו'))
            {
                int a = str1.IndexOf('ו');
                string s = str1.Substring(0, a);
                s += str1.Substring(a + 1);
                str1 = s;
                moreWords.Add(s);
            }
            while (str2.Contains('י'))
            {
                int a = str2.IndexOf('י');
                string s = str2.Substring(0, a);
                s += str2.Substring(a + 1);
                str2 = s;
                moreWords.Add(s);

            }
            all = Find1(moreWords);
            Json js = new Json(str, moreWords, all);
            dataList.Add(js);
            string updatedJson = JsonConvert.SerializeObject(dataList);
            File.WriteAllText(@"C:\Users\Moriya\Documents\Programming\Year 2 programming\C#\Tanach\history.json", updatedJson);
            return all;
        }
    }
}