using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CaptureGUI : MonoBehaviour {

    public Text percentageText;
    public Slider percentageSlider;
    public CanvasGroup zoneOneCanvas;

    private CaptureController _CaptureController;

	// Use this for initialization
	void Start () {

        _CaptureController = GameObject.Find("TriggerArea").GetComponent<CaptureController>();
        zoneOneCanvas.alpha = 0.2f;
        
    }
	
	// Update is called once per frame
	void Update () {

        percentageSlider.value = _CaptureController.blueCapturePerc;
        percentageText.text = _CaptureController.blueCapturePerc.ToString("F0") + "%";
	}
}
