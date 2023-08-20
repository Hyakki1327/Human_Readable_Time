var Time = Convert.ToInt32(Console.ReadLine());

static string GetReadableTime(int seconds)
{
    string ReadableTime, HH, MM, SS = "00";

    if (seconds > 359999)
        return "Error";
    else
    {
        SS = (seconds % 60).ToString("d2");
        MM = ((seconds / 60) % 60).ToString("d2");
        HH = ((seconds / 60) / 60).ToString("d2");
    }

    ReadableTime = HH + ":" + MM + ":" + SS;

    return (ReadableTime);
}

Console.WriteLine(GetReadableTime(Time));