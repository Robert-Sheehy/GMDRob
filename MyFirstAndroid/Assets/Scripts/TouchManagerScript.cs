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
            switch (myFirstTouch.phase)
            {
                case TouchPhase.Began:

                    break;

                case TouchPhase.Stationary:

                    break;

                case TouchPhase.Moved:

                    break;

                case TouchPhase.Ended:

                    break;
            
            }






            Ray myRay = Camera.main.ScreenPointToRay(myFirstTouch.position);
            Debug.DrawRay(myRay.origin, 15 * myRay.direction);
            RaycastHit hitInfo;
            if (Physics.Raycast(myRay,out hitInfo))
            {
                ITouchable touchedObject = hitInfo.transform.GetComponent<ITouchable>();
                if (touchedObject != null)
                    touchedObject.OnTap();

                if (touchedObject is SpaceShipScript)
                    (touchedObject as SpaceShipScript).changeColor(Color.green);
            }


          //  acceleration += 15 * Vector3.up;
        }
    }
}
