using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StartModeButton : MonoBehaviour
{
    [SerializeField] private Button _buttonStart;

    [SerializeField] private TMP_Text _Nknd;
    [SerializeField] private TMP_Text _NkndPanel;
    private int _NnkdValue = 120;

    private int number = 0;
    private int incrementAmount = 120;
    private int targetNumber = 1200;

    [SerializeField] private Valve _valve11;
    [SerializeField] private Valve _valve10;
    [SerializeField] private Valve _KGPT;

    [SerializeField] private Pump _IMND;
    [SerializeField] private Pump _IMNN;
    [SerializeField] private Pump _IMNU;
    [SerializeField] private Pump _IMPT;

    [SerializeField] private List<Tube> _tubePG = new List<Tube>();

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
        yield return new WaitForSeconds(2f);
        _IMND.ChangeColor(true);
        _IMNN.ChangeColor(true);
        _IMNU.ChangeColor(true);

        yield return new WaitForSeconds(5f);
        _valve11.ChangeColor(true);

        yield return new WaitForSeconds(5f);
        _valve10.ChangeColor(false);

        yield return new WaitForSeconds(5f);
        _IMPT.ChangeColor(true);

        yield return new WaitForSeconds(5f);
        _KGPT.ChangeColor(true);

        yield return new WaitForSeconds(2f);
        foreach (Tube tubePG in _tubePG)
        {
            tubePG.ChangeColor(true);
        }

        InvokeRepeating("IncreaseNumber", 2f, 2f);
    }

    void IncreaseNumber()
    {
        number += incrementAmount;
        if (number <= targetNumber)
        {
            _Nknd.text = number.ToString();
            _NkndPanel.text = number.ToString();
        }
        else
        {
            CancelInvoke("IncreaseNumber");
        }
    }
}

