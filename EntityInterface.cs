//interface basics
//https://www.dotnetperls.com/interface
//inheriting an interface and a parent class
//https://stackoverflow.com/questions/2059425/in-c-can-a-class-inherit-from-another-class-and-an-interface

public interface IEntity
{
    float Level { get; set; }
    float Experience { get; set; }
    float HitPoints { get; set; }
    float Attack { get; set; }
    float Defense { get; set; }

    void inflictDamage(float damage);

    void basicAttack(IEntity target);
}
