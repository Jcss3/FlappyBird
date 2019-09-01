using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    // velocidade de deslocação a direita
    public float speed;

    // força que empurra o Bird pra cima 
    public float force;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }

    }
    
    
    // Metodo para tratar colisão do Bird com objetos
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene("game");
        
    }

}
