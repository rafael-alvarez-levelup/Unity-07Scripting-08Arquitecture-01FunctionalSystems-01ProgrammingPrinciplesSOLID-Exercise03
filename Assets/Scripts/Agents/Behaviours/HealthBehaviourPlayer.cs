using UnityEngine;

public class HealthBehaviourPlayer : HealthBehaviourBase, IHealable
{
    [SerializeField] private GameObject damageEffectPrefab;

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);

        SpawnDamageEffectParticles();
    }

    public void Heal(int amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, healthData.Health);
    }

    // TODO: Make behaviour.
    private void SpawnDamageEffectParticles()
    {
        // TODO: Pooling.
        GameObject damageEffect = Instantiate(damageEffectPrefab, transform.position, transform.rotation);
        Destroy(damageEffect, 0.5f);
    }
}