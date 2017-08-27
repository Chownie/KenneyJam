using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {
	public GameObject blankFloor;
	public GameObject StationaryShooter;

	public static int width = 10;
	public static int height = 75;

	private GameObject[,] map = new GameObject[width, height];

	void Start() {
		for(int y = 0; y < height; y++) {
			for(int x = (0-width/2); x < width/2; x++) {
				GameObject objInstance = Instantiate(blankFloor, new Vector3(x * 20, 8, y * 20), Quaternion.identity, transform);
				map[x + (width/2), y] = objInstance;
			}
		}
	}
}
