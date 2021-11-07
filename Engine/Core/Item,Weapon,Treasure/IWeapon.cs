namespace Engine
{
    public interface IWeapon : IEquiptable
    {
        string Damage { get; set; }
        string DamageType { get; set; }
    }
}