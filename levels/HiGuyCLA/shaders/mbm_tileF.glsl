#version 120

varying vec2 uv;
varying vec3 light_vector;
varying vec3 eye_vector;
varying vec3 vert_position;
varying vec3 normal_vector;

uniform sampler2D textureSampler;
uniform sampler2D normalSampler;
uniform sampler2D specularSampler;
uniform samplerCube skyboxSampler;

uniform vec4 ambient_color;
uniform vec3 sun_direction;
uniform vec4 sun_color;
uniform float sun_power;
uniform int specular_exponent;
uniform vec3 camera_position;
uniform float reflectivity;
uniform vec2 textureScale;
uniform mat4 rot_from_torque_mat;

void main() {
	//Correct UV based on texture scale
	vec2 scaled_uv = uv * textureScale;
	
	//Texture values
	vec3 material_color = texture2D(textureSampler, scaled_uv).rgb;
	vec3 specular_color = vec3(texture2D(textureSampler, scaled_uv).a);
	vec3 normal_color = normalize(texture2D(normalSampler, scaled_uv).rgb * 2.0 - 1.0);

	//Normalize the light vector so we can dot it
	vec3 light_normal = normalize(light_vector);

	//Cosine of the angle from the light to the normal
	float cosTheta = clamp(dot(normal_color, light_normal), 0, 1.0);

	//Opposite cosine so that sides completely in the dark are still illuminated slightly.
	// Otherwise the textures on the undersides have no bump mapping and look gross.
	float cosNtheta = clamp(dot(-normal_color, light_normal), 0.8, 1.0) + 0.1;

	//Direction of the light reflection
	vec3 light_reflection = reflect(-light_normal, normal_color);

	//Angle from the eye vector and reflect vector
	float cosAlpha = clamp(dot(normalize(eye_vector), light_reflection), 0, 1.0);

	//Diffuse color
	gl_FragColor = vec4(material_color * (sun_color.rgb * sun_color.a), 1);

	//Bump mapping
	gl_FragColor *= cosTheta;

	//Ambient color
	gl_FragColor += vec4(material_color * ambient_color.rgb * cosNtheta, 1);

	//Worldspace normal taking normal mapping into account
	vec3 normal_model = normalize(reflect(-normal_vector, normal_color));
	//Direction from camera to vertex
	vec3 camera_direction = normalize(vert_position - camera_position);
	//Reflect the camera off the normal so we know where on the skysphere to show
	vec3 camera_reflection = reflect(camera_direction, normal_model);

	//Reflected coordinates onto the given skybox
	vec3 skyboxR = mat3(rot_from_torque_mat) * camera_reflection;
	//Get the color from the skybox
	vec4 reflectionColor = textureCube(skyboxSampler, skyboxR);
	//Apply the reflected skybox color
	gl_FragColor = mix(gl_FragColor, reflectionColor, reflectivity);

	//Specular highlights
	gl_FragColor += vec4(specular_color * (sun_color.rgb * sun_color.a) * pow(cosAlpha, specular_exponent), 1);

	// gl_FragColor = reflectionColor;

	// gl_FragColor = vec4((normal_model + 1) / 2, 1);

	// gl_FragColor = vec4((normal_vector + 1) / 2, 1);

	// gl_FragColor = vec4(R, 1);

	// gl_FragColor = vec4(cosTheta);

	// gl_FragColor = vec4(eye_vector, 1);

	//gl_FragColor = vec4(1, 0, 1, 1);
	
	//gl_FragColor = vec4(normal_color, 1);
	
	//gl_FragColor = vec4(uv, 0, 1);
}