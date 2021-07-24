using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch_flashlitgh_images : MonoBehaviour
{
    public Sprite lanternON;
    public Sprite lanternOFF;
    public Button button;
    private bool change;

    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<Image>().sprite = lanternOFF;
        change = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (change)
        {
            button.GetComponent<Image>().sprite =  lanternON;
        }
        else
        {
            button.GetComponent<Image>().sprite = lanternOFF;
        }
    }
    public void lanternSwitch()
    {
        change = !change;
    }
    
}
