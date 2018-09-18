using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {
    public TextMesh textOver;

	void Update()
	{
		if (Input.anyKey) {
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, 4, 0);
		}
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }
    }

	public void FixedUpdate()
	{
		if (GetComponent<Rigidbody2D> ().velocity.y > 0) {
			transform.rotation = Quaternion.Euler (0, 0, 0);
		} else {
			float angle = Mathf.Lerp (0, -90, (GetComponent<Rigidbody2D> ().velocity.y / 3f));
			transform.rotation = Quaternion.Euler (0, 0, angle);
		}
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        Handheld.Vibrate();
        Die();
    }

    void Die()
    {
        Application.LoadLevel("GameOverLevel");
    }
}
