using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Text.RegularExpressions;

//符文插槽
public class RuneDrop : MonoBehaviour ,IDropHandler ,IPointerEnterHandler ,IPointerExitHandler {

    public bool RuneMatch = false;
    private bool AfterOnDrop = false;

    public void OnDrop(PointerEventData eventData)
    {
        if (this.transform.childCount <= 1 && RuneMatch)//同一个符文槽只能放一个符文
        {
            RuneDrag NewParent = eventData.pointerDrag.GetComponent<RuneDrag>();
            NewParent.OriginParent = this.transform;
        }

        AfterOnDrop = true;

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //符文位置对才能放
        if (eventData.pointerDrag != null)
        {
            int RuneNumber = eventData.pointerDrag.transform.GetComponent<NumberAndType>().Number;
            if (RuneNumber == transform.GetComponent<RunePanelNumber>().Number)
            {
                RuneMatch = true;
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        RuneMatch = false;
    }

	private void Update()
	{
        if (AfterOnDrop)
        {
            //Text文字显示套装效果
            RuneSetEffect Text_SetEffect = GameObject.Find("Text (1)").GetComponent<RuneSetEffect>();
            //Debug.Log("Type_Energy " + Text_SetEffect.Type_Energy);
            Text_SetEffect.ToText();
            AfterOnDrop = false;
        }
	}

}
