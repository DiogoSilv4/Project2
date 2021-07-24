using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;


[RequireComponent(typeof(ARRaycastManager))]
public class AR_system : MonoBehaviour
{
    private GameObject gameObjectToInstitiate;
    public GameObject[] plants;
    public GameObject[] biomes;

    private GameObject spawnedObject;
    private ARRaycastManager arrayCast;
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private int plant_number;
    private int selected_plant;
    private bool switch_button;
    private bool switch_loop;
    private Vector3 prefab_pos;
    private Vector2 touchPosition;
    private void Awake()
    {
        arrayCast = GetComponent<ARRaycastManager>();
    }


    public int rotate;
    void Start()
    {
        selected_plant = PlayerPrefs.GetInt("Plant");

        PlayerPrefs.SetInt("NumberPlant", plants.Length);
        for (int i = 0; i < plants.Length; i++)
        {
            if (i == selected_plant - 1)
            {
                gameObjectToInstitiate = plants[i];
                plant_number = i;

            }
        }
        switch_button = false;
        spawnedObject = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (switch_loop)
        {
            GameObject[] tags = GameObject.FindGameObjectsWithTag("Ar_Module");
            foreach (GameObject tag in tags)
                GameObject.Destroy(tag, 0.5F);

            if (switch_button)

            {
                gameObjectToInstitiate = biomes[plant_number];
            }
            else
            {
                gameObjectToInstitiate = plants[plant_number];

            }
            switch_loop = false;
        }


        // ON TOUCH

        rotate_the_object(spawnedObject);

       


        if (Input.GetMouseButton(0) && check_touches(1) && double_touch_ended)
        {
            foreach (Touch touch in Input.touches)
            {
                int id = touch.fingerId;
                if (EventSystem.current.IsPointerOverGameObject(id))
                {
                    return;
                }
            }
        

            
            touchPosition = Input.GetTouch(0).position;

            if (arrayCast.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
            {
                var hitPose = hits[0].pose;
                prefab_pos = hitPose.position;

                if (spawnedObject == null)
                {
                    spawnedObject = (GameObject)Instantiate(gameObjectToInstitiate, hitPose.position, Quaternion.identity);
                }
                else
                {
                    spawnedObject.transform.position = hitPose.position;
                    prefab_pos = hitPose.position;
                }
            }
        }
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
        }
        touchPosition = default;

        

    }

    
   
    public void switchTo()
    {
        switch_button = !switch_button;
        switch_loop = true; 
    }
    //Rotate object 
    private bool double_touch_ended;
    private void rotate_the_object(GameObject Model)
    {
        double_touch_ended = true;
        var fingerCount = 0;
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
            {
                fingerCount++;
            }

            if (fingerCount == 2)
            {
                double_touch_ended = false;
                if (touch.phase == TouchPhase.Moved && touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
                {
                    var change = touch.deltaPosition.x ;
                    if (change < 0) //goes left
                    {
                        Model.transform.Rotate(0, rotate, 0) ;
                    }else if (change > 0) // goes right
                    {
                        Model.transform.Rotate(0, -rotate, 0);
                    }
                }
            }

            if (touch.phase == TouchPhase.Ended)
            {
                double_touch_ended = true;
            }
        }
    }
    //Check if there is more than 2 fingers touching the screen
    private bool res;
    private bool check_touches(int number)
    {
        var fingerCount = 0;
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
            {
                fingerCount++;
            }

            if (fingerCount == number)
            {
                res = true;
            }else
            {
                res = false;
            }
        }
        return res;
    }
    
}
