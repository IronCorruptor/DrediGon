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
		
	}
	public class meleeClass : fighterClasses{
		// Setting variables
		private int velocity;
		private int atkDamage = 25;
		
		// Declaring the attack ability, ShinySword has the property of launching the player directly downwards so if the player is aerial.
		void ShinySword(bool air, bool isCollided){
			if (air == true) {
				this.velocity = -20;
			}
		}
	}
	public class magicClass : fighterClasses {
		private int atkDamage = 20;
		
		public Transform snowballPrefab;
		public float snowballSpeed = 3f;
		public float snowballDistance = 10f;
		private float sphereRadius = 0.5f;
				
		void fireball(bool isCollided, int distance){
			
		}
		void snowball(Vector3 startPosition, Quaternion rotation){
			Transform snowballProjectile;
			snowballProjectile = Instantiate(snowballPrefab, startPosition, rotation);
			
			while (snowballProjectile.position.z <= snowballDistance) {
				if (Physics.CheckSphere(snowballProjectile.transform.position, sphereRadius)){
					Destroy(snowballProjectile, 1);
					break;
				}
				snowballProjectile.transform.position += new Vector3(0, 0, 0.01f);
				void OnTriggerEnter(Collider other){
					Destroy(snowballProjectile, 2);
					other
				}
			}
		}
	}
	public class techClass : fighterClasses {
		private int atkDamage = 20;
		
	}
}
