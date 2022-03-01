﻿using System.Net;

namespace Client
{
    internal class Reciver
    {
        public void GetInfo()
        {
            try
            {
                var url = "http://localhost:9911/timetable";

                var request = WebRequest.Create(url);
                request.Method = "GET";

                using var webResponse = request.GetResponse();
                using var webStream = webResponse.GetResponseStream();

                using var reader = new StreamReader(webStream);

                var data = reader.ReadToEnd();

                Console.WriteLine(data);
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }
        }

        public void GetInfo(int Id)
        {
            try
            {
                var url = "http://localhost:9911/Timetable/";

                var request = WebRequest.Create(url);
                request.Method = "GET";

                using var webResponse = request.GetResponse();
                using var webStream = webResponse.GetResponseStream();

                using var reader = new StreamReader(webStream);

                var data = reader.ReadToEnd();

                Console.WriteLine(data);
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }
        }

    }
}
