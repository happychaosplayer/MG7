# MG7
## Devlog
1. I first created a GameObject array so that I could drag in the _sparrow game objects into the elements provided by this class. It is serialized so that we can edit the amount of _sparrows and have the ability to drag the gameobjects in. In update, inside my for loop, I created an if statement to set the game object to be active if the Vector 3 value (transform.position in this case) between the sparrows (other than the starting one) and the the player is less than the value of my set interaction distance.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
