using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class BagTrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform OriginParent = null;
    public void OnBeginDrag(PointerEventData eventData)
    {
        OriginParent = transform.parent;//存放初始paren位置
        transform.SetParent(transform.parent.parent);//提高阶层，让物件在pannel之前
        transform.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;//物件随鼠标移动
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(OriginParent);//让物件回到初始paren上
        transform.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
