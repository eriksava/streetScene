using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrasladarObjeto : MonoBehaviour {

    public float metrosPorSegundo = 1;

    private void Update()
    {
        transform.Translate(0, 0, metrosPorSegundo * Time.deltaTime);
    }


}
