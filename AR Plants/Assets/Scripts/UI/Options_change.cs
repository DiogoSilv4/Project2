using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options_change : MonoBehaviour
{
    public GameObject Fable;
    public GameObject Settings;
    public GameObject Credits;

    private int option;

    // Start is called before the first frame update
    void Start()
    {
        Fable.SetActive(false);
        Settings.SetActive(false);
        Credits.SetActive(false);
        option = PlayerPrefs.GetInt("Options");
        switch (option)
        {
            case 1:
                Settings.SetActive(true);
                break;
            case 2:
                Fable.SetActive(true);
                break;
            case 3:
                Credits.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
