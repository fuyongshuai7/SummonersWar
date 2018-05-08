using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : ICharAbility
{
    //角色自身能力值
    //
    int hp = 1000;
    int atk = 500;
    int def = 200;
    int spd = 110;
    int crirate = 70;
    int cridmg = 100;
    int resistance = 20;
    int accurcy = 50;
    //..................//

    public int HP
    {
        get
        {
            return hp;
        }
    }

    public int ATK
    {
        get
        {
            return atk;
        }
    }
    public int DEF
    {
        get
        {
            return def;
        }
    }
    public int SPD
    {
        get
        {
            return spd;
        }
    }
    public int CriRate
    {
        get
        {
            return crirate;
        }
    }
    public int CriDmag
    {
        get
        {
            return cridmg;
        }
    }
    public int Resistance
    {
        get
        {
            return resistance;
        }
    }
    public int Accuracy
    {
        get
        {
            return accurcy;
        }
    }
}
