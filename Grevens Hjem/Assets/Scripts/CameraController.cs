using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public Transform[] pointsOfInterest;

    public Transform currentPOI, previousPOI;
    
    public float cameraSpeed, StartDistanceToPOI, currentDistanceToPOI;

    public GameObject[] button;

    Vector3 camPos;
    Quaternion camRot;


	// Use this for initialization
	void Start () {
	   // GameObject.FindGameObjectsWithTag()
	}
	
	// Update is called once per frame
	void Update () {

        //moves the camera to the current point of interest.
        MoveTheCamera();

	}

    public void SetCurrentPointOfInterest(int val)//should be called once a button is pressed
    {
        //sets the current point of interest to the numerical value of the button pressed
        currentPOI = pointsOfInterest[val];

    }


    void MoveTheCamera()
    {
        //(the camera's location - PointOfInterest)*transitionSpeed?

        //float distanceCovered = (Time.time - startTime) * cameraSpeed;

        // gameObject.transform.position = 
        camPos = gameObject.transform.position;
        camRot = gameObject.transform.rotation;

        StartDistanceToPOI = Vector3.Distance(currentPOI.position, camPos);

        transform.position = Vector3.Lerp(previousPOI.position, currentPOI.position, StartDistanceToPOI);
        
        //okay so now we have a distance between the two areas
        //


    }

}
