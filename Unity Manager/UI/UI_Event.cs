using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
public class UI_Event : MonoBehaviour, IPointerClickHandler,IDragHandler
{
    public Action<PointerEventData> OnClickHandler = null;              //Action�� ���ش�
    public Action<PointerEventData> OnDragHandler = null;


    public void OnDrag(PointerEventData eventData)                      //interface
    {
        if (OnDragHandler == null)
        {
            OnDragHandler.Invoke(eventData);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (OnClickHandler == null)
        {
            OnClickHandler.Invoke(eventData);
        }
    }
}
