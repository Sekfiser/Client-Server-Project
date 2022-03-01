﻿using System.Net;
using System.Net.Http.Headers;

namespace Client
{
    public class Sender
    {
        string Url = "http://localhost:9911/timetable"; //TODO: добавить адрес сервера


        public void UploadYamlFile(string FilePath) 
        {
            byte[] buffer = new byte[4096];
            int bytesRead = 0;
            try
            {
                var url = "http://localhost:9911/";

                var request = WebRequest.Create(url);
                request.Method = "POST";
                Stream stream = request.GetRequestStream();
                FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                    stream.Write(buffer, 0, bytesRead);
                fileStream.Close();
                request.Timeout = 5000;
                using var webResponse = request.GetResponse();

            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }
        }
    }
}
