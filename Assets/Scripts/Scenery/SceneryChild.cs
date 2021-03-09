using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneryChild : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(GameObject.FindWithTag("Player"));
    }
}
