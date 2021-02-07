﻿using UnityEngine;

public class DealDamageBehaviour : MonoBehaviour
{
    [SerializeField] private DamageData damageData;

    public void DealDamage(HealthBehaviour target)
    {
        target.TakeDamage(damageData.Damage);
    }
}