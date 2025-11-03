using UnityEngine;

public class CarMovementSimple : MonoBehaviour
{
    [Header("Configurações de movimento")]
    public float speed = 5f;          // velocidade do carro
    public bool moveRight = true;     // define a direção: true = direita, false = esquerda

    void FixedUpdate()
    {
        float direction = moveRight ? 1f : -1f;
        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);
    }
}
