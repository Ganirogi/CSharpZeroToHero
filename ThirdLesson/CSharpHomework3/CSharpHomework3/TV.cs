namespace CSharpHomework3
{
    internal class TV
    {
        protected int volume { get; set; }
        protected int channel { get; set; }
        public void OpenTVDefault()
        {
            channel = 1;
            volume = 15;
            Console.WriteLine("TV started on default settings!");
            Console.WriteLine("Channel:" + channel);
            Console.WriteLine("Volume:" + volume);
        }

        public void CloseTV()
        {
            Console.WriteLine("TV shutting down!");
        }

        public void OpenTV()
        {
            if (channel == 0 || volume == 0)
            {
                OpenTVDefault();
            }
            else
            {
                Console.WriteLine("TV started with following settings!:");
                Console.WriteLine("Channel:" + channel);
                Console.WriteLine("Volume:" + volume);
            }
        }

        public void ChangeVolumeUp()
        {
            volume++;
            Console.WriteLine("TV volume is:" + volume);
        }

        public void ChangeVolumeDown()
        {
            volume--;
            Console.WriteLine("TV volume is:" + volume);
        }

        public void ChangeChannelUp()
        {
            channel++;
            Console.WriteLine("TV channel is:" + channel);
        }

        public void ChangeChannelDown()
        {
            channel--;
            Console.WriteLine("TV channel is:" + channel);
        }

    }
}
