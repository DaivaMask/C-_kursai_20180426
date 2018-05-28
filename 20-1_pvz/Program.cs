using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            //objektas kur bus video enkoderis
            VideoEncoderis videoEncoderis = new VideoEncoderis();
            MessageService messageService = new MessageService();
            videoEncoderis.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoderis.Encode(); // paleidus sitoj vietoj uzstruks kodavima 3sec 

        }
    }

    class MessageService
    {
        public void OnVideoEncoded(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("MessageService: Siunciame sms...");
        }
    }
}
