using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class ProgrammManager : MonoBehaviour
{
    [Header("Your plane marker")]
    [SerializeField] private GameObject PlaneMarkerPrefab;
    private ARRaycastManager ARRaycastManagerScript;
    private Vector2 TouchPosition;
    public GameObject ObjectToSpawn;
    public int ChooseCategory = 0;
    public bool ChOb = false;

    void Start()
    {
        ARRaycastManagerScript = FindObjectOfType<ARRaycastManager>();
        PlaneMarkerPrefab.SetActive(false);
    }
    void Update()
    {
        if (ChOb)
        {
            ShowMarker();
        }
    }

    void ShowMarker()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        ARRaycastManagerScript.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);
       
        if (hits.Count > 0)
        {
            PlaneMarkerPrefab.SetActive(true);
            PlaneMarkerPrefab.transform.position = hits[0].pose.position;
        }

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Instantiate(ObjectToSpawn, hits[0].pose.position, ObjectToSpawn.transform.rotation);
            ObjectToSpawn = null;
            ChOb = false;
        }
    }
} 