using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
	public GameObject blankFloor;
	public GameObject StationaryShooter;
	public GameObject projectile;

	public static int width = 6;
	public static int height = 75;

	private GameObject[,] map = new GameObject[width, height];

	void Start() {
		for(int y = 0; y < height; y++) {
			for(int x = 0; x < width; x++) {
				GameObject objInstance = Instantiate(blankFloor, new Vector3(x * 20, 0, y * 20), Quaternion.identity, transform);
				map[x, y] = objInstance;
			}
		}
	}
}
