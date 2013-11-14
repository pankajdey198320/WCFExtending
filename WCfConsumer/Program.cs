using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCfConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaService.MediaClient clnt = new MediaService.MediaClient();
            Console.Write(clnt.GetMediaName());
            Console.ReadKey();
        }
    }
}
