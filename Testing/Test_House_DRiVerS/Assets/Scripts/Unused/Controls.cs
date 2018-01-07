using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;
using System.Collections.Generic;
using System;

public class Controls : MonoBehaviour
	{
		[SerializeField] public static KeyBoardPreSets keyboardSetting = KeyBoardPreSets.WASD;
	[SerializeField] public static XBoxPreSets xBoxSetting = XBoxPreSets.DEFAULT;
		[SerializeField] public static ControlType controller = ControlType.KEYBOARD;

		float rotation;
		float velocity;

		List<KeyCode> keysPressed;

		[SerializeField]
		public enum ControlType
		{
			XBOX,
			KEYBOARD
		}

		[SerializeField]
		public enum XBoxPreSets
		{
			DEFAULT,
			CLAW,
		}

		[SerializeField]
		public enum KeyBoardPreSets
		{
			WASD,
			ARROWS
		}

		List<KeyCode> WASD = new List<KeyCode>
		{
			KeyCode.W,
			KeyCode.S,
			KeyCode.A,
			KeyCode.D,
			KeyCode.Space
		};
			
		List<KeyCode> Arrows = new List<KeyCode>
		{
			KeyCode.UpArrow,
			KeyCode.DownArrow,
			KeyCode.LeftArrow,
			KeyCode.RightArrow,
			KeyCode.Space
		};

		private List<KeyCode> GetKeysPressed()
		{
			List<KeyCode> keys = new List<KeyCode>();
			if (Input.anyKeyDown)
			{
				//Saves the keys that were being hold down
				foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
				{
					if (Input.GetKey(kcode))
					{
						keys.Add(kcode);
					}
				}
			}
			return keys;
		}

	private float getRotationAmount(float multiplier)
		{
			float temp = ((velocity / 350) * multiplier);
			velocity -= (temp * 0.5f);
			return temp;
		}

		private float getAcceleration(float goingForward)
		{
			if(goingForward > 0)
			{
				if (velocity > 450)
				{
				return (0.5f * goingForward);
				}
				else if (velocity > 400)
				{
				return(1f * goingForward);
				}
				else if (velocity > 250)
				{
				return (1.5f * goingForward);
				}
				else if (velocity > 100)
				{
				return (2f * goingForward);
				}
				else if (velocity > 0)
				{
				return (2.5f * goingForward);
				}
			}
			else
			{
				if (velocity < -500)
				{
				return (0.5f * goingForward);
				}
				else if (velocity < -400)
				{
				return (1f * goingForward);
				}
				else if (velocity < -250)
				{
				return (1.5f * goingForward);
				}
				else if (velocity < -100)
				{
				return (2f * goingForward);
				}
				else if (velocity < -0)
				{
				return (2.5f * goingForward);
				}
			}
			return 1;
		}

		//List<KeyCode> XBOX1 = new List<Keycode> {
			
		//};

		//List<KeyCode> XBOX2 = new List<Keycode> {

		//};

		//List<KeyCode> XBOX3 = new List<Keycode> {

		//};
			
		// name: default
		// forward = C_vertical 1
		// backward = C_vertical -1
		// left = C_horizontal -1
		// right = C_horizontal 1
		// break = B_button
		// 
		// name: claw
		// forward = C_vertical 1
		// backward = C _ vertical -1
		// left =  C_horizontal -1
		// right = C_horizontal 1
		// break = C_RightBumper
		//
		// name: default
		// forward = C_vertical -1
		// backward = C_vertical 1
		// left = C_horizontal 1
		// right = C_horizontal -1
		// break = B_button
		// 
		// name: claw
		// forward = C_vertical -1
		// backward = C _ vertical 1
		// left =  C_horizontal 1
		// right = C_horizontal -1
		// break = C_RightBumper


		//Test this should be functional
		private float GetRotationValue() {
		if (controller == ControlType.XBOX) {
			switch (xBoxSetting) {
			case XBoxPreSets.DEFAULT:
				return Input.GetAxis ("C_Horizontal");
			case XBoxPreSets.CLAW:
				return Input.GetAxis ("C_Horizontal");
			}
		} else {
			if (keysPressed.Contains (GetKeyList()[2]) && keysPressed.Contains (GetKeyList()[3])) {
				return 0;
			}
			else if(keysPressed.Contains(GetKeyList()[2])) {
				return 1;
			}
			else if(keysPressed.Contains(GetKeyList()[3])) {
				return -1;
			}
		}
		return 0;
		}

	//Test this should be done
	private float getAcceleration() {
		if (controller == ControlType.XBOX) {
			switch (xBoxSetting) {
			case XBoxPreSets.DEFAULT:
				return Input.GetAxis ("C_Vertical");
			case XBoxPreSets.CLAW:
				return Input.GetAxis ("C_Vertical");
			}
		} else {
			if (keysPressed.Contains (GetKeyList()[0]) && keysPressed.Contains (GetKeyList()[1])) {
				return 0;
			}
			else if(keysPressed.Contains(GetKeyList()[0])) {
				return 1;
			}
			else if(keysPressed.Contains(GetKeyList()[1])) {
				return -1;
			}
		}
		return 0;
	}
		private List<KeyCode> GetKeyList()
		{
			switch(controller)
			{
			case ControlType.KEYBOARD:
				switch(keyboardSetting)
				{
				case KeyBoardPreSets.ARROWS:
					return Arrows;
				case KeyBoardPreSets.WASD:
					return WASD;
				}
				break;
			case ControlType.XBOX:
				switch (xBoxSetting) {
			case XBoxPreSets.DEFAULT:
				return null;
			case XBoxPreSets.CLAW:
				return null;
				}
				break;
			}
			return null;
		}

	private void Update() {
		customCarController.MoveCar (GetRotationValue (), getAcceleration ());
	}
}
