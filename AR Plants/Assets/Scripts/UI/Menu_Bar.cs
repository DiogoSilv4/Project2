using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Bar : MonoBehaviour
{
    public GameObject button;
    public GameObject Menu;
    private bool buttonClick;
    // Start is called before the first frame update
    void Start()
    {
        buttonClick = false;
        button.SetActive(!buttonClick);
        Menu.SetActive(buttonClick);
    }

    // Update is called once per frame
    void Update()
    {
        button.SetActive(!buttonClick);
        Menu.SetActive(buttonClick);
    }
    public void button_click()
    {
        buttonClick = !buttonClick;
    }
}
