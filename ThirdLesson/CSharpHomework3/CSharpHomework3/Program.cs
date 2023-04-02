using CSharpHomework3;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        TV LG = new TV();
        SmartTV Samsung = new SmartTV();
        LG.OpenTVDefault();
        LG.ChangeVolumeDown();
        LG.ChangeVolumeDown();
        LG.ChangeVolumeDown();
        LG.ChangeChannelUp();
        LG.ChangeChannelUp();
        LG.ChangeChannelUp();
        LG.CloseTV();
        LG.OpenTV();
        Samsung.OpenTV();
        Samsung.OpenTVCustomSettings(10, 30);
        Samsung.CloseTV();
        Samsung.OpenTV();
        Samsung.ChangeVolume(25);
        Samsung.ChangeChannel(30);
        Samsung.CloseTV();
        Samsung.OpenTV();


    }
}