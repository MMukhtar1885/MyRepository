using System;
using System.Data;
public class Example
{
    public static DataTable demo()
    {
        DataTable dtable = new DataTable();
        dtable.Columns.Add("SNO", typeof(int));
        dtable.Columns.Add("Name", typeof(string));
        dtable.Columns.Add("City", typeof(string));
        dtable.Columns.Add("Date", typeof(DateTime));
        dtable.Rows.Add(1, "Siva", "TUP", DateTime.Now);
        dtable.Rows.Add(2, "Raman", "MAS", DateTime.Now);
        dtable.Rows.Add(3, "Sivaraman", "TRY", DateTime.Now);
        dtable.Rows.Add(4, "Kuble", "MDU", DateTime.Now);
        dtable.Rows.Add(5, "Arun", "Salem", DateTime.Now);
        dtable.Rows.Add(6, "Kumar", "Erode", DateTime.Now);
        dtable.Rows.Add(7, "ghasj", "Tup", DateTime.Now);
        dtable.Rows.Add(8, "dsfd", "yercaud", DateTime.Now);
        dtable.Rows.Add(9, "dsdf", "ui", DateTime.Now);
        dtable.Rows.Add(10, "sddd", "erf", DateTime.Now);
        return dtable;
    }
    public static void Main()
    {
        DataTable tables = demo();
        foreach (DataRow r in tables.Select())
        {
            if (r["SNO"].ToString().Equals("2"))
            {
                tables.Rows.Remove(r);
            }
        }
        Console.WriteLine("Welcome After removing the datas");
        foreach (DataRow r1 in tables.Rows)
        {
            Console.WriteLine("SNO: {0}\t Name : {1} \t City: {2} \t Date: {3} \t ", r1[0], r1[1], r1[2], r1[3]);
        }
    }
}