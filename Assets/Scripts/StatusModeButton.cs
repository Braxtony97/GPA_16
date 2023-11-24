using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusModeButton : MonoBehaviour
{
    [SerializeField] private Button _buttonStatus;
    [SerializeField] private GameObject _statusModeButtons;

    private void OnEnable()
    {
        _buttonStatus.onClick.AddListener(OnScriptButtonClick);
    }

    private void OnDisable()
    {
        _buttonStatus.onClick.RemoveListener(OnScriptButtonClick);
    }

    void OnScriptButtonClick()
    {
        if (!_statusModeButtons.activeSelf)
            _statusModeButtons.SetActive(true);
        else
            _statusModeButtons.SetActive(false);
    }
}
