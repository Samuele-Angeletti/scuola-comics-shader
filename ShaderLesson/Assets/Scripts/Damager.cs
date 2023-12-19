using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] float damageAmount;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<Damageable>(out var damageable))
        {
            damageable.GiveDamage(damageAmount);
        }
    }
}
