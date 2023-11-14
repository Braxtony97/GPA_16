using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartModeButton : MonoBehaviour
{
    [SerializeField] private Button _buttonStart;
    [SerializeField] private SpriteRenderer _valve11;
    [SerializeField] private SpriteRenderer _valve10;

    private void OnEnable()
    {
        _buttonStart.onClick.AddListener(OnScriptButtonClick);
    }

    private void OnDisable()
    {
        _buttonStart.onClick.RemoveListener(OnScriptButtonClick);
    }

    void OnScriptButtonClick()
    {
        StartCoroutine(CoroutineSimple());
        StopCoroutine(CoroutineSimple());
    }

    private IEnumerator CoroutineSimple()
    {
        yield return new WaitForSeconds(3f);
        _valve11.color = Color.green;
        yield return new WaitForSeconds(2f);
        _valve10.color = Color.red;
        
    }
}
