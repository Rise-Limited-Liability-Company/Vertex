using System;
namespace VT_Engine
{
    public class Date
    {
        public class compare {
            static public void equals(string d1,string d2)
            {
                d1[3] = d1.Split("/").Parse();
                d2[3] = d2.Split("/").Parse();
                if ((d1[1] == d2[1]) && (d1[2] == d2[2]) && (d1[3] == d2[3]))
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            static public void higher(string d1,string d2)
            {
                d1[3] = d1.Split("/").Parse();
                d2[3] = d2.Split("/").Parse();
                if ((d1[1] > d2[1]) && (d1[2] > d2[2]) && (d1[3] > d2[3]))
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            static public void lower(string d1,string d2)
            {
                d1[3] = d1.Split("/").Parse();
                d2[3] = d2.Split("/").Parse();
                if ((d1[1] < d2[1]) && (d1[2] < d2[2]) && (d1[3] < d2[3]))
                {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        static public void create()
        {
            return DateTime.new().Year + "/" + DateTime.new().Month + "/" + DateTime.new().Day;
        }
    }
}