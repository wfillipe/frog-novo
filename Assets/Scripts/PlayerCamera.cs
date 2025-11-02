using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float mouseSensitivity = 150f;   // sensibilidade do mouse
    public Transform playerCamera;          // referência à câmera do jogador

    private float xRotation = 0f;           // controle do pitch (olhar para cima/baixo)

    void Start()
    {
        // trava o cursor no centro da tela
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // lê o movimento do mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // controla a rotação vertical (câmera)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // evita virar demais

        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // controla a rotação horizontal (player)
        transform.Rotate(Vector3.up * mouseX);
    }
}
