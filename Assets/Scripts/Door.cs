using UnityEngine;

public class Door : MonoBehaviour
{
    public Room CurrentRoom;
    public Room NextRoom;

    private void OnMouseDown()
    {
        Enter();
    }

    public void Enter()
    {
        LocationManager.Instance.Camera.transform.position = NextRoom.CameraPoint.position;
        UIManager.Instance.BackButton.SetActive(NextRoom.RoomType != RoomType.Main);
        LocationManager.Instance.CurrentRoom = NextRoom;
    }

}
