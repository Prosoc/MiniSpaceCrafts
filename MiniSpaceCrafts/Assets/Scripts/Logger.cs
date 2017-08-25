using System.Collections.Generic;
using UnityEngine;

public sealed class Logger
{
    public List<string> log = new List<string>();
    private static volatile Logger instance;

    private Logger() { }

    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                if (instance == null)
                    instance = new Logger();
            }

            return instance;
        }
    }

    public void Log(string type, string id, string text)
    {
        string txt = string.Format("[{0} - {1}] {2}", type, id, text);
        //log.Add(txt);
        Debug.Log(txt);
    }
}
