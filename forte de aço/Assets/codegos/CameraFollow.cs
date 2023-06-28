using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform target; // Referência ao transform do personagem que a câmera deve seguir
    public float smoothSpeed = 0.125f; // Velocidade suave de movimento da câmera
    public Vector3 offset; // Distância entre a câmera e o personagem

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // Calcula a posição desejada da câmera
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Suaviza o movimento da câmera
        transform.position = smoothedPosition; // Atualiza a posição da câmera para seguir o personagem
    }
}
