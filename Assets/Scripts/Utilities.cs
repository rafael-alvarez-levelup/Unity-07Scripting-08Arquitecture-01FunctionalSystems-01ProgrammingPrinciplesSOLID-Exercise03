using UnityEngine;

public class Utilities : MonoBehaviour
{
    #region Random

    public static int GetRandomIndex(int min, int max)
    {
        return Random.Range(min, max);
    }

    #endregion

    #region Layers

    public static bool ContainsLayer(int layer, int targetLayer) => layer == (layer | (1 << targetLayer));

    #endregion
}