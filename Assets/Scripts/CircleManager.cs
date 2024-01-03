using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleManager : MonoBehaviour
{
    [SerializeField]
    private bool isGizmosEnabled =true;
    [SerializeField]
    [Range(0, 100)]
    private int _segments;

    private void OnDrawGizmos()
    {
        
        if (!isGizmosEnabled)
        {
            Debug.Log("Gizmos Kapalidir.");
            return;
        }

        CircleBase circleBase;
        circleBase = new CircleBase(transform.right, transform.forward, _segments);

        Vector3[] circlePoints = circleBase.GetCirclePoints();

        for (int i = 1; i < circlePoints.Length; i++)
        {
            //Debug.Log("Points -> " + circlePoints[i]);
            Gizmos.DrawLine(circlePoints[i - 1] + transform.position, circlePoints[i] + transform.position);
        }
    }
}
