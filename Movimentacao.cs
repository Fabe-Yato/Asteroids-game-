using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movimentacao : MonoBehaviour{
 
    public float velocidade = 10.0f;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        //movimentação de objeto em unity, os três valores representam as coordenadas X, Y e Z respectivamente
        
        //transform.position += new Vector3(velocidade * Time.deltaTime, 0.0f, 0.0f);
 
        //input de teclas na unity
        if(Input.GetKey(KeyCode.Space)){
            transform.position += new Vector3(velocidade * Time.deltaTime, 0.0f, 0.0f);

        }
    }
}
