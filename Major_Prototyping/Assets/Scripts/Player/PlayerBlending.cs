using UnityEngine;
using System.Collections;

public class PlayerBlending : MonoBehaviour {

    public Color color = new Color(148.0F, 211.0F, 255.0F, 255.0F);

    void OnCollisionEnter(Collision other)
    {
        if (CompareTag("Civilian"))
        {

        }
    }
}
