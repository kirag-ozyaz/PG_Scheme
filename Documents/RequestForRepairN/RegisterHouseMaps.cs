public class RegisterHouseMaps
{
    /// <summary>
    /// дом с префиксом
    /// </summary>
    internal string Name
    {
        get;
        set;
    }
    /// <summary>
    /// Идентификатор дома на карте
    /// </summary>
    internal int Id
    {
        get;
        set;
    }

    internal RegisterHouseMaps(string name, int id)
    {
        this.Name = name;
        this.Id = id;
    }

    public override string ToString()
    {
        return this.Name;
    }
}

