/*
 Changed the material for the ground, obstalce, player, and wall

 Made the obstacle bigger
Changed directional light to black, hard shadow, intensity fromm 1 to now 5
Attached a cube with a radar to the player. To get the feel of a robot
Added fog and gave it a dark grey color. Changed density to 0.01 to keep the scene as dark as possible
Chose a darker material for the realtime shadow color

Obstacle: Resized this to a flat rectangle of water. Water is bad for robo-chan (player). Changed the material to water. Give it a red light for a danger indicator

Remade the Kirby object I made at the beginning of the semester as a companion.  I orginally made him a obstacle but it was challenging having three obstacles
in this game. Plus it adds more custumization to the player 

Hammer: Did the same with the hammer prefab but changed the color of the material and tweaked on the particle effects. Changed the time amount to -5.0.  Did it to make the player
want to avoid it more since it takes 5 seconds off the play time.  Water is bad! Changed the duration to 1 second, max particles to 250, changed shape to mesh,
rate over time 1500, start life time set to 100. Set the light color to red for a danger indicator. Applied a danger texture and another texture of mixed textures from the book assets.
Attached a particle system shape as a cone to give the illusion that it's flying since the hammer is above the ground a bit. Gave the material a red color. Rate over time to 50, set the mode
to ribbon, ribbon count to 5, set the renderer mode to streched billboard

Powerup: Gave the phased out material to particle effect materia and powerup.  Changed light range to a 2, intensity to 10, start life time 0.5
( was higher but I noticed some lag) rate over time to 20, radius 1.5, increased time amount to 3

Walls: Made the walls into prefabs and changed the material for both of the walls.  I chose the two games I've enjoyed the most for 2024 as materials.

Doughnut: Adding the delicous doughnut to the scene. Added two materials onto it and instantiated 26 copies of it. Adjusted speed for the doughscript to -5f because it was
dissappearing from game when played

Audio: I like adding audio to my games. Here's the titles of the audio just in case you want to save then.

Final Fantasy X - Macalania Forest (NegroSaki Remix)

Changing Seasons -Reload- - Persona 3 Reload Original Soundtrack

DEV NOTE: Tifa should've been chosen as the guest character instead of Clive.  We were robbed! Robbed!  

 */
