using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberAndType : MonoBehaviour {
    
    public int Number; //符文位置
    public int Type; //符文类型
    string MyName = "";

	private void Awake()
	{
        MyName = this.name;
        SetNumberAndType();
	}
	private void SetNumberAndType()
    {
        //Rune_Energy
        if (MyName == "Rune_Energy1" || MyName == "Rune_Energy1(Clone)")
        {
            Number = 1;
            Type = 0;
        }
        else if (MyName == "Rune_Energy2" || MyName == "Rune_Energy2(Clone)")
        {
            Number = 2;
            Type = 0;
        }
        else if (MyName == "Rune_Energy3"|| MyName == "Rune_Energy3(Clone)")
        {
            Number = 3;
            Type = 0;
        }
        else if (MyName == "Rune_Energy4"|| MyName == "Rune_Energy4(Clone)")
        {
            Number = 4;
            Type = 0;
        }
        else if (MyName == "Rune_Energy5"|| MyName == "Rune_Energy5(Clone)")
        {
            Number = 5;
            Type = 0;
        }
        else if (MyName == "Rune_Energy6"|| MyName == "Rune_Energy6(Clone)")
        {
            Number = 6;
            Type = 0;
        }

        //Rune_Despair
        else if (MyName == "Rune_Despair1" || MyName == "Rune_Despair1(Clone)")
        {
            Number = 1;
            Type = 1;
        }
        else if (MyName == "Rune_Despair2"|| MyName == "Rune_Despair2(Clone)")
        {
            Number = 2;
            Type = 1;
        }
        else if (MyName == "Rune_Despair3"|| MyName == "Rune_Despair3(Clone)")
        {
            Number = 3;
            Type = 1;
        }
        else if (MyName == "Rune_Despair4"|| MyName == "Rune_Despair4(Clone)")
        {
            Number = 4;
            Type = 1;
        }
        else if (MyName == "Rune_Despair5"|| MyName == "Rune_Despair5(Clone)")
        {
            Number = 5;
            Type = 1;
        }
        else if (MyName == "Rune_Despair6"|| MyName == "Rune_Despair6(Clone)")
        {
            Number = 6;
            Type = 1;
        }

        //Rune_Blade
        else if (MyName == "Rune_Blade1"|| MyName == "Rune_Blade1(Clone)")
        {
            Number = 1;
            Type = 2;
        }
        else if (MyName == "Rune_Blade2"|| MyName == "Rune_Blade2(Clone)")
        {
            Number = 2;
            Type = 2;
        }
        else if (MyName == "Rune_Blade3"|| MyName == "Rune_Blade3(Clone)")
        {
            Number = 3;
            Type = 2;
        }
        else if (MyName == "Rune_Blade4"|| MyName == "Rune_Blade4(Clone)")
        {
            Number = 4;
            Type = 2;
        }
        else if (MyName == "Rune_Blade5"|| MyName == "Rune_Blade5(Clone)")
        {
            Number = 5;
            Type = 2;
        }
        else if (MyName == "Rune_Blade6"|| MyName == "Rune_Blade6(Clone)")
        {
            Number = 6;
            Type = 2;
        }

        //Rune_Swift
        else if (MyName == "Rune_Swift1"|| MyName == "Rune_Swift1(Clone)")
        {
            Number = 1;
            Type = 3;
        }
        else if (MyName == "Rune_Swift2"|| MyName == "Rune_Swift2(Clone)")
        {
            Number = 2;
            Type = 3;
        }
        else if (MyName == "Rune_Swift3"|| MyName == "Rune_Swift3(Clone)")
        {
            Number = 3;
            Type = 3;
        }
        else if (MyName == "Rune_Swift4"|| MyName == "Rune_Swift4(Clone)")
        {
            Number = 4;
            Type = 3;
        }
        else if (MyName == "Rune_Swift5"|| MyName == "Rune_Swift5(Clone)")
        {
            Number = 5;
            Type = 3;
        }
        else if (MyName == "Rune_Swift6"|| MyName == "Rune_Swift6(Clone)")
        {
            Number = 6;
            Type = 3;
        }
    }
}
