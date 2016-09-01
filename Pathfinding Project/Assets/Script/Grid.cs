using UnityEngine;
using System.Collections;


public class Grid : MonoBehaviour {

	public int row;
	public int column;
	public GameObject prefab;
	public GameObject canvas;

	// Use this for initialization
	void Start () {
	

		for (int i = 0; i < column; i++) {
			int y = 0;
			for (int j = 0; j < row; j++){

				GameObject createImage = Instantiate (prefab) as GameObject;
				createImage.transform.SetParent (canvas.transform, false);
				createImage.transform.position = new Vector2(createImage.transform.position.x + i*2,
				                                             createImage.transform.position.y + i*y);
			}
			y += 2;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
