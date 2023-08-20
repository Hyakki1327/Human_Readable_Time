var Time = Convert.ToInt32(Console.ReadLine());

static string GetReadableTime(int seconds)
{
    string ReadableTime, HH, MM, SS;

    if (seconds > 359999)
        return "Error";
    else if (seconds < 0)
        return "Error";
    else
    {
        SS = (seconds % 60).ToString("d2");
        MM = (seconds / 60 % 60).ToString("d2");
        HH = (seconds / 3600).ToString("d2");
    }

    ReadableTime = HH + ":" + MM + ":" + SS;

    return (ReadableTime);
}

Console.WriteLine(GetReadableTime(Time));