using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {

	public float Speed;
    
	public void Update()
	{
		this.transform.Translate (-Speed, 0, 0);
	}
	void Start()
	{
		StartCoroutine ("Destroy");

	}

    

	IEnumerator Destroy()
	{
		yield return new WaitForSeconds (10);
		Destroy (this.gameObject);
	}
}
