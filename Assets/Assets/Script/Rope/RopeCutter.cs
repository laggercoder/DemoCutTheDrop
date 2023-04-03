using UnityEngine;

public class RopeCutter : MonoBehaviour
{

	// Update is called once per frame
	void Update()
	{
		// update check dragging
		if (Input.GetMouseButton(0) && !MoveByMouse.moveByMouse.isDragging)
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			if (hit.collider != null)
			{
				if (hit.collider.tag == "Link")
				{
					Destroy(hit.collider.gameObject);
				}
			}
		}
	}
}