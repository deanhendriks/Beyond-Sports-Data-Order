using System.Collections;
using System.Collections.Generic;

public class BallData
{
    private float _PositionX;
    private float _PositionY;
    private float _PositionZ;
    private double _BallSpeed;

    public BallData (string _PositionX, string _PositionY, string _positionZ, string _BallSpeed)
    {
        this._PositionX = float.Parse(_PositionX);
        this._PositionY = float.Parse(_PositionY);
        this._PositionZ = float.Parse(_positionZ);
        this._BallSpeed = double.Parse(_BallSpeed);
    }

    public float GetPositionX()
    {
        return _PositionX;
    }

    public float GetPositionY()
    {
        return _PositionY;
    }

    public float GetPositionZ()
    {
        return _PositionZ;
    }

    public double GetBallSpeed()
    {
        return _BallSpeed;
    }
}
