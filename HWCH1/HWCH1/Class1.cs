
public class Rootobject
{
    public Glossary glossary { get; set; }
}

public class Glossary
{
    public string title { get; set; }
    public Glossdiv GlossDiv { get; set; }
}

public class Glossdiv
{
    public string title { get; set; }
    public Glosslist GlossList { get; set; }
}

public class Glosslist
{
    public Glossentry GlossEntry { get; set; }
}

public class Glossentry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public Glossdef GlossDef { get; set; }
    public string GlossSee { get; set; }
}

public class Glossdef
{
    public string para { get; set; }
    public string[] GlossSeeAlso { get; set; }
}
