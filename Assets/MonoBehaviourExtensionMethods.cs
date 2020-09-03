using UnityEngine;

public static class MonoBehaviourExtensionMethods
{
    public static void Deactivate(this MonoBehaviour mb)
    {
        mb.gameObject.SetActive(false);
    }
}