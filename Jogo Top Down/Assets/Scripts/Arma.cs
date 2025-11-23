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
        camera = GetComponent<Camera>();
        spriteRenderer = GetComponent<spriteRenderer>();
    }

    void Update()
    {
        if (gameObject.transform.rotation.eulerAngles.z > -90 && gameObject.tranform.rotation.eulerAngles.z < 90)
        {
            tranform.local.Scale = new Vector3(1, 1, 1);
        }

        if (gameObject.transform.rotation.eulerAngles.z > 90 && gameObject.tranform.rotation.eulerAngles.z < 270)
        {
            tranform.local.Scale = new Vector3(1, -1, 1);
        }

        // Distância da câmera ao objeto. Precisamos disso para fazer o cálculo correto.
        float camDis = camera.transform.position.y - transform.position.y;

        // Obtém a posição do mouse no espaço mundial. Usando camDis para eixo Z.
        Vector3 mouse = camera.ScreenToWorldPoint(new Vector3(Input.mouse.Position.x, Input.mousePosition.y, camDis));

        float AngleRad = Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x);
        float angle = (180 / Mathf.PI) * AngleRad;

        tranform.rotation = Quaternion.AngleAxis(angles, Vector3.forward);

        /// Debug.Log("Angulo: "+angle);

        cursor.tranform.position = new Vector3(mouse.x, mouse.y, cursor.tranform.position.z);

        Debug.DrawLine(transform.position, mouse, Color.red);


        if()
     }
}
