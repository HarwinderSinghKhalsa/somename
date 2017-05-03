using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeBehaiviour : MonoBehaviour {


    enum Direction { Left,Right};

    Direction d = Direction.Left;

    enum DirectionY { Up,Down};

    DirectionY dy = DirectionY.Up;

    enum DirectionZ {In, Out };

    DirectionZ dz = DirectionZ.In;


    // Use this for initialization
    void Start () {
		
	}

    public GameObject go;
    // Update is called once per frame
    void Update () {


       Vector3 currPosition = gameObject.transform.position;

    

        if(currPosition.x < -1) {
            go.GetComponent<textBehaviour>().IncrementCounter();
            d = Direction.Right; }
        if (currPosition.x > 1) { d = Direction.Left; }
       if(d== Direction.Right) { currPosition.x += Time.deltaTime; }
        if (d == Direction.Left) { currPosition.x -= Time.deltaTime; }

        if(currPosition.y <-0.5) { dy = DirectionY.Up; }
        if (currPosition.y > 0.5) { dy = DirectionY.Down; }
        if(dy== DirectionY.Up) { currPosition.y += Time.deltaTime * 2; }
        if(dy== DirectionY.Down) { currPosition.y -= Time.deltaTime * 2; }

        if (currPosition.z < -1.5) { dz = DirectionZ.In; }
        if (currPosition.z > 1.5) { dz = DirectionZ.Out; }
        if (dz == DirectionZ.In) { currPosition.z += Time.deltaTime * 2; }
        if (dz == DirectionZ.Out) { currPosition.z -= Time.deltaTime * 2; }


        gameObject.transform.position = currPosition;



		
	}
}
