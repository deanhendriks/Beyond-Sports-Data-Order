using System.Collections;
using System.Collections.Generic;

public class TrackedObj
{
    private float _PositionX;
    private float _PositionY;
    private double _Speed;
    private long _PlayerNumber;
    private string _TrackingID;
    private string _Team;

    public TrackedObj(string _Team, string _TrackingID, string _PlayerNumber, string _PositionX, string _PositionY, string _Speed) 
    {
        this._Team = _Team;
        this._TrackingID = _TrackingID;
        this._PlayerNumber = long.Parse(_PlayerNumber);
        this._PositionX = float.Parse(_PositionX);
        this._PositionY = float.Parse(_PositionY);
        this._Speed = double.Parse(_Speed);
    }
    public float GetPosX()
    {
        return _PositionX;
    }

    public float GetPosY()
    {
        return _PositionY;
    }

    public double GetSpeed()
    {
        return _Speed;
    }

    public long GetPlayerNumber()
    {
        return _PlayerNumber;
    }

    public string GetTrackingID()
    {
        return _TrackingID;
    }

    public string GetTeam()
    {
        return _Team;
    }
}
