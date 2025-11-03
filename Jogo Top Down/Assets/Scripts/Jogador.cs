using System;
using UnityEngine;

public class Jogador : Personagem
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) //Esquerda
        {
            transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.D)) //Direita
        {
            transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.W)) //Cima
        {
            transform.position += new Vector3(0, getVelocidade() * Time.deltaTime, 0);
        }
        
        if (Input.GetKey(KeyCode.S)) //Baixo
        {
            transform.position -= new Vector3(0, getVelocidade() * Time.deltaTime, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Inimigo")
        {
            int vidas = getVidas() - 1;
            setVidas(vidas);
        }
    }
}
