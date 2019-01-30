using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurnLineOnOff : MonoBehaviour {

	public Toggle Toggle;
	public TrailRenderer TrailRenderer;
	
	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	private void Start()
	{
		if(PlayerPrefs.HasKey("TrailRenderer.enabled"))
		{
			var isOn = PlayerPrefs.GetInt("TrailRenderer.enabled") == 1;
			TrailRenderer.enabled = isOn;
			Toggle.isOn = isOn;
		}
		
	}

	public void ChangeValue(bool isOn)
	{
		TrailRenderer.enabled = isOn;
		PlayerPrefs.SetInt("TrailRenderer.enabled", isOn ? 1 : 0);
	}

}
