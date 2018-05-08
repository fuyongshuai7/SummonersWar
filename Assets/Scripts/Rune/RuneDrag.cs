using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
//符文
public class RuneDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform OriginParent = null;//物件初始parent
    public Transform HighestParent;//最高阶层，让物件拖拉时保持在最前

    public void OnBeginDrag(PointerEventData eventData)
    {
        OriginParent = this.transform.parent;//存放初始paren位置
        this.transform.SetParent(HighestParent);//提高阶层，让物件在pannel之前 
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;//物件跟随滑鼠移动
        this.transform.GetComponent<CanvasGroup>().blocksRaycasts = false;//为了OnPointerEnter
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(OriginParent);//让物件回到初始paren上
        this.transform.position = OriginParent.position;//对齐物件
        this.transform.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
	private void Start()
	{
        HighestParent = GameObject.Find("HighestParent").transform;
	}
}
