using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


[ExecuteInEditMode]
public class HorizontalLayout : MonoBehaviour {
    
    public float space;
    float insideSpace;

    public Transform travelParent;

    public bool recalc;
    RectTransform Rect; 

    float width;
    float elementWidth;


    public List<Transform> children = new List<Transform>();
    // Use this for initialization
    void Start () {
	    Rect = GetComponent<RectTransform>();
        children.Clear();
        foreach (Transform t in transform)
        {
            t.GetComponent<Draggable>().travelLayer = travelParent;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (recalc)
        {
            Rect = GetComponent<RectTransform>();
            RectTransform le = GetComponentInChildren<RectTransform>();
            if (le != null)
            {
                elementWidth = 120;
            }
            else
            {
                elementWidth = 120;
            }
            
            width = Rect.rect.width;
            insideSpace = Mathf.Clamp((width - (elementWidth * (transform.childCount + 1))) / transform.childCount, -elementWidth * 0.8f, space);
            for (int i = 0; i < transform.childCount; i++)
            {

                Transform t = transform.GetChild(i);
                float num = ((float)i - (float)(transform.childCount) / 2 + 0.5f) * (elementWidth + insideSpace);
                //Debug.Log(num);
                RectTransform r = t.GetComponent<RectTransform>();
                
                
                if (t.GetComponent<Draggable>() && t.GetComponent<Draggable>().hovered)
                {                    
                    if (Vector3.Distance(r.localPosition, new Vector3(num, 0)) < 100)
                    {
                        r.localPosition = new Vector3(Mathf.Lerp(r.localPosition.x, num, Time.deltaTime * 15), Mathf.Lerp(0, r.localPosition.y, Time.deltaTime * 10), 0);
                        //r.localPosition = new Vector3(Mathf.Lerp(r.localPosition.x, num, Time.deltaTime * 15), Mathf.Lerp(0, 100, Time.deltaTime * 10), 0);
                    }
                    else
                    {
                        r.localPosition = new Vector3(num, 0, 0);
                    }

                    
                }
                else
                {
                    if (Vector3.Distance(r.localPosition, new Vector3(num, 0)) < 300)
                    {
                        r.localPosition = new Vector3(Mathf.Lerp(r.localPosition.x, num, Time.deltaTime * 15), Mathf.Lerp(r.localPosition.y, 0, Time.deltaTime * 10), 0);
                    }
                    else
                    {
                        r.localPosition = new Vector3(num, 0, 0);
                    } 
                }


            }
            //recalc = false;
        }
	}    


}
