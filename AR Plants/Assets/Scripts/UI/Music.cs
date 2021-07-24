using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Music : MonoBehaviour
{
    public Button musicButton;
    public Sprite button_ON;
    public Sprite button_OFF;
    private bool stich = true;
    private bool check;
    private int number;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        number = PlayerPrefs.GetInt("Music");
        if (number == 0)
        {
            check = false;
        }
        else if (number == 1)
        {
            check = true;
            
        }

        
        musicButton.GetComponent<Image>().sprite = check ? button_ON : button_OFF;


    }
   
    public void music_clicked()
    {
        stich = !stich;
        if (stich)
        {
            PlayerPrefs.SetInt("Music", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Music", 0);
        }
        
    }
}
