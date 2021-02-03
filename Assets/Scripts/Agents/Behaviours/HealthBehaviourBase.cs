using UnityEngine;

public class HealthBehaviourBase : MonoBehaviour
{
    [SerializeField] protected HealthData healthData;

    protected int currentHealth;

    private DestroyBehaviour destroyBehaviour;

    private void Awake()
    {
        destroyBehaviour = GetComponent<DestroyBehaviour>();

        currentHealth = healthData.Health;
    }

    public virtual void TakeDamage(int amount)
    {
        currentHealth = Mathf.Max(0, currentHealth - amount);

        print($"Damage {gameObject.name}. Damage amount: {amount}. Current health {currentHealth}.");

        if (currentHealth == 0)
        {
            Destroy();
        }
    }

    public virtual void Destroy()
    {
        destroyBehaviour.Destroy();

        print($"Destroy {gameObject.name}.");
    }
}