﻿using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using Server;
    
class Listener
{
    public static async Task Listen(SQLConnector con)
    {
        HttpListener listener = new HttpListener();
        listener.Prefixes.Add("http://localhost:9911/");
        listener.Start();
        Console.WriteLine("Ожидание подключений...");

        while (true)
        {
            HttpListenerContext context = await listener.GetContextAsync();
            Console.WriteLine("Подключение установленно");
            HttpParser parser = new HttpParser(context, con);
        }
    }
}
