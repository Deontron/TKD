using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ControlLoop());
    }

    IEnumerator ControlLoop()
    {
        while (true)
        {
            GetTouch();
            yield return new WaitForSeconds(0.01f);
        }
    }

    private void GetTouch()
    {
        Vector2 pos;
        if (Input.touchCount > 0)
        {
            Touch input = Input.GetTouch(0);

            if (input.phase == TouchPhase.Moved)
            {
                pos = Camera.main.ScreenToWorldPoint(input.position);
                transform.position = pos;
            }
        }
    }
}
