
using UnityEngine;

public class Parallax : MonoBehaviour
{
	private MeshRenderer meshRenderer;

	public float animatedSpeed = 1f;

	private void Awake()
	{
		meshRenderer = GetComponent<MeshRenderer>();
	}
	private void Update()
	{
		meshRenderer.material.mainTextureOffset += new Vector2(animatedSpeed * Time.deltaTime, 0);
	}
}
