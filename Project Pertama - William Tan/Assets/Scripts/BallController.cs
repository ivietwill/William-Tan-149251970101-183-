using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Transform>();
        //Vector3 pos = transform.position;
        //Transform.position = transform.position + (new Vector3(0.1f, 0, 0) * Time.deltaTime);
       transform.Translate (speed * Time.deltaTime);
    }
}
