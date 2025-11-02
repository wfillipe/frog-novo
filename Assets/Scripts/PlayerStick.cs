using UnityEngine;

public class PlayerStickToCarSimple : MonoBehaviour
{
    private Transform currentCar; // carro atual que o player está em cima

    void Update()
    {
        // segue o carro se estiver em cima
        if (currentCar != null)
        {
            transform.position += currentCar.position - currentCarLastPos;
        }

        currentCarLastPos = currentCar != null ? currentCar.position : Vector3.zero;
    }

    private Vector3 currentCarLastPos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            // só gruda se o player estiver acima do carro
            if (transform.position.y > other.transform.position.y + 0.5f)
            {
                currentCar = other.transform;
                currentCarLastPos = currentCar.position;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Car") && currentCar == other.transform)
        {
            currentCar = null;
        }
    }
}
