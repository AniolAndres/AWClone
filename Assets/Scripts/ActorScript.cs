using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorScript : MonoBehaviour
{
    private bool isDragging;

    public GridManager gridManager;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit)
            {
                isDragging = true;
                Debug.Log(hit.transform.gameObject.name);
            }
        }

        if (isDragging)
        {
            //var newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //newPosition.z = 0;
            //var newX = Mathf.RoundToInt(newPosition.x);
            //var newY = Mathf.RoundToInt(newPosition.y);
            //newPosition = gridManager.GetWorldPositionFromTile(newX, newY);
            //transform.position = newPosition;
        }

        if (Input.GetMouseButtonUp(0))
        {

            isDragging = false;
        }
    }




}
