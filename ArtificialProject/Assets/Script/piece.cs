using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piece : MonoBehaviour {

    [SerializeField]
    private float lerpTime = 1f;
    [SerializeField]
    private float rayLength = 100f;

    private new Transform transform;
    private Collider coll;
    private Vector3 origin;
    private Vector3 rayDirection;

	void Start () {
        transform = GetComponent<Transform>();
        coll = GetComponent<Collider>();
        origin = transform.position;
        rayDirection = new Vector3(0, -1, 0); // instead of -y, calculate direction based on board angle
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R pressed");
            onRelease();
        }
	}

    void onRelease()
    {
        Ray ray = new Ray(transform.position, rayDirection);
        RaycastHit hit;
        Debug.DrawRay(transform.position, rayDirection*rayLength, Color.red, 1f, true);
        if (Physics.Raycast(ray, out hit, rayLength)) {
            Debug.Log(hit.collider.gameObject.name);
            GameObject hitObj = hit.collider.gameObject;

            StartCoroutine(LerpXZOverTime(hitObj, lerpTime));
        }
    }

    IEnumerator LerpXZOverTime(GameObject toLerp, float totalTime)
    {
        float startTime = Time.time;
        float timeRatio = 0f;

        Vector3 tilePos = toLerp.GetComponent<Transform>().position;

        while (timeRatio < 1f)
        {
            timeRatio = (Time.time - startTime) / totalTime;
            if (timeRatio > 1) timeRatio = 1f;

            Vector3 pos = transform.position;

            transform.position = Vector3.Lerp(
                pos,
                new Vector3(
                    tilePos.x,
                    transform.position.y,
                    tilePos.z
                ),
                timeRatio
            );

            //if (tilePos.x > x) transform.position.x += 

            if (timeRatio == 1)
            { // Clean up
                transform.position = new Vector3(
                    tilePos.x,
                    transform.position.y,
                    tilePos.z
                );
                break;
            }

            yield return null;
        }
    }
}
