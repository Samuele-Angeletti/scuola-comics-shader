using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] float maxLife;
    [SerializeField] Lifebar lifebar;
    [Header("VFX")]
    [SerializeField] Color onHit;
    [SerializeField] Color onHeal;

    float _currentLife;
    MaterialTintAnimation _materialTintAnimation;
    private void Awake()
    {
        _currentLife = maxLife;
        lifebar.Initialize(maxLife);
        _materialTintAnimation = GetComponent<MaterialTintAnimation>();
    }

    public void GiveDamage(float amount)
    {
        _currentLife -= amount;
        if (_currentLife < 0)
        {
            Destroy(gameObject);
        }
        else
            _materialTintAnimation.SetTintColor(onHit);
    }

    public void Heal(float amount)
    {
        _currentLife = Mathf.Clamp(_currentLife + amount, 0, maxLife);
        _materialTintAnimation.SetTintColor(onHeal);
    }

    private void Update()
    {
        lifebar.UpdateBar(_currentLife);
    }
}
