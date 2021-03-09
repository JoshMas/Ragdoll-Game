using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointAndClick : MonoBehaviour
{
    [SerializeField]
    private GameObject explosion;
    private float distance = 8.0f;
    [SerializeField]
    private GameObject ragdoll;

    // Start is called before the first frame update
    void Start()
    {
        int i = 1 << 8;
        Debug.Log(~i);
        distance = Vector3.Distance(gameObject.transform.position, ragdoll.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(explosion, GetMousePosition(), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
        }
    }

    private Vector3 GetMousePosition()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance));
        //Debug.Log(Input.mousePosition + " " + mousePos);
        return new Vector3(mousePos.x, mousePos.y, -2.0f);
    }
}
