using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public Transform[] pointsOfInterest;

    public Transform currentPOI, previousPOI;
    
    public float cameraSpeed, StartDistanceToPOI, currentDistanceToPOI;

    public GameObject[] button;

    float startTime;

    Vector3 camPos;
    Quaternion camRot;


	// Use this for initialization
	void Start () {
        // GameObject.FindGameObjectsWithTag()

        StartDistanceToPOI = Vector3.Distance(currentPOI.position, camPos);
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

        StartDistanceToPOI = Vector3.Distance(currentPOI.position, camPos);

    }


    void MoveTheCamera()
    {
        //(the camera's location - PointOfInterest)*transitionSpeed?

        // float distanceCovered = (Time.time - startTime) * cameraSpeed;

        // gameObject.transform.position = 
        camPos = gameObject.transform.position;
        camRot = gameObject.transform.rotation;

        

        float distanceCovered = (Time.time - startTime) * cameraSpeed;
        float journeyPart = distanceCovered / StartDistanceToPOI;

        transform.position = Vector3.Lerp(previousPOI.position, currentPOI.position, journeyPart);
        
        //okay so now we have a distance between the two areas
        //


    }

}
