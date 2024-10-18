using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupGacha : MonoBehaviour
{

    public GameObject tooltip;
    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            print("yes");
            tooltip.SetActive(true);
        }
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) {
            tooltip.SetActive(false);
        }
    }
}
