using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1_pvz
{
    class VideoEncoderis
    {
        //1- apsirasyti Delegate
        //2 - susikurti ivyki pagal delegate
        //3 - iskelti/ sugeneruoti ivyki

        //1
        public delegate void VideoEncodedEventHandler(object sender, EventArgs eventArgs); //standartinis aprasymas

        //2
        public event VideoEncodedEventHandler VideoEncoded; //ivykis - video yra uzkoduotas

        //3
        protected virtual void OnVideoEncoded()  //standartinis aprasymas 
        {
            if (VideoEncoded != null)     //zaibas reikis kad ivykis
            {
                VideoEncoded(this, EventArgs.Empty); //this - kad viska atiduodam; jokiu argumentu nepateiksim (eventArgs)
            }
        }


        //logikos prasme vartotojas turi pasakyti kad uzkoduoti video
        public void Encode()
        {
            Console.WriteLine("Koduojam video");
            System.Threading.Thread.Sleep(3000); //3sec pauze (rasosi mili sekundem)

            OnVideoEncoded();
        }
    }
}
