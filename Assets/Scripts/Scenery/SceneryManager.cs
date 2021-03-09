using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneryManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] scenery;
    [SerializeField]
    private float speed = 10.0f;
    [SerializeField]
    private float turnSpeed = 90.0f;
    [SerializeField]
    private float delay = 10.0f;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        timer = delay - 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > delay)
        {
            timer = 0.0f;
            SpawnScenery();
        }
    }

    private void SpawnScenery()
    {
        GameObject newScenery = Instantiate(scenery[Random.Range(0, scenery.Length)]);
        newScenery.GetComponent<Scenery>().SetSpeed(speed, turnSpeed);
    }

}
