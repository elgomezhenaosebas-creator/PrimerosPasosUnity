using Unity.VisualScripting;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5f;
    [SerializeField] private float _jumpForce = 6f;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Groundcheck _groundcheck;

    private void FixedUpdate() // se inicia en el primer frame
    {
        if (_groundcheck.isGround)
        { 
                if (Input.GetKey(KeyCode.Space))
                {
                   _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);

                   Debug.Log("oprimi la tecla");
                }      
           _rigidbody2D.velocity = new Vector2 (1 * _movementSpeed, _rigidbody2D.velocity.y);

        }
    }

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
} 
