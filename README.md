# OpenGL-Paint

This project is made with Glitter: https://github.com/Polytonic/Glitter

Follow the guide above to install glitter (you also need to D/L cmake command line tools) and replace the main.cpp and place frag/vert shaders inside the glitter folder and make sure to change reference to the shader file's location in the main.cpp file.

This is an attempt to get ping-pong buffering to work, as to create a basic paint shader, and allows user to draw on a canvas with a mouse. This is the particular
shader I'm trying to port currently: https://www.shadertoy.com/view/3lfczf

This simple set up leads is the first step in achieving rather complex rendering texhniques such as 2D fluid solving and diffusion.

This project is currently unfinsihed. Ping-pong buffering is yet to be realised properly. If you would like to help out I'd be more than grateful, as I'm a hobbyiest with no formal education in computer graphics, I've just been following along with tutorials from: https://learnopengl.com/ and have asked questions on
reddit's computer graphics forum: https://www.reddit.com/r/GraphicsProgramming/comments/hmgi6o/can_anyone_of_you_help_me_solve_rendering_to_a/

A user has helped me identify the technique needed, called pingpong buffering, and I've tried to implement his suggestion using OnEndFrame() swap buffers, however the implementation is still not working correctly. If anyone can spot what's going wrong please let me know.
