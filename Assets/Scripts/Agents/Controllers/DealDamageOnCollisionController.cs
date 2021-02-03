using UnityEngine;

public class DealDamageOnCollisionController : MonoBehaviour
{
    [SerializeField] private DamageData damageData;
    [SerializeField] private LayerMask collisionMask;

    private void OnTriggerEnter(Collider other)
    {
        // Destroy this game object if the other game object is in the assigned destroy layer.
        if (Utilities.ContainsLayer(collisionMask, other.gameObject.layer))
        {
            HealthBehaviourBase healthBehaviour = other.GetComponent<HealthBehaviourBase>();

            if (healthBehaviour != null)
            {
                healthBehaviour.TakeDamage(damageData.Damage);
            }
        }
    }
}