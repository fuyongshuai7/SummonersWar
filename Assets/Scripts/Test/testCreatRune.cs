using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCreatRune : MonoBehaviour {
    public List<GameObject> Energy;
    public List<GameObject> Despair;
    public List<GameObject> Blade;
    public List<GameObject> Swift;

    public Transform parent;

    public GameObject EnergyRuneBag_Panel;
    public GameObject DespairRuneBag_Panel;
    public GameObject BladeRuneBag_Panel;
    public GameObject SwiftRuneBag_Panel;


	public void CR()//关卡结束时
    {
        int runeType = Random.Range(0, 4);//先选出符文类型
        int number = Random.Range(0,6);//选出符文位置

        switch (runeType )
        {
            case 0 :
                for (int i = 0; i < EnergyRuneBag_Panel.transform.childCount; i++)
                {
                    if (EnergyRuneBag_Panel.transform.GetChild(i).childCount <1)
                    {
                        parent = EnergyRuneBag_Panel.transform.GetChild(i);
                        break; 
                    }
                }
                Instantiate(Energy[number],parent);//Energy
                break;
            case 1:
                for (int i = 0; i < DespairRuneBag_Panel.transform.childCount; i++)
                {
                    if (DespairRuneBag_Panel.transform.GetChild(i).childCount < 1)
                    {
                        parent = DespairRuneBag_Panel.transform.GetChild(i);
                        break;
                    }
                }
                Instantiate(Despair[number], parent);//Despair
                break;
            case 2:
                for (int i = 0; i < BladeRuneBag_Panel.transform.childCount; i++)
                {
                    if (BladeRuneBag_Panel.transform.GetChild(i).childCount < 1)
                    {
                        parent = BladeRuneBag_Panel.transform.GetChild(i);
                        break;
                    }
                }
                Instantiate(Blade[number], parent);//Blade
                break;
            case 3:
                for (int i = 0; i < SwiftRuneBag_Panel.transform.childCount; i++)
                {
                    if (SwiftRuneBag_Panel.transform.GetChild(i).childCount < 1)
                    {
                        parent = SwiftRuneBag_Panel.transform.GetChild(i);
                        break;
                    }
                }
                Instantiate(Swift[number], parent);//Swift
                break;
        }
    }
}
