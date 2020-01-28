using UnityEngine; // Import the UnityEngine's library
using TMPro; // Import the TMPro's library

public class ResourcesManager : MonoBehaviour {

    [Header("Resources Quantities")] //Shows the name of that group in the Inspector
    public int woodQuantity; // A int variable that contains the quantity of wood
    public int stoneQuantity; // A int variable that contains the quantity of stone
    //public int ironQuantity; // A int variable that contains the quantity of iron

    [Header("Text GameObjects")] //Shows the name of that group in the Inspector
    public TextMeshProUGUI woodTxt; // A text object that show the quantity of wood
    /*public TextMeshProUGUI stoneTxt; // A text object that show the quantity of stone
    public TextMeshProUGUI ironTxt;*/ // A text object that show the quantity of iron

    void FixedUpdate() {

        woodTxt.text = "Wood: " + woodQuantity; //Shows the quantity of wood in the UI
        /*stoneTxt.text = "Stone: " + stoneQuantity; //Shows the quantity of stone in the UI
        ironTxt.text = "Stone: " + ironQuantity; */ //Shows the quantity of iron in the UI
    }

    public void AddResourceToGroup(string name, int quantity) { // This function adds an quantity of a given resource to the player's inventory

        if (name == "Wood") {

            woodQuantity += quantity;

        } else if (name == "Stone") {

            stoneQuantity += quantity;

        } /*else if (name == "Iron") {

            ironQuantity += quantity;
        }*/
    }

    public void SubstractResources(string ResourceName, int resourcesQuantity) { // This function removes an quantity of a given resource from the player's inventory

        if (ResourceName == "Wood") {

            woodQuantity -= resourcesQuantity;

        } else if (ResourceName == "Stone") {

            stoneQuantity -= resourcesQuantity;

        } /*else if (ResourceName == "Iron") {

            ironQuantity -= resourcesQuantity;
        }*/
    }
}
