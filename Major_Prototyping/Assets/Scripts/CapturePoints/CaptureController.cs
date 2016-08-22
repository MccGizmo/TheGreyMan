using UnityEngine;
using System.Collections;

public class CaptureController : MonoBehaviour {

    public bool blueTeam = false;
    public bool redTeam = false;
    public GameObject[] zoneOnes;
    public Material[] redMat;
    public Material[] blueMat;
    public Material[] neutralMat;
    //public Light lt;

    public float blueCapturePerc = 0;
    public float redCapturePerc = 0;

    void Start() {

       
    }

    void Update() {

        if (blueTeam == true && Input.GetKey(KeyCode.E)) {

            blueCapturePerc += Time.deltaTime * 10;
            redCapturePerc -= Time.deltaTime * 10;
        }

        if (redTeam == true && Input.GetKey(KeyCode.E))
        {

            blueCapturePerc -= Time.deltaTime * 10;
            redCapturePerc += Time.deltaTime * 10;
        }

        if (redTeam == true && blueTeam == true) {

            redCapturePerc = redCapturePerc;
            blueCapturePerc = blueCapturePerc;
        }

        if (redCapturePerc >= 100) {

            redCapturePerc = 100;
   
            zoneOnes = GameObject.FindGameObjectsWithTag ("ZoneOne");
            foreach (GameObject go in zoneOnes) {

                MeshRenderer[] meshRenderers = go.GetComponentsInChildren<MeshRenderer>();
                Light[] lt = go.GetComponentsInChildren<Light>();
                foreach (MeshRenderer r in meshRenderers)
                {

                    foreach (Material m in r.materials) {

                        r.materials = redMat;
                    }
                }

                foreach (Light l in lt)
                {

                    l.color = Color.red;
                }
            }
        }

        if (blueCapturePerc >= 100)
        {
            
            blueCapturePerc = 100;
            
            zoneOnes = GameObject.FindGameObjectsWithTag("ZoneOne");
            foreach (GameObject go in zoneOnes)
            {

                MeshRenderer[] meshRenderers = go.GetComponentsInChildren<MeshRenderer>();
                Light[] lt = go.GetComponentsInChildren<Light>();
                foreach (MeshRenderer r in meshRenderers){
                    
                    foreach (Material m in r.materials){

                        r.materials = blueMat;
                    }
                }

                foreach (Light l in lt) {

                    l.color = Color.blue;
                }
            }
        }

        if (blueCapturePerc <= 50 && redCapturePerc <= 51)
        {

            zoneOnes = GameObject.FindGameObjectsWithTag("ZoneOne");
            foreach (GameObject go in zoneOnes){

                MeshRenderer[] meshRenderers = go.GetComponentsInChildren<MeshRenderer>();
                Light[] lt = go.GetComponentsInChildren<Light>();
                foreach (MeshRenderer r in meshRenderers){

                    foreach (Material m in r.materials){

                        r.materials = neutralMat;
                    }
                }
                foreach (Light l in lt)
                {

                    l.color = Color.grey;
                }
            }

            
        }

        if (redCapturePerc <= 0) {

            redCapturePerc = 0;
        }

        if (blueCapturePerc <= 0)
        {

            blueCapturePerc = 0;
        }
    }
}
