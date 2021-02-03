using UnityEngine;

public class DestroyOnCollisionController : MonoBehaviour
{
    [SerializeField] private LayerMask collisionMask;

    private DestroyBehaviour destroyBehaviour;

    private void Awake()
    {
        destroyBehaviour = GetComponent<DestroyBehaviour>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Destroy this game object if the other game object is in the assigned destroy layer.
        if (Utilities.ContainsLayer(collisionMask, other.gameObject.layer))
        {
            destroyBehaviour.Destroy();
        }
    }
}