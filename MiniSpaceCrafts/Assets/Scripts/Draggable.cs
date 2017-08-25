using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler
{
	
	public Transform parentToReturnTo = null;
	public Transform placeholderParent = null;

	GameObject placeholder = null;

    bool down;

    public bool hovered;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
        {
            ////Debug.Log("p enter");
            //GetComponent<CanvasGroup>().blocksRaycasts = true;
            //transform.localScale = new Vector3(1.1f, 1.1f, 1);
            hovered = true;
        }
        else
        {
            //GetComponent<CanvasGroup>().blocksRaycasts = false;
            //transform.localScale = new Vector3(1, 1, 1);
            hovered = false;
        }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        //if not dragging already
        if (eventData.pointerDrag == null)
        {
            ////Debug.Log("p exit");
            //GetComponent<CanvasGroup>().blocksRaycasts = true;
            //transform.localScale = new Vector3(1, 1, 1);
            hovered = false;
        }
        else
        {
            //transform.localScale = new Vector3(1, 1, 1);
            //GetComponent<CanvasGroup>().blocksRaycasts = true;
            hovered = false;
        }
    }

    public void OnBeginDrag(PointerEventData eventData) {
        //Debug.Log ("OnBeginDrag");
        
        placeholder = new GameObject(); //create placeholder for card while dragging 


        //this.transform.parent.GetComponent<HorizontalLayout>().AddChildToPos(this.transform.GetSiblingIndex(), placeholder.transform); //set it's parent to the cards parent


        placeholder.transform.SetParent(this.transform.parent);
        placeholder.transform.SetSiblingIndex(this.transform.GetSiblingIndex());
        placeholder.AddComponent<RectTransform>();
		parentToReturnTo = this.transform.parent; //set the card's parent
		placeholderParent = parentToReturnTo;
		this.transform.SetParent( this.transform.parent.parent );
		
		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}
	
	public void OnDrag(PointerEventData eventData) {
        //Debug.Log ("OnDrag");
        //Debug.Log(eventData.position);
        this.transform.position = eventData.position; // set card's position to mouse position
        if (placeholder.transform.parent != placeholderParent) //reset placeholder's parent if it's at the wrong place


            //placeholderParent.GetComponent<HorizontalLayout>().AddChild(placeholder.transform);


            placeholder.transform.SetParent(placeholderParent);

		int newSiblingIndex = placeholderParent.childCount; 

		for(int i=0; i < placeholderParent.childCount; i++) {
			if(this.transform.position.x < placeholderParent.GetChild(i).position.x) {

				newSiblingIndex = i;

				if(placeholder.transform.GetSiblingIndex() < newSiblingIndex)
					newSiblingIndex--;

				break;
			}
		}

		placeholder.transform.SetSiblingIndex(newSiblingIndex); //set it's place in layout

    }
	
	public void OnEndDrag(PointerEventData eventData) {
        //Debug.Log ("OnEndDrag");


        //placeholderParent.GetComponent<HorizontalLayout>().AddChildToPos(placeholder.transform.GetSiblingIndex(), this.transform);


        this.transform.transform.SetParent(placeholderParent);
        this.transform.transform.SetSiblingIndex(placeholder.transform.GetSiblingIndex());
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        //placeholder.transform.parent.GetComponent<HorizontalLayout>().RemoveChild(placeholder.transform);

        Destroy(placeholder);

    }
}
