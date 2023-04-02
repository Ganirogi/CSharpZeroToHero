using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework3
{
    internal class SmartTV : TV
    {
        public void OpenTVCustomSettings(int Channel, int Volume)
        {
            channel = Channel;
            volume = Volume;
            Console.WriteLine("Smart TV started with custom settings:");
            Console.WriteLine("Channel:" + channel);
            Console.WriteLine("Volume:" + volume);
        }

        public void ChangeChannel(int Channel)
        {
            channel = Channel;
            Console.WriteLine("TV moved to channel:" + channel);
        }

        public void ChangeVolume(int Volume)
        {
            volume = Volume;
            Console.WriteLine("TV volume is:" + volume);
        }

    }
}
