using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBar : MonoBehaviour
{
    
    public GameObject ScrollSpace;
    public int speed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            foreach (Touch touch in Input.touches)
            {
                

                
                        
                var change = touch.deltaPosition.y;
                       
                if (change < 0) //goes left
                {
                    ScrollSpace.transform.position = ScrollSpace.transform.position + new Vector3(0, change * speed, 0);
                }

                else if (change > 0) // goes right
                {

                    ScrollSpace.transform.position = ScrollSpace.transform.position + new Vector3(0, change * speed, 0);
                }
                    
                

                
            }
        }
    }
}
