using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube : MonoBehaviour, IColorChangeable
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private SpriteRenderer _valveColor;
    [SerializeField] private GameObject _valveOpen;

    public void ChangeColor(bool Bool)
    {
        if (Bool)
            _spriteRenderer.color = new Color(0, 0.847f, 1, 1);
        else
            _spriteRenderer.color = Color.yellow;
    }

    void Update()
    {
        if (_valveOpen.activeInHierarchy)
            ChangeTubeColor();
    }

    void ChangeTubeColor()
    {
        if (_valveColor.color == Color.green)
            _spriteRenderer.color = new Color(0, 0.847f, 1, 1);
        else
            _spriteRenderer.color = Color.yellow;
    }
}
