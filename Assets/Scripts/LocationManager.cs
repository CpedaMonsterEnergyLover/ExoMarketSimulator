using System;
using System.Collections.Generic;
using UnityEngine;

public class LocationManager : MonoBehaviour
{
    #region Singleton

    public static LocationManager Instance;

    private void Awake()
    {
        if (Instance is null) Instance = this;
        else Debug.LogError("Found multiple instances of LocationManager!");
    }

    #endregion

    public Camera Camera;
    public List<Room> Rooms;
    public Room CurrentRoom;

    private void Start()
    {
        CurrentRoom = Rooms[0];
        UIManager.Instance.BackButton.SetActive(false);
    }

    public void Back()
    {
        if(CurrentRoom is null) return;
        Camera.transform.position = CurrentRoom.PreviousRoom.CameraPoint.position;
        UIManager.Instance.BackButton.SetActive(CurrentRoom.PreviousRoom.RoomType != RoomType.Main);
    }
}
