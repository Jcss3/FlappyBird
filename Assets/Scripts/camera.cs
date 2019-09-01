using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script para seguir o Bird
public class camera : MonoBehaviour
{

    public Transform bird;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // bird.position.x = posição do passaro
        // posição do camera (a camera so se movera no eixo x) , os outros eixos ficaram fixos
        transform.position = new Vector3(bird.position.x, transform.position.y , transform.position.z);
    }
}
