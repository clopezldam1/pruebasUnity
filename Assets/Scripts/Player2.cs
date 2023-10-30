using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    Rigidbody2D rb2d;
    float horizontal;
    float vertical;
    float speed = 5f;
    float salto;
    float timerSalto;
    float alturaSalto = 30f; //f es unidad de fuerza - basada en newtons, es en relacion a cuanto te hace falta para levantar el cuerpo (aka, peso del rigbody)
    float holdJumpSecs;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal"); //esto es para asignar los controles --> edit, project settigs, input manager (cada elemento de la lista es el nombre de un eje a usar)
        Vector2 velocity = rb2d.velocity;
        velocity.x = horizontal * speed;
        rb2d.velocity = velocity;

        vertical = Input.GetAxis("Vertical");
        Vector2 velocityVertical = rb2d.velocity;
        velocityVertical.y = vertical * speed;
        rb2d.velocity = velocityVertical;

        //para que salte
        salto = Input.GetAxis("Jump"); //returns 1 si tecla esta pusalda
        Debug.Log("Salto: " + salto);


        holdJumpSecs -= Time.deltaTime; //saltas durante 1 segundo, te puedes mover en el aire
        while (salto == 1 && holdJumpSecs >= 0) //esto crea bucle infinito
        {
            rb2d.AddForce(new Vector2(0, salto * alturaSalto)); //sube en Y
            holdJumpSecs = 1;
        }

        if (salto == 1)
        {
            rb2d.AddForce(new Vector2(0, -salto * alturaSalto)); //baja en Y
        }

    }

}
