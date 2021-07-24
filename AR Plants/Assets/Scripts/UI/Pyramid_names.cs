using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pyramid_names : MonoBehaviour
{
    public GameObject names;
    private bool Change;
    // Start is called before the first frame update
    void Start()
    {
        Change = false;
        names.SetActive(Change);
    }

    // Update is called once per frame
    void Update()
    {
        names.SetActive(Change);
    }
    public void show_names()
    {
        Change = !Change;
    }
}
