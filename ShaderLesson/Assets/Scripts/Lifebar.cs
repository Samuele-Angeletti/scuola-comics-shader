using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifebar : MonoBehaviour
{
    [SerializeField] Slider slider;
    float _maxLife;
    internal void Initialize(float maxLife)
    {
        _maxLife = maxLife;
        slider.value = 1;
    }

    internal void UpdateBar(float currentLife)
    {
        slider.value = currentLife / _maxLife;
    }

}
