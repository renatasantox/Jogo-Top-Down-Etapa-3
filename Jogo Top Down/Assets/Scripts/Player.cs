using UnityEngine;

public class Player : Personagem
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    
    public Transform arma;

    private bool andando;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        andando = false;
        
        //direita
        if (arma.rotation.eulerAngles.z > -90 
            && arma.rotation.eulerAngles.z < 90)
        {
            spriteRenderer.flipX = false;
        }
        
        //esquerda
        if (arma.rotation.eulerAngles.z > 90 
            && arma.rotation.eulerAngles.z < 270)
        {
            spriteRenderer.flipX = true;
        }



        //movimento para a esquerda
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0, 0);  
            andando = true;
        }

        //movimento para a direita
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
            andando = true;
        }
        
        //movimento para a Cima
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, getVelocidade() * Time.deltaTime, 0); 
            andando = true;
        }
        
        //movimento para a Cima
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, getVelocidade() * Time.deltaTime, 0);  
            andando = true;
        }
        
        animator.SetBool("Andando", andando);
    }
}