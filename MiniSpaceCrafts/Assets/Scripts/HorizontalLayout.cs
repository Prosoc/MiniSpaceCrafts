using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


[ExecuteInEditMode]
public class HorizontalLayout : MonoBehaviour {
    
    public float space;
    float insideSpace;


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
            children.Add(t);
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


                //Transform t = children[i];


                Transform t = transform.GetChild(i);
                float num = ((float)i - (float)(transform.childCount) / 2 + 0.5f) * (elementWidth + insideSpace);
                //Debug.Log(num);
                RectTransform r = t.GetComponent<RectTransform>();
                if (t.GetComponent<Draggable>() && t.GetComponent<Draggable>().hovered)
                {
                    r.localPosition = new Vector3(num, 6, 0);
                    //r.localScale = new Vector3(1.1f, 1.1f, 1);


                    //t.SetSiblingIndex(transform.childCount - 1);
                }
                else
                {
                    r.localPosition = new Vector3(num, 0, 0);
                    //r.localScale = new Vector3(1, 1, 1);
                }


            }
            //recalc = false;
        }
	}

    public void AddChild(Transform t)
    {
        t.GetComponentInParent<HorizontalLayout>().RemoveChild(t);
        children.Add(t);
        t.SetParent(transform);
    }

    public void AddChildToPos(int place, Transform t)
    {
        t.GetComponentInParent<HorizontalLayout>().RemoveChild(t);
        children.Insert(place, t);
        t.SetParent(transform);
        t.SetSiblingIndex(place);
    }

    public void RemoveChild(Transform t)
    {
        Debug.Log("Remove " + t.name + " from " + transform.name);
        children.Remove(t);
    }

}
