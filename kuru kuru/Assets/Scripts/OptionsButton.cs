using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OptionsButton : Selectable, IPointerClickHandler
{
    [SerializeField] private OptionsMenuController owner;

    public void OnPointerClick(PointerEventData eventData)
    {
        owner.HandleClick();
    }
}
