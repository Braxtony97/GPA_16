using UnityEngine;
using UnityEngine.EventSystems;

public class ClickBehaviour : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _valveOpen;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -2 && _valveOpen.activeSelf)
            _valveOpen.SetActive(false);
        else if (eventData.pointerId == -2 && !_valveOpen.activeSelf)
            _valveOpen.SetActive(true);
    }
}

