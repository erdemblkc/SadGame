using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerInventorySystem : MonoBehaviour
{
    public bool hasKey = false;
    public static playerInventorySystem Instance;
    
    void Awake()
    {
        Instance = this;
    }

}
