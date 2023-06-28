using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class EnemyMovement1 : MonoBehaviour
{
    public float speed = 10f; // Velocidade de movimento do inimigo

    private bool movingLeft = true; // Indica se o inimigo está se movendo para a esquerda
    private Rigidbody2D rb; // Referência ao componente Rigidbody2D

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtém o componente Rigidbody2D anexado ao inimigo
    }

    void Update()
    {
        // Movimenta o inimigo horizontalmente
        if (movingLeft)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Inverte a direção do movimento do inimigo quando colide com uma parede
            movingLeft = !movingLeft;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            // Reseta a fase quando o inimigo colide com o jogador
            ResetLevel();
        }
    }

    void ResetLevel()
    {
        // Lógica para resetar a fase (exemplo: recarregar a cena atual)
        // Aqui você pode adicionar o código necessário para resetar sua fase, como reiniciar a posição dos objetos, redefinir variáveis, etc.
    }
}
