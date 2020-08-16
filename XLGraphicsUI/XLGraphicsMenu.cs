using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace XLGraphicsUI
{
	public class XLGraphicsMenu : MonoBehaviour
	{
		public static XLGraphicsMenu Instance { get; private set; }

		public GameObject tabPanel;
		public GameObject basicContent;
		public GameObject presetsContent;
		public GameObject cameraContent;
		public GameObject presetsListContent;
		public GameObject editPresetPanel;
		public TMP_InputField renamePresetInputField;

		public void Awake() {
			Instance = this;
		}
	}
}
