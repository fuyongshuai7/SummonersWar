using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePage : MonoBehaviour {
    public GameObject MessagePanel;
    public GameObject SkillPanel;
    public GameObject RunePanel;

    //符文种类分页
    public GameObject EnergeBagScrollView;
    public GameObject DespairBagScrollView;
    public GameObject BladeBagScrollView;
    public GameObject SwiftScrollView;

    //角色信息页
    public void Page_Massege()
    {
        MessagePanel.SetActive(true);
        RunePanel.SetActive(false);
        SkillPanel.SetActive(false);
    }

    //技能页
    public void Page_Skill()
    {

        MessagePanel.SetActive(false);
        RunePanel.SetActive(false);
        SkillPanel.SetActive(true);
    }

    //符文页
    public void Page_Rune()
    {

        MessagePanel.SetActive(false);
        RunePanel.SetActive(true);
        SkillPanel.SetActive(false);
    }

    //祝福符文页
    public void Page_Rune_Energy()
    {
        EnergeBagScrollView.SetActive(true);
        DespairBagScrollView.SetActive(false);
        BladeBagScrollView.SetActive(false);
        SwiftScrollView.SetActive(false);
    }

    //绝望符文页
    public void Page_Rune_Despair()
    {
        EnergeBagScrollView.SetActive(false);
        DespairBagScrollView.SetActive(true);
        BladeBagScrollView.SetActive(false);
        SwiftScrollView.SetActive(false);
    }

    //刀刃符文页
    public void Page_Rune_Blade()
    {
        EnergeBagScrollView.SetActive(false);
        DespairBagScrollView.SetActive(false);
        BladeBagScrollView.SetActive(true);
        SwiftScrollView.SetActive(false);
    }

    //迅速符文页
    public void Page_Rune_Swift()
    {
        EnergeBagScrollView.SetActive(false);
        DespairBagScrollView.SetActive(false);
        BladeBagScrollView.SetActive(false);
        SwiftScrollView.SetActive(true);
    }
}
