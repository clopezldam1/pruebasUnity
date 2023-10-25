using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    Rigidbody2D rb2d;
    float horizontal;
    float vertical;
    float speed = 5f;

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
    }

}
