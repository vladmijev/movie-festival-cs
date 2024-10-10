using System;

namespace MovieFestival;

public class Genre
{
    public string Name { get; set; }

    public Genre(string name)
    {
        Name = name;
    }

    public string GetData()
    {
        return Name[0] + " " + Name[Name.Length - 1];
    }


}
