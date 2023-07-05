using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ColorChangeOverTime : MonoBehaviour {
	readonly WaitForSeconds _wfs = new(1);

	[SerializeField]
	Image _panelImage;

	IEnumerator Start() {
		while (true) {
			_panelImage.color = Random.ColorHSV(0.1f, 0.9f);
			yield return _wfs;
		}
	}
}
