using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class Rotate_Pyramid : MonoBehaviour
{
    public GameObject piramid;
    public GameObject plane;
    private Transform planeTrans;
    public float speed;

    public GameObject plane_1;
    public GameObject plane_2;
    public GameObject plane_3;
    public GameObject plane_4;

    private Transform[] transforms;
    private string scene_name = "5_Canvas";  //3_Selected_Biome";
    private void Start()
    {
        planeTrans = plane.GetComponent<Transform>();

        transforms[0] = plane_1.GetComponent<Transform>();
        transforms[1] = plane_2.GetComponent<Transform>();
        transforms[2] = plane_3.GetComponent<Transform>();
        transforms[3] = plane_4.GetComponent<Transform>();

        

    }
    private void Update()
    {
        //rotate pyramid to left and rigth
        if (Input.GetMouseButton(0))
        {

            foreach (Touch touch in Input.touches)
            {
                int id = touch.fingerId;
                if (EventSystem.current.IsPointerOverGameObject(id))
                {
                    return;
                }
            }


            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {


                if (hit.transform.position == planeTrans.position && Input.mousePosition.x < Screen.width/2)
                {
                    piramid.transform.Rotate(Vector3.up * Time.deltaTime * speed);


                }
                else if (hit.transform.position == planeTrans.position && Input.mousePosition.x >= Screen.width / 2)
                {
                    piramid.transform.Rotate(Vector3.up * Time.deltaTime * -speed);
                }

                
                // Plane_1
                if (hit.transform.position == plane_1.transform.position)
                {
                    plane_1.transform.position = new Vector3(0, 0.1f, 0);
                }
                else
                {
                    plane_1.transform.position = new Vector3(0, 0, 0);
                }
                // Plane_2
                if (hit.transform.position == plane_2.transform.position)
                {
                    plane_2.transform.position = new Vector3(0, 2.1f, 0);
                }
                else
                {
                    plane_2.transform.position = new Vector3(0, 2, 0);
                }
                // Plane_3
                if (hit.transform.gameObject.transform.position == plane_3.transform.position )
                {
                    plane_3.transform.position = new Vector3(0, 4.1f, 0);
                }
                else
                {
                    plane_3.transform.position = new Vector3(0, 4, 0);
                }
                // Plane_4
                if (hit.transform.position == plane_4.transform.position)
                {
                    plane_4.transform.position = new Vector3(0, 6.1f, 0);
                }
                else
                {
                    plane_4.transform.position = new Vector3(0, 6, 0);
                }
            }
        }
        
        //select the biome from the plane
        if (Input.GetMouseButtonUp(0))
        {
            foreach (Touch touch in Input.touches)
            {
                int id = touch.fingerId;
                if (EventSystem.current.IsPointerOverGameObject(id))
                {
                    return;
                }
            }

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.transform.position == plane_1.transform.position)
                {
                    
                    PlayerPrefs.SetInt("Plane", 1);
                    PlayerPrefs.SetInt("Plant", 1);
                    SceneManager.LoadScene(scene_name);
                }
                else if (hit.transform.position == plane_2.transform.position)
                {
                    PlayerPrefs.SetInt("Plane", 2);
                    PlayerPrefs.SetInt("Plant", 3);
                    SceneManager.LoadScene(scene_name);
                    
                }
                else if (hit.transform.position == plane_3.transform.position)
                {
                    
                    PlayerPrefs.SetInt("Plane", 3);
                    PlayerPrefs.SetInt("Plant", 5);
                    SceneManager.LoadScene(scene_name);
                }
                else if (hit.transform.position == plane_4.transform.position)
                {
                    
                    PlayerPrefs.SetInt("Plane", 4);
                    PlayerPrefs.SetInt("Plant", 7);
                    SceneManager.LoadScene(scene_name);
                }
            }
        }

    }
    
}
