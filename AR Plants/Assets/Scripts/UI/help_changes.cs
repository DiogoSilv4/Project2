using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class help_changes : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] helps;
    public float speed;
    private float time;
    private int currentActive;
    
    private Image prog;
    public GameObject progression;

   
    void Start()
    {
        prog = progression.GetComponent<Image>();

        time = 0;
        helps[0].SetActive(true);
        for (int i = 1; i < helps.Length; i++)
        {
            helps[i].SetActive(false);
        }
    }

    
    void Update()
    {
        time += Time.deltaTime;

        if (time >= speed)
        {

            for (int i = 0; i < helps.Length; i++)
            {
                if (helps[i].activeSelf)
                {
                    currentActive = i;
                }

            }

        }
        if (time > speed)
        {

                   for (int i = 0; i < helps.Length; i++)
            {
                helps[i].SetActive(false);
            }
            if (currentActive == helps.Length - 1)
            {
                helps[0].SetActive(true);

            }
            else
            {
                helps[currentActive + 1].SetActive(true);
            }
            time -= time;
            
        }


        prog.fillAmount = time / speed;


    }


    
}
