using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class PlaneSetZero : MonoBehaviour
{
    private ARPlaneManager arPlane;
    public Button toggleButton;

    // Start is called before the first frame update
    void Awake()
    {
        if (toggleButton != null)
        {
            //toggleButton.onClick.AddListener(TogglePlaneDetection);
        }
    }
    void Start()
    {
        arPlane = this.GetComponent<ARPlaneManager>();
        toggleButton.GetComponentInChildren<Text>().text = "Disable Plane Detection";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void TogglePlaneDetection()
    {
        arPlane.enabled = !arPlane.enabled;

        foreach(ARPlane plane in arPlane.trackables)
        {
            plane.gameObject.SetActive(arPlane.enabled);
        }
        toggleButton.GetComponentInChildren<Text>().text = arPlane.enabled ? "Disable Plane Detection" : "Enable Plane Detection";
    }



  
}
