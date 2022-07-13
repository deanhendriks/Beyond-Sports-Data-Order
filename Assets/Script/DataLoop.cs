using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataLoop : MonoBehaviour
{
    List<Frame> framelist = new List<Frame>();
    void Start()
    {   
        string[] lines = File.ReadAllLines(@"D:\data storage\Applicant-test.txt");

        foreach (string line in lines)
        {
            Frame frame = new Frame(line);
            framelist.Add(frame);
        }
    }
}
