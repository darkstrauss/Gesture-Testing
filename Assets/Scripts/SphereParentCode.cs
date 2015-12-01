using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class SphereParentCode : MonoBehaviour {

    private List<int> Strike1 = new List<int>();
    private List<int> Strike2 = new List<int>();
    private List<int> Strike3 = new List<int>();

    private string IDString;

    public GameObject Temp;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
   
	}

    public void AddSphereID (int IDinput)
    {
        Strike1.Add(IDinput);
    }

    public void ReturnSphereIDs()
    {
        foreach (var item in Strike1)
        {
            IDString += item + " ";

        }
        Debug.Log("returing ID's:" + IDString);
        IDString = "";
        Strike1.Clear();


    }   
}
