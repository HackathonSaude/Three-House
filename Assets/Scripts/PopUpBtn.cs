using UnityEngine;
using System.Collections;

public class PopUpBtn : MonoBehaviour 
{
	void OnMouseDown()
	{
		if (this.tag == "open")//escolho se o artigo vai ser aberto ou fechado e indico q a decisao foi tomada
		{
			PopUpManager.open = 1;
		}
		if (this.tag == "close")
		{
			PopUpManager.open = 2;
		}
	}
}