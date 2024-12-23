using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.0f;
    public int maxHealth = 5;

    public int health { get { return currentHealth; } }
    int currentHealth;




    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void Update()
    {
         horizontal = Input.GetAxis("Horizontal");
         vertical = Input.GetAxis("Vertical");

        Vector2 postion = rigidbody2d.position;
        postion.x = postion.x + 5.0f * horizontal * Time.deltaTime;
        postion.y = postion.y + 5.0f * vertical * Time.deltaTime;


        rigidbody2d.MovePosition(postion);
    }
}
