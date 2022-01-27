using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classes : MonoBehaviour
{
	public class fighterClasses {
		// Setting base stats
		public int maxHealth = 100;
		public int currentHealth = 100;
		
		// Setting the binds for all the abilities
		public string abilityBind1;
		public string abilityBind2;
		public string abilityBind3;
		public string abilityBind4;
		public string abilityBind5;
		public string abilityBindUlt;
		public string abilityBindAtk;
		
		// Setting the ability Lists
		List<string> abilityDescriptions = new List<string>();
		
		// Collision handler, make sure that damage is input, and isCollided and collidedPlayer are brought out through the function.
		public void attackCollision(bool isCollided, fighterClasses collidedPlayer, int atkDamage){
			if (isCollided == true) {
				collidedPlayer.currentHealth -= atkDamage;
			}
		}
	}
	public class meleeClass : fighterClasses{
		// Setting variables
		private int velocity;
		private int atkDamage = 25;
		
		// Declaring the attack ability, ShinySword has the property of launching the player directly downwards so if the player is aerial.
		void ShinySword(bool air, bool isCollided, fighterClasses collidedPlayer){
			if (air == true) {
				this.velocity = -20;
			}
			attackCollision(isCollided, collidedPlayer, atkDamage);
		}
	}
	public class magicClass : fighterClasses {
		private int atkDamage = 20;
				
		void fireball(bool isCollided, string[] collidedPlayers, int distance){
			
		}
		void snowball(bool isCollided, string[] collidedPlayers, string[] collidedTraps){
			attackCollision(isCollided, collidedPlayers, atkDamage);
		}
	}
	public class techClass : fighterClasses {
		private int atkDamage = 20;
		
	}
}
