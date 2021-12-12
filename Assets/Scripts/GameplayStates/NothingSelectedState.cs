using System;
using UnityEngine;

public class NothingSelectedState : IGameplayState {

    public event Action<StateEnum> ChangeState;

    public void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider == null) {
                return;
            }

            var tileView = hit.collider.transform.parent.GetComponent<TileView>();
            tileView.FireClickedAction();



            ChangeState?.Invoke(StateEnum.UnitSelected);
        }
    }
}
