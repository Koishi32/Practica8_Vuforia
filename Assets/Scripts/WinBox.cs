using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBox : MonoBehaviour
{
    public LevelManager reference;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !(reference.level>2))
        {
            reference.Win_level();
        }
    }
}
