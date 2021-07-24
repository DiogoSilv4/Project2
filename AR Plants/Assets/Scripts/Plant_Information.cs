using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Plant_Information : MonoBehaviour
{
    public GameObject info_canvas;
    public GameObject[] PLANTS;
    
    private bool State;

    private int Plant_;

   
    // Start is called before the first frame update
    void Start()
    {
        State = false;
        Plant_ = PlayerPrefs.GetInt("Plant");

        for (int i = 0; i < PLANTS.Length; i++)
        {
            PLANTS[i].SetActive(false);
        }
        for (int i = 0; i < PLANTS.Length*2; i++)
        {
            if (i == Plant_ - i+1)
            {
                PLANTS[i-1].SetActive(true);
            }

        }

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IsOn()
    {
        State = !State;
    }
    
}
