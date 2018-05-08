using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneAttributeManager {

    public enum Rune { Energy, Despair, Blade, Swift };
    public enum RuneChar { HP, ATK, DEF, SPD, CriRate, CriDmag, Resistance, Accuracy };
    public List<int> R_Char;

    public int HP, ATK, DEF, SPD, CriRate, CriDmag, Resistance, Accuracy;
    public int MainChar;//主属性
    public int SecondChar1, SecondChar2, SecondChar3, SecondChar4;//副属性

    public RuneAttributeManager()
	{
	    RuneInitialization();
	}

	public void RuneInitialization()//符文生成时初始化
    {
        R_Char = new List<int>();
        for (int i = 0; i < 8; i++)
        {
            R_Char.Add(i);
        }

        //选出主属性
        MainChar = Random.Range(0, R_Char.Count);//MC : 0~7
        R_Char.Remove(MainChar);
        //选出副属1
        int s1 = Random.Range(0, R_Char.Count);//S1: 0~6
        SecondChar1 = R_Char[s1];
        R_Char.RemoveAt(s1);
        //选出副属2
        int s2 = Random.Range(0, R_Char.Count);//S2: 0~5
        SecondChar2 = R_Char[s2];
        R_Char.RemoveAt(s2);
        //选出副属3
        int s3 = Random.Range(0, R_Char.Count);//S3: 0~4
        SecondChar3 = R_Char[s3];
        R_Char.RemoveAt(s3);
        //选出副属4
        int s4 = Random.Range(0, R_Char.Count);//S3: 0~3
        SecondChar4 = R_Char[s4];
        R_Char.RemoveAt(s4);

        //主属性赋值
        switch (MainChar)
        {
            case (int)RuneChar.HP: HP = Random.Range(20, 26); break;
            case (int)RuneChar.ATK: ATK = Random.Range(20, 26); break;
            case (int)RuneChar.DEF: DEF = Random.Range(20, 26); break;
            case (int)RuneChar.SPD: SPD = Random.Range(20, 26); break;
            case (int)RuneChar.CriRate: CriRate = Random.Range(20, 26); break;
            case (int)RuneChar.CriDmag: CriDmag = Random.Range(20, 26); break;
            case (int)RuneChar.Resistance: Resistance = Random.Range(20, 26); break;
            case (int)RuneChar.Accuracy: Accuracy = Random.Range(20, 26); break;
        }

        //副属性1赋值
        switch (SecondChar1)
        {
            case (int)RuneChar.HP: HP = Random.Range(5, 11); break;
            case (int)RuneChar.ATK: ATK = Random.Range(5, 11); break;
            case (int)RuneChar.DEF: DEF = Random.Range(5, 11); break;
            case (int)RuneChar.SPD: SPD = Random.Range(5, 11); break;
            case (int)RuneChar.CriRate: CriRate = Random.Range(5, 11); break;
            case (int)RuneChar.CriDmag: CriDmag = Random.Range(5, 11); break;
            case (int)RuneChar.Resistance: Resistance = Random.Range(5, 11); break;
            case (int)RuneChar.Accuracy: Accuracy = Random.Range(5, 11); break;
        }

        //副属性2赋值
        switch (SecondChar2)
        {
            case (int)RuneChar.HP: HP = Random.Range(5, 11); break;
            case (int)RuneChar.ATK: ATK = Random.Range(5, 11); break;
            case (int)RuneChar.DEF: DEF = Random.Range(5, 11); break;
            case (int)RuneChar.SPD: SPD = Random.Range(5, 11); break;
            case (int)RuneChar.CriRate: CriRate = Random.Range(5, 11); break;
            case (int)RuneChar.CriDmag: CriDmag = Random.Range(5, 11); break;
            case (int)RuneChar.Resistance: Resistance = Random.Range(5, 11); break;
            case (int)RuneChar.Accuracy: Accuracy = Random.Range(5, 11); break;
        }

        //副属性3赋值
        switch (SecondChar3)
        {
            case (int)RuneChar.HP: HP = Random.Range(5, 11); break;
            case (int)RuneChar.ATK: ATK = Random.Range(5, 11); break;
            case (int)RuneChar.DEF: DEF = Random.Range(5, 11); break;
            case (int)RuneChar.SPD: SPD = Random.Range(5, 11); break;
            case (int)RuneChar.CriRate: CriRate = Random.Range(5, 11); break;
            case (int)RuneChar.CriDmag: CriDmag = Random.Range(5, 11); break;
            case (int)RuneChar.Resistance: Resistance = Random.Range(5, 11); break;
            case (int)RuneChar.Accuracy: Accuracy = Random.Range(5, 11); break;
        }

        //副属性4赋值
        switch (SecondChar4)
        {
            case (int)RuneChar.HP: HP = Random.Range(5, 11); break;
            case (int)RuneChar.ATK: ATK = Random.Range(5, 11); break;
            case (int)RuneChar.DEF: DEF = Random.Range(5, 11); break;
            case (int)RuneChar.SPD: SPD = Random.Range(5, 11); break;
            case (int)RuneChar.CriRate: CriRate = Random.Range(5, 11); break;
            case (int)RuneChar.CriDmag: CriDmag = Random.Range(5, 11); break;
            case (int)RuneChar.Resistance: Resistance = Random.Range(5, 11); break;
            case (int)RuneChar.Accuracy: Accuracy = Random.Range(5, 11); break;
        }
    }


}
