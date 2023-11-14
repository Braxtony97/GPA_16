using UnityEngine;
using UnityEngine.UI;

public class WorkModeButton : MonoBehaviour
{
    [SerializeField] private Button _buttonWork;
    [SerializeField] private GameObject _workModeButtons;

    private void OnEnable()
    {
        _buttonWork.onClick.AddListener(OnScriptButtonClick);
    }

    private void OnDisable()
    {
        _buttonWork.onClick.RemoveListener(OnScriptButtonClick);
    }

    void OnScriptButtonClick()
    {
        if (!_workModeButtons.activeSelf)
            _workModeButtons.SetActive(true);
        else
            _workModeButtons.SetActive(false);
    }
}
