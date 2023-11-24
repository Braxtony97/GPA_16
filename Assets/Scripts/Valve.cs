using UnityEngine;

public class Valve : MonoBehaviour, IColorChangeable
{
    [SerializeField] private SpriteRenderer _spriteRenderer;

    public void ChangeColor(bool Bool)
    {
        if (Bool)
            _spriteRenderer.color = Color.green;
        else
            _spriteRenderer.color = Color.red;
    }
}
