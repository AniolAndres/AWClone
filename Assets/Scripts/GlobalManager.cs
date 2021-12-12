using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    [SerializeField]
    private GridManager gridManager;

    [SerializeField]
    private ActorScript actorPrefab;

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider == null) {
                return;
            }

            var tileView = hit.collider.transform.parent.GetComponent<TileView>();
            tileView.FireClickedAction();
        }
    }
}
