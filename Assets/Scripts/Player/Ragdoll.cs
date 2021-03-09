using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    Rigidbody torso;
    Rigidbody[] bodyParts;

    // Start is called before the first frame update
    void Start()
    {
        torso = GetComponent<Rigidbody>();
        torso.constraints = RigidbodyConstraints.FreezePositionZ;
        bodyParts = GetComponentsInChildren<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    private void OnTriggerEnter(Collider other)
    {

        foreach(Rigidbody part in bodyParts)
        {
            float yVelocity = torso.velocity.y;
            yVelocity = Mathf.Max(yVelocity, 0.0f);
            torso.velocity = new Vector3(torso.velocity.x, yVelocity, torso.velocity.z);
            Debug.Log(torso.velocity);
        }

    }
    */
}
