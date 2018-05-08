using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunePanelNumber : MonoBehaviour {

    //符文插槽编号，用来判断符文是否放对位置
    public int Number;

	private void Awake()
	{
        SetRunePanelNumber();
	}

    private void SetRunePanelNumber()
    {
        string MyName = transform.name;
        if (MyName == "Rune1")
        {
            Number = 1;
        }
        else if (MyName == "Rune2")
        {
            Number = 2;
        }
        else if (MyName == "Rune3")
        {
            Number = 3;
        }
        else if (MyName == "Rune4")
        {
            Number = 4;
        }
        else if (MyName == "Rune5")
        {
            Number = 5;
        }
        else if (MyName == "Rune6")
        {
            Number = 6;
        }
    }
}
