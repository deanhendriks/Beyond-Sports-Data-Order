using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class DataLoop : MonoBehaviour
{
    List<Frame> framelist = new List<Frame>();
    private float _currentTime;
    private int _currentFrame;
    public double _minimalTimePerFrame;
    public GameObject BallObject;
    void Start()
    {
        string[] lines = File.ReadAllLines(@"D:\data storage\Applicant-test.txt");

        foreach (string line in lines)
        {
            Frame frame = new Frame(line);
            framelist.Add(frame);
        }
        BallObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        BallObject.name = "ball";
        
        _minimalTimePerFrame = 0.04;

    }
    void Update()
    {
        if (framelist == null)
        {
            return;
        }
        if (_currentFrame >= framelist.Count())
        {
            // End of program
            return;
        }
        _currentTime += Time.deltaTime;
        Debug.Log("Current time: " + _currentTime);
        Debug.Log(_minimalTimePerFrame);
        if (_minimalTimePerFrame >= _currentTime)
        {
            Debug.Log("stop");
            return;
        }
        _currentTime = 0;
        


        Frame frame = framelist[_currentFrame];
        BallData ballData = frame.balldata;
        BallObject.transform.position = new Vector3(ballData.GetPositionX(), ballData.GetPositionY(), ballData.GetPositionZ());
        Debug.Log("tik");
        foreach (TrackedObj trackedobject in frame.GetTrackedObjects())
        {
            GameObject GOTrackedObject = GameObject.Find(trackedobject.GetTrackingID());

            if (GOTrackedObject == null)
            {
                GOTrackedObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
                GOTrackedObject.name = trackedobject.GetTrackingID();
            }

            Transform trackedObjectTransform = GOTrackedObject.GetComponent<Transform>();

            if (trackedObjectTransform == null)
            {
                GOTrackedObject.AddComponent<Transform>();
                trackedObjectTransform = GOTrackedObject.GetComponent<Transform>();
            }

            trackedObjectTransform.position = new Vector3(trackedobject.GetPosX(), trackedobject.GetPosY(), 0f);


            trackedobject.GetTeam();
            trackedobject.GetTrackingID();
            trackedobject.GetPlayerNumber();
            trackedobject.GetPosX();
            trackedobject.GetPosY();
            trackedobject.GetSpeed();
        }

        _currentFrame++;

    }
}
