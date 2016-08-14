using UnityEngine;
using System.Collections;

public class PlayerWatchShooter : MonoBehaviour {

    LineRenderer aimLine;

    void Awake()
    {
        aimLine = GetComponent<LineRenderer>();
    }

    void Start()
    {
        aimLine.enabled = false;
    }

    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            if (aimLine.enabled == false)
            {
                aimLine.enabled = true;
            }
        }
        else
        {
            aimLine.enabled = false;
        }
    }
}
