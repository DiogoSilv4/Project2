using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Music1 : MonoBehaviour
{
    private int number;
    private void Awake()
    {
        
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        number = PlayerPrefs.GetInt("Music");
        if (number == 1)
        {
            PlayerPrefs.SetInt("Music", 1);
            AudioListener.volume = 1;
            
        }
        else
        {
            PlayerPrefs.SetInt("Music", 0);
            AudioListener.volume = 0;
            
        }
        
       
    }
    
}
