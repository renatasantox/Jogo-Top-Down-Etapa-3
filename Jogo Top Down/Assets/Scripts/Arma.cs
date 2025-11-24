using UnityEditor;
using UnityEngine;

public class Arma : MonoBehaviour
{

    public Transform saidaDeTiro;

    public GameObject bala;

    public float intervaloDeDisparo = 0.2f;

    private float tempoDeDisparo = 0;

    private Camera camera;
    public GameObject cursor;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        camera = Camera.main;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
       

        // Dist�ncia da c�mera ao objeto. Precisamos disso para fazer o c�lculo correto.
        float camDis = camera.transform.position.y - transform.position.y;

        // Obt�m a posi��o do mouse no espa�o mundial. Usando camDis para eixo Z.
        Vector3 mouse = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDis));

        float AngleRad = Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x);
        float angle = (180 / Mathf.PI) * AngleRad;

        transform.rotation = Quaternion.AngleAxis( angle, Vector3.forward);

        /// Debug.Log("Angulo: "+angle);

        cursor.transform.position = new Vector3(mouse.x, mouse.y, cursor.transform.position.z);

        Debug.DrawLine(transform.position, mouse, Color.red);


        if(tempoDeDisparo <= 0 && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Bala disparada");

            GameObject b = Instantiate(this.bala, saidaDeTiro.position, saidaDeTiro.rotation);

            tempoDeDisparo = intervaloDeDisparo;
        }


        if(tempoDeDisparo > 0)
        {
            tempoDeDisparo -= Time.deltaTime;
        }



     }
}
