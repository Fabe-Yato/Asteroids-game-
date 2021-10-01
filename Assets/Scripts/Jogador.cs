using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public Rigidbody2D meuRigidbody;
    public float aceleracao = 1.0f;
    public float velocidadeAngular = 180.0f;
    public float velocidadeMaxima = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            Vector3 direcao = transform.up * aceleracao;
            meuRigidbody.AddForce(direcao, ForceMode2D.Force);
        }
        
        if(Input.GetKey(KeyCode.LeftArrow)){
            meuRigidbody.rotation += velocidadeAngular * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            meuRigidbody.rotation -= velocidadeAngular * Time.deltaTime;
        }
        if(meuRigidbody.velocity.magnitude > velocidadeMaxima){
            meuRigidbody.velocity = Vector2.ClampMagnitude(
                meuRigidbody.velocity, velocidadeMaxima);
        }
    }
}
