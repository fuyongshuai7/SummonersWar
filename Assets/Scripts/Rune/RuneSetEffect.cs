using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuneSetEffect : MonoBehaviour
{
    public GameObject Rune1;
    public GameObject Rune2;
    public GameObject Rune3;
    public GameObject Rune4;
    public GameObject Rune5;
    public GameObject Rune6;

    public int Type_Energy;
    public int Type_Despair;
    public int Type_Blade;
    public int Type_Swift;

    private string textEnergy = "";
    private string textDespair = "";
    private string textBlade = "";
    private string textSwift = "";

    //Text文字显示
    public void ToText()
    {
        SetEffect();

        switch (Type_Energy)
        {
            case 0: textEnergy = ""; break;
            case 1: textEnergy = ""; break;
            case 2: textEnergy = "体力 : + 15%\n"; break;
            case 3: textEnergy = "体力 : + 15%\n"; break;
            case 4: textEnergy = "体力 : + 30%\n"; break;
            case 5: textEnergy = "体力 : + 30%\n"; break;
            case 6: textEnergy = "体力 : + 45%\n"; break;
        }


        switch (Type_Despair)
        {
            case 0: textDespair = ""; break;
            case 1: textDespair = ""; break;
            case 2: textDespair = ""; break;
            case 3: textDespair = ""; break;
            case 4: textDespair = "晕眩 : + 30%\n"; break;
            case 5: textDespair = "晕眩 : + 30%\n"; break;
            case 6: textDespair = "晕眩 : + 30%\n"; break;
        }


        switch (Type_Blade)
        {
            case 0: textBlade = ""; break;
            case 1: textBlade = ""; break;
            case 2: textBlade = "暴击 : + 15%\n"; break;
            case 3: textBlade = "暴击 : + 15%\n"; break;
            case 4: textBlade = "暴击 : + 30%\n"; break;
            case 5: textBlade = "暴击 : + 30%\n"; break;
            case 6: textBlade = "暴击 : + 45%\n"; break;
        }

        switch (Type_Swift)
        {
            case 0: textSwift = ""; break;
            case 1: textSwift = ""; break;
            case 2: textSwift = ""; break;
            case 3: textSwift = ""; break;
            case 4: textSwift = "速度 : + 20\n"; break;
            case 5: textSwift = "速度 : + 20\n"; break;
            case 6: textSwift = "速度 : + 20\n"; break;
        }
        transform.GetComponent<Text>().text = textEnergy + textDespair + textBlade + textSwift;
    }

    //套装属性
    public void SetEffect()
    {
        TypeReset();
        //rune1
        if (Rune1.transform.childCount == 2)
        {
            int t = Rune1.transform.GetChild(1).GetComponent<NumberAndType>().Type;
            switch (t)
            {
                case 0: Type_Energy += 1; break;
                case 1: Type_Despair += 1; break;
                case 2: Type_Blade += 1; break;
                case 3: Type_Swift += 1; break;
            }
        }
        //rune2
        if (Rune2.transform.childCount == 2)
        {
            int t = Rune2.transform.GetChild(1).GetComponent<NumberAndType>().Type;
            switch (t)
            {
                case 0: Type_Energy += 1; break;
                case 1: Type_Despair += 1; break;
                case 2: Type_Blade += 1; break;
                case 3: Type_Swift += 1; break;
            }
        }
        //rune3
        if (Rune3.transform.childCount == 2)
        {
            int t = Rune3.transform.GetChild(1).GetComponent<NumberAndType>().Type;
            switch (t)
            {
                case 0: Type_Energy += 1; break;
                case 1: Type_Despair += 1; break;
                case 2: Type_Blade += 1; break;
                case 3: Type_Swift += 1; break;
            }
        }
        //rune4
        if (Rune4.transform.childCount == 2)
        {
            int t = Rune4.transform.GetChild(1).GetComponent<NumberAndType>().Type;
            switch (t)
            {
                case 0: Type_Energy += 1; break;
                case 1: Type_Despair += 1; break;
                case 2: Type_Blade += 1; break;
                case 3: Type_Swift += 1; break;
            }
        }
        //rune5
        if (Rune5.transform.childCount == 2)
        {
            int t = Rune5.transform.GetChild(1).GetComponent<NumberAndType>().Type;
            switch (t)
            {
                case 0: Type_Energy += 1; break;
                case 1: Type_Despair += 1; break;
                case 2: Type_Blade += 1; break;
                case 3: Type_Swift += 1; break;
            }
        }
        //rune6
        if (Rune6.transform.childCount == 2)
        {
            int t = Rune6.transform.GetChild(1).GetComponent<NumberAndType>().Type;
            switch (t)
            {
                case 0: Type_Energy += 1; break;
                case 1: Type_Despair += 1; break;
                case 2: Type_Blade += 1; break;
                case 3: Type_Swift += 1; break;
            }
        }
       
    }

    private void TypeReset()
    {
        Type_Energy = 0;
        Type_Despair = 0;
        Type_Blade = 0;
        Type_Swift = 0;
    }
}
