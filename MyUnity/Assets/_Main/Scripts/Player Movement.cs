using Unity.VisualScripting;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{

    public float altura = 1.8f;
    public int edad = 20;
    public string nombre = "SebasG";
    public bool puedoVotar = true;

    public GameObject gameObject;
    public Rigidbody2D rigidbody2D;
    public Collider2D collider2D;
    public SpriteRenderer spriteRenderer;
    public Transform transform;
    private void Start()
    {
        Debug.Log(" Hola: " + nombre + " tu edad es: " + edad + " tu altura es: " + altura);
        rigidbody2D.simulated = false;
        spriteRenderer.color = Color.blue;
        transform.position = new Vector3(4, 2.5f, 0);  
    }
    private void Update()
    {

    }
}
    