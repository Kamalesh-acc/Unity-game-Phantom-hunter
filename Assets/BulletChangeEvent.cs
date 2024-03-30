using UnityEngine;
using System;

public class BulletChangeEvent : MonoBehaviour
{
    public static event Action<GameObject> OnBulletChange;

    public static void TriggerBulletChange(GameObject newBulletPrefab)
    {
        OnBulletChange?.Invoke(newBulletPrefab);
    }
}
