using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class darkMode : MonoBehaviour
{
    public Sprite ON;
    public Sprite OFF;
    public Button button;
    public GameObject dark_scene;
    public GameObject dark_credits;
    public GameObject dark_fable;

    private bool change;
    private int number;

    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<Image>().sprite = OFF;
        change = false;
    }

    // Update is called once per frame
    void Update()
    {
        number = PlayerPrefs.GetInt("Dark");
        if (number== 1)
        {
            button.GetComponent<Image>().sprite = ON;
            dark_scene.SetActive(true);
            dark_credits.SetActive(true);
            dark_fable.SetActive(true);


        }
        else if (number == 0)
        {
            button.GetComponent<Image>().sprite = OFF;
            dark_scene.SetActive(false);
            dark_credits.SetActive(false);
            dark_fable.SetActive(false);




        }
    }
    public void Switch()
    {
        change = !change;
        if (change)
        {
            PlayerPrefs.SetInt("Dark", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Dark", 0);
        }
    }

}