using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorcerer : ICharAbility
{
    //角色自身能力值
    //
    int hp = 1000;
    int atk = 800;
    int def = 100;
    int spd = 100;
    int crirate = 50;
    int cridmg = 200;
    int resistance = 70;
    int accurcy = 70;
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