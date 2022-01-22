using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Singleton

    public static UIManager Instance;

    private void Awake()
    {
        if (Instance is null) Instance = this;
        else Debug.LogError("Found multiple instances of UIManager!");
    }

    #endregion

    public GameObject MapButton;
    public GameObject BackButton;


}
