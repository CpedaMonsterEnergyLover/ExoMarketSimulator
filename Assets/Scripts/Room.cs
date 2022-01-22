using System;
using UnityEngine;

public class Room : MonoBehaviour
{
    public RoomType RoomType;
    public Transform CameraPoint;
    public Room PreviousRoom;

    private void OnDrawGizmos()
    {
        if (CameraPoint is null) return;
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(CameraPoint.position, 2f);
    }
}

[Serializable]
public enum RoomType
{
    Main,
    Toilet,
    Corridor,
    Room
}