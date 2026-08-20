using UnityEngine;

public class TrampaMortal : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           Destroy(collision.gameObject);
            Debug.Log("El jugador ha sido destruido por la trampa mortal.");
        }
    } 
}
 