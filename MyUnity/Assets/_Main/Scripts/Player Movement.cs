using Unity.VisualScripting;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5f;
    [SerializeField] private float _jumpForce = 5f;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Groundcheck _groundcheck;

    private void FixedUpdate() // se inicia en el primer frame
    {
        if (_groundcheck.isGround)
        { 
                if (Input.GetKey(KeyCode.Space))
                {
                   _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Force);

                   Debug.Log("oprimi la tecla");
                }      
           _rigidbody2D.velocity = Vector2.right * _movementSpeed;

        }
    }

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
} 
