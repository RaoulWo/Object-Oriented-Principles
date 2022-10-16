using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        HandleUserInput();
    }

    private void HandleUserInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float maxDistance = 100.0f;

            if (Physics.Raycast(ray, out hit, maxDistance))
            {
                hit.collider.gameObject.SendMessage("DisplayText");
            }
        }
    }
}
