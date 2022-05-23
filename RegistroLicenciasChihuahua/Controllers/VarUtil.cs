using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace PUE.Controllers
{
    public class JsCuarto
    {
        public int Num = 0;
        public int Year = 0;
        public DateTime StartDate;
        public DateTime EndDate;
    }
    public  class VarUtil
    {
        private static List<string> alphabetArray = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public static NameValueCollection CloneValueCollection(NameValueCollection gdata)
        {
            NameValueCollection data = new NameValueCollection();
            foreach (string key in gdata.AllKeys)
            {
                data[key] = gdata[key];
            }
            return data;
        }
        public static JsCuarto GetCurrentQuarter()
        {
            DateTime datetime = VarUtil.Now();
            int currQuarter = GetQuarterByMonth(datetime.Month);
            return GetQuarterDate(datetime.Year, currQuarter);
        }
        public static string FindNextChar(string currentChar)
        {
            string spcase = currentChar.ToUpper();
            int currentIndex = alphabetArray.FindIndex(t => t == spcase);
            int nextIndex = currentIndex + 1;
            string nextChar = alphabetArray[0];
            if (nextIndex < alphabetArray.Count)
            {
                nextChar = alphabetArray[nextIndex];
            }
            return nextChar;
        }

        public static bool IsValidJson(string input)
        {
            input = input.Trim();
            if ((input.StartsWith("{") && input.EndsWith("}")) || //For object
                (input.StartsWith("[") && input.EndsWith("]"))) //For array
            {
                try
                {
                    //parse the input into a JObject
                    JToken.Parse(input);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        public static bool IsValidEmail(string emailAddress)
        {
            return Regex.IsMatch(emailAddress, @"^[a-zA-Z0-9_\.\-]+@[a-zA-Z0-9\.\-]+\.[a-zA-Z]{2,6}$");
        }
        public DayOfWeek GetDayOfWeek(int n)
        {
            foreach (DayOfWeek dy in Enum.GetValues(typeof(DayOfWeek)))
            {
                if (VarUtil.getInt(dy) == n)
                {
                    return dy;
                }
            }
            return DayOfWeek.Sunday;
        }
        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(timestamp);
        }

        public static DateTime GetNextDateForDay(DateTime startDate, DayOfWeek desiredDay)
        {

            return startDate.AddDays(DaysToAdd(startDate.DayOfWeek, desiredDay));
        }

        public static int DaysToAdd(DayOfWeek current, DayOfWeek desired)
        {
            int c = (int)current;
            int d = (int)desired;
            int n = (7 - c + d);

            return (n > 7) ? n % 7 : n;
        }

        public static JsCuarto GetQuarterDate(int startYear, int quarter)
        {
            int startMonth = 0;
            int startDay = 1;
            int endMonth = 0;
            int endDay = 31;

            switch (quarter)
            {
                case 1:
                    startMonth = 1;
                    endMonth = 3;
                    endDay = 30;
                    break;

                case 2:
                    startMonth = 4;
                    endMonth = 6;
                    endDay = 30;
                    break;

                case 3:
                    startMonth = 7;
                    endMonth = 9;
                    endDay = 30;
                    break;

                case 4:
                    startMonth = 10;
                    endMonth = 12;
                    break;
            }

            DateTime startDate = new DateTime(startYear, startMonth, startDay);
            DateTime endDate = new DateTime(startYear, endMonth, endDay);
            return new JsCuarto
            {
                Year = startYear,
                Num = quarter,
                StartDate = startDate,
                EndDate = endDate
            };
        }

        public static int GetQuarterByMonth(int month)
        {
            int quarter = 0;
            if (month >= 1 && month <= 3)
            {
                quarter = 1;
            }
            if (month >= 4 && month <= 6)
            {
                quarter = 2;
            }
            if (month >= 7 && month <= 9)
            {
                quarter = 3;
            }
            if (month >= 10 && month <= 12)
            {
                quarter = 4;
            }
            return quarter;
        }

        public static string getStr(object obj)
        {
            return Convert.ToString(obj);
        }
        public static string getCleanStr(object obj)
        {
            string s = Convert.ToString(obj) ?? "";
            return s.Trim();
        }
        public static bool getBoolByCK(string str)
        {
            string s = (str ?? "").ToLower();
            if (s == "on" || s == "yes" || s == "true" || s == "1" || s == "si" || s == "SI" || s == "Si")
            {
                return true;
            }
            return false;
        }
        public static int getInt(object obj)
        {
            int n = 0;
            int.TryParse(Convert.ToString(obj), out n);
            return n;
        }
        public static short getInt16(object obj)
        {
            short n = 0;
            short.TryParse(Convert.ToString(obj), out n);
            return n;
        }

        public static bool getBool(object obj)
        {
            bool _is = true;
            bool.TryParse(Convert.ToString(obj), out _is);
            return _is;
        }

        public static decimal getDecimal(object obj)
        {
            decimal n = 0;
            decimal.TryParse(Convert.ToString(obj), out n);
            return n;
        }

        public static double getDouble(object obj)
        {
            double n = 0;
            double.TryParse(Convert.ToString(obj), out n);
            return n;
        }

        public static float getFloat(object obj)
        {
            float n = 0;
            float.TryParse(Convert.ToString(obj), out n);
            return n;
        }

        public static int? getNInt(object obj)
        {
            int n = 0;
            if (int.TryParse(Convert.ToString(obj), out n))
            {
                return n;
            }
            return null;
        }
        public static List<int> Str2Ints(string s)
        {
            return Str2Ints(s, ',');
        }
        public static List<int> Str2Ints(string s, char separator)
        {
            List<int> nms = new List<int>();
            string[] separa = s.Split(separator);
            foreach (string ns in separa)
            {
                nms.Add(VarUtil.getInt(ns));
            }
            return nms;
        }
        public static List<string> Csv2String(string s, char separator)
        {
            List<string> nms = new List<string>();
            if (String.IsNullOrEmpty(s))
            {
                s = "";
            }
            string[] separa = s.Split(separator);
            string clean_str = "";
            foreach (string ns in separa)
            {
                if (!String.IsNullOrEmpty(ns))
                {
                    clean_str = ns.Trim();
                    nms.Add(clean_str);
                }

            }
            return nms;
        }


        public static bool TryParseExactDate(string sdate, out DateTime fecha)
        {
            sdate = sdate == null ? "" : sdate;
            sdate = sdate.Trim();
            sdate = sdate.IndexOf(' ') > -1 ? sdate.Split(' ')[0] : sdate;
            sdate = sdate.Replace('/', '-');
            string[] allowedFormats = { "MMyy", "MMyyyy", "MM-yyyy", "MM-yy", "yyyyMMdd", "yyyy-MM-dd", "MM-dd-yyyy", "M-d-yyyy", "dd-MM-yy", "dd-MM-yyyy" };
            fecha = new DateTime(0);
            int i = 0;
            for (i = 0; i < allowedFormats.Length; i++)
            {
                if (DateTime.TryParseExact(sdate, allowedFormats[i], System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fecha))
                {
                    return true;
                }
            }
            return false;
        }
        public static string GetStrFile(string fname)
        {
            using (FileStream fs = new FileStream(fname,
                                          FileMode.Open,
                                          FileAccess.Read,
                                          FileShare.ReadWrite))
            {
                StringBuilder sb = new StringBuilder();
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (sr.Peek() >= 0) // reading the old data
                    {
                        sb.Append(sr.ReadLine());
                    }
                }
                return sb.ToString();
            }
        }
        public static string GetStrWeek(int nweek)
        {
            string weeknum = "";
            string[] weeksname = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };
            if (nweek >= 0 && nweek < weeksname.Count())
            {
                weeknum = weeksname[nweek];
            }
            return weeknum;

        }
        public static int weekNumber(DateTime fromDate)
        {
            // Get jan 1st of the year
            DateTime startOfYear = fromDate.AddDays(-fromDate.Day + 1).AddMonths(-fromDate.Month + 1);
            // Get dec 31st of the year
            DateTime endOfYear = startOfYear.AddYears(1).AddDays(-1);
            // ISO 8601 weeks start with Monday 
            // The first week of a year includes the first Thursday 
            // DayOfWeek returns 0 for sunday up to 6 for saterday
            int[] iso8601Correction = { 6, 7, 8, 9, 10, 4, 5 };
            int nds = fromDate.Subtract(startOfYear).Days + iso8601Correction[(int)startOfYear.DayOfWeek];
            int wk = nds / 7;
            switch (wk)
            {
                case 0:
                    // Return weeknumber of dec 31st of the previous year
                    return weekNumber(startOfYear.AddDays(-1));
                case 53:
                    // If dec 31st falls before thursday it is week 01 of next year
                    if (endOfYear.DayOfWeek < DayOfWeek.Thursday)
                        return 1;
                    else
                        return wk;
                default: return wk;
            }
        }
        public static string GetTemplate(string fname, Dictionary<string, string> data)
        {
            string htm = System.IO.File.ReadAllText(fname);
            foreach (string key in data.Keys)
            {
                htm = htm.Replace("{" + key + "}", data[key]);
            }
            return htm;
        }
        public static string GetTemplate(string fname, Dictionary<string, object> data)
        {
            string htm = System.IO.File.ReadAllText(fname);
            foreach (string key in data.Keys)
            {
                htm = htm.Replace("{" + key + "}", Convert.ToString(data[key]));
            }
            return htm;
        }

        //Funciones para el envio de TOKEN

        public static double GenRand(double one, double two)
        {
            Random rand = new Random();
            return one + rand.NextDouble() * (two - one);
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public static DateTime Now()
        {
            try
            {
                TimeZoneInfo timeZoneInfo;
                //Set the time zone information to timezone
                timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time (Mexico)");
                //Get date and time in US Mountain Standard Time 
                DateTime dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
                return dateTime;
            }
            catch
            {
                return DateTime.Now;
            }
        }

        public static string SHA256(string password)
        {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }


    }
}
