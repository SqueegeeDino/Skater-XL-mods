using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine.UI;

namespace XLGraphicsUI.Elements.EffectsUI
{
	public class FilmGrainUI : UIsingleton<FilmGrainUI>
	{
		public Toggle toggle;
		public XLSlider intensity;
		public XLSlider response;
		public TMP_Dropdown type;
	}
}