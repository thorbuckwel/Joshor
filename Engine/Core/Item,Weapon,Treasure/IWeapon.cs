namespace Engine
{
    public interface IWeapon
    {
        string Damage { get; set; }
        string DamageType { get; set; }
        string Desc { get; set; }
        bool Equiptable { get; set; }
        int ID { get; set; }
        string Name { get; set; }
        string NamePlural { get; set; }
        int Price { get; set; }
        int WearLocation { get; set; }
    }
}