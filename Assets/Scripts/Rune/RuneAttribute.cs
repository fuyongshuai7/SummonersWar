using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneAttribute : MonoBehaviour {

    public int HP, ATK, DEF, SPD, CriRate, CriDmag, Resistance, Accuracy;
    public int MainChar;//主属性
    public int SecondChar1, SecondChar2, SecondChar3, SecondChar4;//副属性

    private void Awake()
    {
        RuneAttributeManager ra = new RuneAttributeManager();

        this.HP = ra.HP;
        this.ATK = ra.ATK;
        this.DEF = ra.DEF;
        this.SPD = ra.SPD;
        this.CriRate = ra.CriRate;
        this.CriDmag = ra.CriDmag;
        this.Resistance = ra.Resistance;
        this.Accuracy = ra.Accuracy;
        this.MainChar = ra.MainChar;
        this.SecondChar1 = ra.SecondChar1;
        this.SecondChar2 = ra.SecondChar2;
        this.SecondChar3 = ra.SecondChar3;
        this.SecondChar4 = ra.SecondChar4;
    }

}
