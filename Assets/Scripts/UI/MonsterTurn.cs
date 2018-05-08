using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MonsterTurn : MonoBehaviour ,IPointerEnterHandler, IPointerExitHandler {

    public GameObject Monster;

    private bool OnButton = false;

    public void TurnRight()
    {
        Monster.transform.Rotate(0, -1, 0);
    }

    public void TurnLeft()
    {
        Monster.transform.Rotate(0, 1, 0);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        OnButton = true;
        Debug.Log("OnButton : " + OnButton);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OnButton = false;
        Debug.Log("OnButton : " + OnButton);
    }
	private void Update()
	{
        if (OnButton)
        {
            if (Input.GetMouseButton(0) && transform.name =="TurnRight")
            {
                TurnRight();
            }
            if (Input.GetMouseButton(0) && transform.name == "TurnLeft")
            {
                TurnLeft();
            }
        }
	}
}
