using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private float lifetime = 0.5f;
    private float timer = 0.0f;
    [SerializeField]
    private float strength = 1.0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > lifetime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody target = other.attachedRigidbody;
        if (target != null)
        {
            target.AddExplosionForce(strength, gameObject.transform.position, 2.0f, 1.0f, ForceMode.Impulse);
        }
    }
}
