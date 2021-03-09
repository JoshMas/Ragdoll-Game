using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenery : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 90.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.Rotate(Vector3.forward * Random.Range(0.0f, 360.0f), Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
        gameObject.transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime, Space.World);
        if(gameObject.transform.position.z < -20.0f)
        {
            Destroy(gameObject);
        }
    }

    public void SetSpeed(float sp, float tsp)
    {
        speed = sp;
        turnSpeed = tsp;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(GameObject.FindWithTag("Player"));
    }
}
