using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class XpModeButton : MonoBehaviour
{

    [SerializeField] private Button _buttonHp;
    [SerializeField] private TMP_Text _statusGpaText;

    private void OnEnable()
    {
        _buttonHp.onClick.AddListener(OnScriptButtonClick);
    }

    private void OnDisable()
    {
        _buttonHp.onClick.RemoveListener(OnScriptButtonClick);
    }

    void OnScriptButtonClick()
    {
        StartCoroutine(CoroutineReadyHp());
        StopCoroutine(CoroutineReadyHp());
    }

    private IEnumerator CoroutineReadyHp()
    {
        yield return new WaitForSeconds(5f);
        _statusGpaText.text = $"Холодный резерв \n Готов к ХП";
    }
}
