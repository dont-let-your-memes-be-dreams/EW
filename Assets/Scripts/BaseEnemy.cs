using UnityEngine;
using System.Collections;

public class BaseEnemy : MonoBehaviour {

	public string name;

	public enum ElementType
	{
		Nature,
		Fire,
		Water,
		Earth,
		Electric,
		Mystic,

	}

	public ElementType champType;

	public float baseHP;
	public float baseAP;

	public float baseATK;
	public float baseSpeed;
	public float baseDEF;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
