using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectState : MonoBehaviour
{
    [SerializeField] private Button _buttonOpen;
    [SerializeField] private Button _buttonClose;
    [SerializeField] private Valve _valve;

    private void OnEnable()
    {
        _buttonOpen.onClick.AddListener(ChangeColorGreen);
        _buttonClose.onClick.AddListener(ChangeColorRed);
    }

    private void OnDisable()
    {
        _buttonOpen.onClick.RemoveListener(ChangeColorGreen);
        _buttonClose.onClick.AddListener(ChangeColorRed);
    }

    void ChangeColorGreen()
    {
        Invoke("ChangeGreenInvoke", 2f);
    }

    void ChangeColorRed()
    {
        Invoke("ChangeRedInvoke", 2f);
    }

    void ChangeGreenInvoke()
    {
        _valve.ChangeColor(true);
    }

    void ChangeRedInvoke()
    {
        _valve.ChangeColor(false);
    }
}
