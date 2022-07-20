using System.Collections.Generic;
using UnityEngine;
public class Frame
{
    public BallData balldata;
    private List<TrackedObj> trackedObjectList;

    public Frame(string line)
    {
        trackedObjectList = InitializeTrackedObjects(line);
        balldata = GetBallData(line);
    }

    private List<TrackedObj> InitializeTrackedObjects(string line)
    {
        List<TrackedObj> trackedobjectlist = new List<TrackedObj>();
        string trackedobjectsline = splitString(line, ":")[1];
        string[] trackedobjects = splitString(trackedobjectsline, ";");

        foreach (string trackedobject in trackedobjects)
        {
            Debug.Log(trackedobject);
            if (trackedobject.Length == 0) continue;
            TrackedObj trackedObj = convertStringToTrackedObj(trackedobject);
            trackedobjectlist.Add(trackedObj);
        }
        return trackedobjectlist;
    }

    private BallData GetBallData(string line)
    {
        string balldatasline = splitString(line, ":")[2];
        string balldatas = splitString(balldatasline, ";")[0];
        return convertStringToBallData(balldatas);
    }

    public List<TrackedObj> GetTrackedObjects()
    {
        return trackedObjectList;
    }

    private string[] splitString(string line, string seperator)
    {
        return line.Split(seperator);
    }

    private TrackedObj convertStringToTrackedObj(string line)
    {
        string[] values = splitString(line, ",");
        return new TrackedObj(values[0], values[1], values[2], values[3], values[4], values[5]);
    }

    private BallData convertStringToBallData(string line)
    {
        string[] values = splitString(line, ",");
        return new BallData(values[0], values[1], values[2], values[3]);
    }

}