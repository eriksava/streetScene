using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorNuevo : MonoBehaviour {

    public Vector3 nuevo = new Vector3(0, 0, 0);
	
	// Update is called once per frame
	void Update () {

        transform.position = nuevo;

		
	}
}
