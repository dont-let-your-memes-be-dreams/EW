using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChampStateMechine : MonoBehaviour {

	public BaseChamp Champion;

	public enum TurnStates
	{

		processing,
		addtolist,
		idle,
		selection,
		action,
		dead,

	}

	public TurnStates currentState;

	private float CurrentActionCD = 0f;
	private float MaxActionCD = 5f;
	public Image ActionBar; 
	// Use this for initialization
	void Start () {
		currentState = TurnStates.processing;
	}
	
	// Update is called once per frame
	void Update () {
		
		switch (currentState) 
		{
		case(TurnStates.processing):
			UpdateActionBar ();
			break;
		case(TurnStates.addtolist):
			break;
		case(TurnStates.idle):
			break;
		case(TurnStates.selection):
			break;
		case(TurnStates.action):
			break;
		case(TurnStates.dead):
			break;
		}	
	}

	void UpdateActionBar()
	{
		CurrentActionCD = CurrentActionCD + Time.deltaTime;
		float CalculateCD = CurrentActionCD / MaxActionCD;
		ActionBar.transform.localScale = new Vector3 (Mathf.Clamp (CalculateCD, 0, 1), ActionBar.transform.localScale.y, ActionBar.transform.localScale.z);

		if (CurrentActionCD >= MaxActionCD) 
		{
			currentState = TurnStates.addtolist;
		}
	}
}
