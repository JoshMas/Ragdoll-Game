using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    private Joint[] joints;
    [SerializeField]
    private float minForScore = 600.0f;
    private float currentScore = 0.0f;

    [SerializeField]
    TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        joints = GetComponentsInChildren<Joint>();
    }

    // Update is called once per frame
    void Update()
    {
        float forceApplied = 0;

        foreach (Joint joint in joints)
        {
            forceApplied += joint.currentForce.magnitude;
        }

        if (forceApplied > minForScore)
        {
            currentScore += forceApplied * Time.deltaTime;
            scoreText.text = "Score: " + (int)currentScore;
        }
    }

    private void OnDestroy()
    {
        scoreText.text = scoreText.text + "\nGame Over\nPress Space to return\nto the Main Menu";
    }
}
