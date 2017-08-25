using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public int maxCards = 1; 
    public void OnPointerEnter(PointerEventData eventData) {
        //Debug.Log("OnPointerEnter - 1");
        if (eventData.pointerDrag == null)
            return;

        //Debug.Log("OnPointerEnter - 2");

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        
        if (d != null)
        {
            //Debug.Log((transform.childCount <= maxCards + 1).ToString() + " " + (transform.childCount) + " <= " + (maxCards + 1));
            if (transform.childCount < maxCards)
            {
                d.placeholderParent = this.transform;
                //Debug.Log("OnPointerEnter - 3");
            }
            else
            {
                //d.placeholderParent = this.transform;
            }
        }
    }
	
	public void OnPointerExit(PointerEventData eventData) {
		//Debug.Log("OnPointerExit");
		if(eventData.pointerDrag == null)
			return;

		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if(d != null && d.placeholderParent==this.transform) {
			d.placeholderParent = d.parentToReturnTo;
		}
	}
	
	public void OnDrop(PointerEventData eventData) {
        //Debug.Log (eventData.pointerDrag.name + " was dropped on " + gameObject.name);

        if (transform.childCount <= maxCards)
        {
            Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
            if (d != null)
            {
                d.parentToReturnTo = this.transform;
            }
        }


	}
}
