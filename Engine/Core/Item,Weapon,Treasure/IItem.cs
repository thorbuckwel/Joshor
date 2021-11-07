namespace Engine
{
    public interface IItem
    {
        string Name { get; set; }
        string NamePlural { get; set; }
        int Price { get; set; }
        string Desc { get; set; }
        bool Equiptable { get; set; }
        int ID { get; set; }
        
    }
}