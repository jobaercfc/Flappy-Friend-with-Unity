using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PipeSpawning : MonoBehaviour {
	public int SpawnRateMax;
	public int SpawnRateMin;
	public float MinHeight;
	public float MaxHeight;
	public GameObject pipe;
    public Text scoresheet;
    int score = 0;

    void Start()
	{
		StartCoroutine ("Spawn");
	}
    


    IEnumerator Spawn()
	{
		yield return new WaitForSeconds (Random.Range (SpawnRateMin, SpawnRateMax));

		Instantiate (pipe, new Vector3 (this.transform.position.x, Random.Range (MinHeight, MaxHeight), this.transform.position.z), this.transform.rotation);
		StartCoroutine ("Spawn");
        score++;
        scoresheet.text = (score-2).ToString();
    }
}
