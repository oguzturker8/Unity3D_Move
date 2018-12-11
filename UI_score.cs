using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text score;

	void Update(){ 
	
	score.Text = player.position.z.ToString();

	}
}