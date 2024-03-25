using System.Text;

namespace Gtc.Models;


public static class ListExtensions{



    public static string ListToString<T>(this IEnumerable<T> source)where T:class{
        var sb=new StringBuilder();
        foreach(var i in source){
            sb.AppendLine(i.ToString());
        }
        return sb.ToString();
    }
}