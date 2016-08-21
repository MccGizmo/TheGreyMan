using UnityEngine;
using System.Collections;

public class FlagCapture : MonoBehaviour {

    private CaptureController _CaptureController;
    private CaptureGUI _CaptureGUI;

    void Start() {

        _CaptureController = GameObject.Find("TriggerArea").GetComponent<CaptureController>();
        _CaptureGUI = GameObject.FindGameObjectWithTag("BlueTeam").GetComponent<CaptureGUI>();
    }

    void OnTriggerEnter(Collider other) {

        _CaptureGUI.zoneOneCanvas.alpha = 1f;

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

        _CaptureGUI.zoneOneCanvas.alpha = 0.5f;

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
