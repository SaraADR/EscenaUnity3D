using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apagado : MonoBehaviour {

    public Light fogata;

	// Use this for initialization
	void Start () {
        fogata = GetComponent<Light>();
        fogata.enabled=true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > 5)
        {
            fogata.enabled = false;
        }
	}
}
