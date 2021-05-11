using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerChase : MonoBehaviour
{
    private GameObject player;
    private float offsetZ;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject1 = GameObject.Find("Player");
        player = gameObject1;
        offsetZ = GetComponent<Transform>().position.z;
    }

    // Update is called once per frame
    void Update()
    {
        // Transform playerTrans = player.GetComponent<Transform>();
        Vector3 playerPosition = player.transform.position;

        // One note here, don't need to get own transform, can just use transform (see biff below)
        Transform cameraTransform = GetComponent<Transform>();

        Transform biff = this.transform;

        cameraTransform.position = new Vector3(playerPosition.x, cameraTransform.position.y, playerPosition.z + this.offsetZ);
    }
}
