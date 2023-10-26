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
    float alturaSalto = 100f; //f es unidad de fuerza - basada en newtons, es en relacion a cuanto te hace falta para levantar el cuerpo (aka, peso del rigbody)


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
        timerSalto -= Time.deltaTime;
        if (timerSalto <= 0 && salto == 1)
        { //si timer es 0 puede saltar y si pulsa tecla salto
            //? no sé qué poner en el if para que solo salte 1 vez (que sin if vuela)
            timerSalto = 3; //limitador: sollo puede salatr una vez cada 3 segundos, si mantienes pulsado vuelas
            rb2d.AddForce(new Vector2(0, salto * alturaSalto));
        }
    }

}
