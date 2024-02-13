
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject prefab;

	public float spawnrate = 1f;

	public float minheight = -1f;
	public float maxheight = 1f;

	private void OnEnable()
	{
		InvokeRepeating(nameof(spawn), spawnrate, spawnrate);
	}
	private void OnDisable()
	{
		CancelInvoke(nameof(spawn));
	}
	private void spawn()
	{
		GameObject pipe = Instantiate(prefab, transform.position, Quaternion.identity);
		pipe.transform.position += Vector3.up * Random.Range(minheight, maxheight);
	}
}
