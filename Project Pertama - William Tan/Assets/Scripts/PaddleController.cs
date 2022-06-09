using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movement = Vector3.up * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement = Vector3.down * speed;
        }

        //GetComponent<Transform>();
        //Vector3 pos = transform.position;
        //Transform.position = transform.position + (new Vector3(0.1f, 0, 0) * Time.deltaTime);
        transform.Translate(movement * Time.deltaTime);

    }
}
