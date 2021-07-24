using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tutoral;
    public GameObject st;
    public GameObject nd;
    public GameObject next;
    public GameObject exit;
    public GameObject rd;
    public GameObject next_;

    private int value;
    private void Awake()
    {
        value = PlayerPrefs.GetInt("Tutorial");

        if (value == 1)
        {
            tutoral.SetActive(false);
        }
        else
        {
            tutoral.SetActive(true);
            st.SetActive(true);
            next.SetActive(true);
            nd.SetActive(false);
            exit.SetActive(false);
            rd.SetActive(false);
            next_.SetActive(false);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void exitTutorial()
    {
        PlayerPrefs.SetInt("Tutorial", 1);
       

    }
    public void exTutorial()
    {
        PlayerPrefs.SetInt("Tutorial", 0);


    }

}
