using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;


[RequireComponent(typeof(ARPlaneManager))]
public class PlaceObjectOnPlane : MonoBehaviour 
{
    // public GameObject placedPrefab;
    // private GameObject placedObject;

    public GameObject[] ToPlace;

    public ARPlaneManager planeManager;

    bool toPlace = true;

    public Camera cam;

    private void Awake() 
    {
        planeManager = GetComponent<ARPlaneManager>();
        planeManager.planesChanged += PlaneChanged;
    }

    private void PlaneChanged(ARPlanesChangedEventArgs args)
    {
        // if(args.added != null && placedObject == null)
        // {
            // placedObject = Instantiate(placedPrefab, cam.transform.position + cam.transform.forward, Quaternion.Euler(0, cam.transform.eulerAngles.y, 0));
        // }
    }

    public void PlaceObj()
    {
        if(toPlace)
        {
            int index = PlayerPrefs.GetInt("ITEM", 0);
            
            Instantiate(ToPlace[index], cam.transform.position + cam.transform.forward, Quaternion.Euler(0, cam.transform.eulerAngles.y, 0));
        }
    }

    public void ToggleObjectPlacement()
    {
        toPlace = !toPlace;
    }
}