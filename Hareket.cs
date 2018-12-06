using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour {
    //Hiz degeri
    public int hiz = 0;
    //Create rigidbody component as r_body
    private Rigidbody r_body;

	// Use this for initialization
	void Start () {
        //Get component's rigidbody as r_body
        r_body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
        //Input frame basi update olur
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            //W tusu ile ileri gitme (hiz degeri kadaR)
            r_body.AddForce(0, 0, hiz);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //S tusu ile geri gitme (hiz degeri kadaR)
            r_body.AddForce(0, 0, -hiz);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //A tusu ile sola gitme (hiz degeri kadaR)
            r_body.AddForce(hiz, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //D tusu ile saga gitme (hiz degeri kadaR)
            r_body.AddForce(-hiz, 0, hiz);
        }
    }
}
