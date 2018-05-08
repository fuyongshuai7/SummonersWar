using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warlord : ICharAbility
{
    //角色自身能力值
    //
    int hp = 1800;
    int atk = 600;
    int def = 400;
    int spd = 105;
    int crirate = 20;
    int cridmg = 50;
    int resistance = 50;
    int accurcy = 20;
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