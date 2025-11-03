using UnityEngine;

public class CarStickFixed : MonoBehaviour
{
    private int objectsInside = 0; // conta quantos colliders do player estão dentro

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objectsInside++;
            other.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objectsInside--;

            // só solta quando realmente saiu de todos os colliders
            if (objectsInside <= 0)
            {
                other.transform.SetParent(null);
                objectsInside = 0;
            }
        }
    }
}
