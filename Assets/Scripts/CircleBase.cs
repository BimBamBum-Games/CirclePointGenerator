using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleBase
{

    private Vector3 _rVect, _fVect;
    private int _segment;
    public Vector3[] CirclePoints { get; private set; }
    public CircleBase(Vector3 rVec, Vector3 fVect, int segment)
    {
        //Constructor
        _rVect = rVec;
        _fVect = fVect;
        _segment = segment;
    }

    public float GetIntervalAngle(int segment)
    {
        //Radians cinsinden.
        return 2 * Mathf.PI / segment; 
    }

    public Vector3 GetCirclePoint(Vector3 rVec, Vector3 fVect, float rad)
    {   
        //Verilen radius Vector3 uzerinden cember noktasi buldurma.
        return rVec * Mathf.Cos(rad) + fVect * Mathf.Sin(rad);
    }

    public Vector3[] GetCirclePoints()
    {
        Vector3[] CirclePoints = new Vector3[_segment + 1];
        float interval = GetIntervalAngle(_segment);
        for(int i = 0; i < CirclePoints.Length; i++)
        {
            CirclePoints[i] = GetCirclePoint(_rVect, _fVect, i * interval);
        }
        return CirclePoints;
    }

}
