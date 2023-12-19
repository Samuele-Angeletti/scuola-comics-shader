using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialTintAnimation : MonoBehaviour
{
    [SerializeField] float _fadeTintSpeed = 6;
    private Material _material;
    private Color _materialTintColor;

    private void Awake()
    {
        _materialTintColor = new Color(1, 0, 0, 0);
        _material = GetComponentInChildren<SpriteRenderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        if ( _materialTintColor.a > 0)
        {
            _materialTintColor.a = Mathf.Clamp01(_materialTintColor.a - _fadeTintSpeed * Time.deltaTime);
            _material.SetColor("_Tint", _materialTintColor);
        }
    }

    public void SetTintColor(Color color)
    {
        _materialTintColor = color;
        _material.SetColor("_Tint", _materialTintColor);
    }
}
