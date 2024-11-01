using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 postion = transform.position;
        postion.x = postion.x + 5.0f * horizontal * Time.deltaTime;
        postion.y = postion.y + 5.0f * vertical * Time.deltaTime;
        

        transform.position = postion;
    }
}
