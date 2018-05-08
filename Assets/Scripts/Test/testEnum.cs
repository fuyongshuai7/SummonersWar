using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testEnum : MonoBehaviour {

    public enum RuneChar { HP, ATK, DEF, SPD, CriRate, CriDmag, Resistance, Accuracy};
    // Use this for initialization
    void Start()
    {
        Debug.Log((int)RuneChar.HP);
        Debug.Log((int)RuneChar.ATK);
        Debug.Log((int)RuneChar.DEF);
        Debug.Log((int)RuneChar.SPD);
        Debug.Log((int)RuneChar.CriRate);
        Debug.Log((int)RuneChar.CriDmag);
        Debug.Log((int)RuneChar.Resistance);
        Debug.Log((int)RuneChar.Accuracy);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
