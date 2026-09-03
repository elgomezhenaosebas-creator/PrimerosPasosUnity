using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            _playerStats.SumarVida(10);
        }
    }
}

