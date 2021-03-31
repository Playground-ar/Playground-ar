using UnityEngine;
using System.Collections;

public class Restriction : MonoBehaviour
{
 // speed of player
    // Update is called once per frame
    void Update()
    {
        float UpDownMovement = Input.GetAxis("Vertical") * Time.deltaTime;

        Vector3 pos = transform.position;

        pos += new Vector3(0, UpDownMovement);
        pos.z = Mathf.Clamp(pos.z, 0, 0);

        transform.position = pos;

    }
}