using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class BagTrop : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        BagTrag bagTrag = eventData.pointerDrag.GetComponent<BagTrag>();
        bagTrag.OriginParent = this.transform;
    }


}
