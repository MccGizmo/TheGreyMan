using UnityEngine;
using System.Collections;

public class FlagCapture : MonoBehaviour {

    private CaptureController _CaptureController;

    void Start() {

        _CaptureController = GameObject.Find("TriggerArea").GetComponent<CaptureController>();
    }

    void OnTriggerEnter(Collider other) {

        if (other.tag == "BlueTeam") {

            _CaptureController.blueTeam = true;
        }

        if (other.tag == "RedTeam")
        {

            _CaptureController.redTeam = true;
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.tag == "BlueTeam")
        {

            _CaptureController.blueTeam = false;
        }

        if (other.tag == "RedTeam")
        {

            _CaptureController.redTeam = false;
        }
    }
}
