using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Buttons : MonoBehaviour
{
    public GameObject Other_button;
    public GameObject Other;

    public GameObject POther_button;

    private bool first;
    private bool second;

    public GameObject Menu;
    private bool menu_show;
    private bool touched;

    
    // Start is called before the first frame update
    void Start()
    {
        first = true;
        second = false;
        menu_show = true;
        touched = true;

        Other_button.SetActive(first);
        Other.SetActive(second);

        POther_button.SetActive(first);
        Menu.SetActive(menu_show);
    }

    // Update is called once per frame
    void Update()
    {
        Other_button.SetActive(first);
        Other.SetActive(second);
        POther_button.SetActive(first);
        

        Menu.SetActive(menu_show);
        if (Input.GetMouseButton(0) && touched == false)
        {
            menu_show = !menu_show;
            touched = true;
        }
    }
    public void other_button()
    {
        first = !first;
        second = !second;
    }
   public void Clear_Mode()
    {
        menu_show = !menu_show;
        touched = false;
    }

}
