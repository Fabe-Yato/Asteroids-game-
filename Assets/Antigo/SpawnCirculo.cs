using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCirculo : MonoBehaviour{

    public GameObject prefabCirculo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //input da tecla enter, para dar spawn no circulo
        if(Input.GetKeyDown(KeyCode.Return)){
            Instantiate(prefabCirculo, new Vector3(0f, 0f, 0f), Quaternion.identity);
        }
    }
}
