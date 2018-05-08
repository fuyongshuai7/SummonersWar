using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
 
//Energy背包
public class BagDrop : MonoBehaviour, IDropHandler
{
    private bool AfterOnDrop = false;

    public void OnDrop(PointerEventData eventData)
    {
        //当符文拉回背包时，自动排列
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).childCount >= 1)
            {
                continue;
            }
            if (eventData.pointerDrag != null)
            {
                RuneDrag NewParent = eventData.pointerDrag.GetComponent<RuneDrag>();
                NewParent.OriginParent = transform.GetChild(i);
                break;
            }
        }
        AfterOnDrop = true;
    }
    //背包排列
    public void RuneBagArray()
    {
        for (int i = 0; i < transform.childCount-1; i++)
        {
            //假如第i个的 子物件数 小于 第i+1个
            if (this.transform.GetChild(i).childCount < this.transform.GetChild(i + 1).childCount)
            {
                this.transform.GetChild(i + 1).GetChild(0).SetParent(transform.GetChild(i));
                transform.GetChild(i).GetChild(0).localPosition = new Vector3(0, 0);
            }

        }
    }
	private void Update()
	{
		 if (Input .GetMouseButtonUp(0))
        {
            RuneBagArray();
        }
        if (AfterOnDrop)
        {
            //Text文字显示套装效果
            RuneSetEffect Text_SetEffect = GameObject.Find("Text (1)").GetComponent<RuneSetEffect>();
            Text_SetEffect.ToText();
            //Debug.Log("Type_Energy " + Text_SetEffect.Type_Energy);
            AfterOnDrop = false;
        }
	}
}
