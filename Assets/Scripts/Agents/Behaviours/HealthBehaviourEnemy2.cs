public class HealthBehaviourEnemy2 : HealthBehaviourEnemy1
{
    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount / 2);
    }
}