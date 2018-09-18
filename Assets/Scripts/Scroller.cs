using UnityEngine;
using System.Collections;

public class Scroller : MonoBehaviour {

	public float scrollSpeed;
	public float TileSize;

	private Vector3 startPosition;

	void Start()
	{
		startPosition = this.transform.position;
	}

	void Update()
	{
		float newPosition = Mathf.Repeat (Time.time * scrollSpeed, TileSize);
		transform.position = startPosition + Vector3.right * newPosition;
	}
}
