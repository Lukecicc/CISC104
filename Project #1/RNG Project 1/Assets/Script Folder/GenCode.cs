
using System;

public class GenCode 
{

public int number;
public int clicks;

public GenCode()
{
        clicks = 0;
        number = 0;
}

public int Generator()
    {
        Random rnd = new Random();
        number = rnd.Next(1, 100);
        Clicked();
        return number;
    }

    public int Clicked()
    {
        clicks++;
        return clicks;
    }

    public void Reset()
    {
        number = 0;
        clicks = 0;
    }
}





