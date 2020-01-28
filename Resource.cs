using UnityEngine; // Import the UnityEngine's library

public class Resource : MonoBehaviour {

    public string resourceName; // Resource's name
    public int life; // Resource's Life
    public int quantityValue; // Value of resources that will be added to inventory
    public ResourcesManager resourcesManager; // ResourcesManager's script
    public CharactersManager charactersManager; // CharacterManager's script (or the player's script, if there is only on character controlled by the player)

    void Start() { 

        resourcesManager = GameObject.Find("BuildingSystem").GetComponent<ResourcesManager>(); // Find the ResourcesManager's script in a BuildingSystem's GameObject and assign it in the resourcesManager
        charactersManager = GameObject.Find("Manager").GetComponent<CharactersManager>(); // Find the CharactersManager's script in a Manager's GameObject and assign it in the charactersManager
    }

    void FixedUpdate() {

        VerifyLife(); // Call the VerifyLife's function
    }

    void AddResourceToManager(string name, int value) { // Add a resource to the player's inventory

        resourcesManager.AddResourceToGroup(name, value); // Call the "AddResourceToGroup" function in the ResourcesManager's script to add the resource to the player's inventory

        charactersManager.SetUnitCuttingBool(false); // Call the "SetUnitCuttingBool" function in the CharactersManager's script to cancel the player's interaction animation with the resource
        charactersManager.RemoveActualResource(); // Call the "RemoveActualResource" function in the CharactersManager's script to remove the target on this resource

        Destroy(this.gameObject); // Destroy this GameObject (the resource)
    }

    void VerifyLife() { // Resource life's condition

        if (life <= 0) {

            AddResourceToManager(resourceName, quantityValue); // Call the "AddResourceToManager" function to add that resource to the player's inventory
        }
    }

    public void TakeDamage(int damage) { // Decreases that resource's life

        life -= damage;

        print(life);
    }
}
