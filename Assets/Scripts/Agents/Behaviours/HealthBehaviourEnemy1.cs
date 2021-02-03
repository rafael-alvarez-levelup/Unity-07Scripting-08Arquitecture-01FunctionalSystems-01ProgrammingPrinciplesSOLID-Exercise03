using UnityEngine;

public class HealthBehaviourEnemy1 : HealthBehaviourBase
{
    [SerializeField] private GameObject explosionPrefab;

    public override void Destroy()
    {
        SpawnExplosionParticles();

        base.Destroy();
    }

    // TODO: Make behaviour.
    private void SpawnExplosionParticles()
    {
        // TODO: Pooling.
        GameObject explosionParticles = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosionParticles, 0.5f);
    }
}