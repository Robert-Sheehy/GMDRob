using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch[] myTouches = Input.touches;
            Touch myFirstTouch = myTouches[0];
            print(myFirstTouch.position);
            Ray myRay = Camera.main.ScreenPointToRay(myFirstTouch.position);
            Debug.DrawRay(myRay.origin, 15 * myRay.direction);
            RaycastHit hitInfo;
            if (Physics.Raycast(myRay,out hitInfo))
            {
                SpaceShipScript touchedSpaceShip = hitInfo.transform.GetComponent<SpaceShipScript>();
                touchedSpaceShip.changeColor(Color.green);
            }


          //  acceleration += 15 * Vector3.up;
        }
    }
}
